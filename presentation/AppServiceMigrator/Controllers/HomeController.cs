using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MigrationAcceleratorApp.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace MigrationAcceleratorApp.Controllers
{
    public class HomeController : Controller
    {
        //Startup View
        public IActionResult AppInformation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AppInformation(string appFramework, string deployment, string zipFolder, string container)
        {
            AppServiceConfiguration appSvcCfg = new AppServiceConfiguration();
            appSvcCfg.AppRuntime = appFramework;
            appSvcCfg.DeploymentType = deployment;
            appSvcCfg.appdirectory = zipFolder;
            appSvcCfg.Container = container;
            string json = JsonConvert.SerializeObject(appSvcCfg);
            TempData["appInfo"] = json;
            //save data to a property file
            List<string> resourceGrpList = new List<string>();
            resourceGrpList.Add("PaaSAcceleratorTest");
            resourceGrpList.Add("AppServiceGroup");
            resourceGrpList.Add("CloudServiceGroup");

            var model = new AzAccountsViewModel();
            model.ResourceGroupList = resourceGrpList;
            TempData.Keep("appInfo");
            return View("AzConfigurations", model);
        }
        [HttpPost]
        public IActionResult AzConfigurations(string Subscription, string AzLocation, string AzAppSvcPlan, string AzAppName)
        {
            AppServiceConfiguration appSvcCfg = new AppServiceConfiguration();
            appSvcCfg.ResourceGrp = Subscription;
            appSvcCfg.location = AzLocation;
            appSvcCfg.appSvcPlan = AzAppSvcPlan;
            appSvcCfg.paaswebapp = AzAppName;
            string json = (string)TempData["appInfo"];
            AppServiceConfiguration appSvcCfgTemp = JsonConvert.DeserializeObject<AppServiceConfiguration>(json);
            appSvcCfg.AppRuntime = appSvcCfgTemp.AppRuntime;
            appSvcCfg.DeploymentType = appSvcCfgTemp.DeploymentType;
            appSvcCfg.appdirectory = appSvcCfgTemp.appdirectory;
            appSvcCfg.Container = appSvcCfgTemp.Container;

            return View("ReviewInformation", appSvcCfg);
        }

        [HttpPost]
        public IActionResult ReviewInformation(AppServiceConfiguration model)
        {
            model.ID = Guid.NewGuid();
            string json = JsonConvert.SerializeObject(model);
            ViewBag.ID = model.ID;

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "msgKey",
                                     //queue: model.ID.ToString(),
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                //Console.WriteLine("Enter message to send");
                //var msg = Console.ReadLine();
                //var body = Encoding.UTF8.GetBytes(msg);
                var body = Encoding.UTF8.GetBytes(json);
                channel.BasicPublish(exchange: "",
                                     routingKey: "msgKey",
                                     //routingKey: model.ID.ToString(),
                                     basicProperties: null,
                                     body: body);
                //Console.WriteLine(" [x] Sent {0}", msg);
            }
            return View("Acknowledgement");
        }
        public IActionResult Acknowledgement()
        {
            return View();
        }
        public IActionResult InformationUpdates()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult _fileUploadForm(int Id)
        {
            ViewBag.Id = Id;
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile zipFolder)
        {
            if (zipFolder == null || zipFolder.Length == 0)
                return Content("file not selected");
           var path = @"C:\PaaSAccelerators\FileServer";
           using (var stream = new FileStream(Path.Combine(path, zipFolder.FileName), FileMode.Create))
           {
                await zipFolder.CopyToAsync(stream);
            }

            return RedirectToAction("AppInformation");
        }
    }
}
