using Newtonsoft.Json.Linq;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Diagnostics;
using System.Text;

namespace PaaSAcceleratorEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            GetJob();
            Console.WriteLine("Engine");
        }
        public static int RunPowershellScript(string ps)
        {
            int errorLevel;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("powershell.exe", "-File " + ps);
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            
            process = Process.Start(processInfo);
            process.WaitForExit();

            errorLevel = process.ExitCode;
            process.Close();

            return errorLevel;
        }

        static void GetJob()
        {
            Console.WriteLine("Hello this is the Receiver application!");
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "msgKey",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);

                    //Process Request using Powershell
                    if (message != "")
                    {
                        JObject jo = JObject.Parse(message);
                        string rg = jo["ResourceGrp"].ToString();
                        string location = jo["location"].ToString().Replace(" ", "@");
                        string appSvcPlan = jo["appSvcPlan"].ToString();
                        string paasweb = jo["paaswebapp"].ToString();
                        string scriptFile = @"C:\PaaSAccelerators\scripts\ps\appSvcDeploymentTemp.ps1" +
                        " -resourceGroup " + rg +
                        " -location " + location +
                        " -appSvcPlan " + appSvcPlan +
                        " -paaswebapp " + paasweb;
                        Console.WriteLine(scriptFile);
                        RunPowershellScript(scriptFile);
                    }
                };
                channel.BasicConsume(queue: "msgKey",
                                     autoAck: true,
                                     consumer: consumer);


                
                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }

        }
    }
}
