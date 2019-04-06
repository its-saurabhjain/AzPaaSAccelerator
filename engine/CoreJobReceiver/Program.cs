using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace CoreJobReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread workerThread = new Thread(GetJob);
            workerThread.Start();
        }
        static int RunPowershellScript(string ps, string param)
        {
            int errorLevel;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("powershell.exe", "-File " + ps);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            errorLevel = process.ExitCode;
            process.Close();

            return errorLevel;
        }
        static void GetJob() {
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
                string message = string.e;
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);
                };
                channel.BasicConsume(queue: "msgKey",
                                     autoAck: true,
                                     consumer: consumer);

                //Process Request using Powershell
                RunPowershellScript("", message);
                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }

        }
    }
}
