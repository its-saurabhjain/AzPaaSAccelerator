using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;

namespace ContainerConfigurator
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "settings.json";
            StreamReader sr1 = new StreamReader(path);
            string filedata = sr1.ReadToEnd();
            JObject jo = JObject.Parse(filedata);
            string fileName = jo["Config"]["FilePath"].ToString();
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("FROM mcr.microsoft.com/dotnet/framework/aspnet:4.7.2-windowsservercore-ltsc2019");
                    fs.Write(title, 0, title.Length);
                }
                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
