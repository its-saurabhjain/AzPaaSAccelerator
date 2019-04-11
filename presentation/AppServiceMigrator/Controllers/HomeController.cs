using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MigrationAcceleratorApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RabbitMQ.Client;

namespace MigrationAcceleratorApp.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _config;
        public HomeController(IConfiguration config)
        {
            _config = config;
        }
        //Startup View
        public IActionResult AppInformation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AppInformation(string appFramework, string deployment, string zipFile, string container, string gitRepoUrl)
        {
            AppServiceConfiguration appSvcCfg = new AppServiceConfiguration();
            appSvcCfg.AppRuntime = appFramework;
            appSvcCfg.DeploymentType = deployment;
            appSvcCfg.appdirectory = _config.GetValue<string>("FileServer");
            appSvcCfg.zipFileName = zipFile;
            appSvcCfg.Container = container;
            appSvcCfg.GitUrl = gitRepoUrl;
            string json = JsonConvert.SerializeObject(appSvcCfg);
            TempData["appInfo"] = json;
            TempData["container"] = container;
            //Get Resource group and subscription information from Az API
            List<string> resourceGrpList = new List<string>();
            string resourceGrps = await GetDataAsync();
            if (resourceGrps != null)
            {
                string rs = resourceGrps.Replace("[", "").Replace("]", "").Replace("\"", "");
                string[] grpList = rs.Split(",");
                foreach (var o in grpList)
                {
                    resourceGrpList.Add(o.ToString());
                }
            }
            else
            {
                resourceGrpList.Add("PaaSAcceleratorTest");
                resourceGrpList.Add("AppServiceGroup");
                resourceGrpList.Add("CloudServiceGroup");

            }
            var model = new AzAccountsViewModel();
            model.ResourceGroupList = resourceGrpList;
            TempData.Keep("appInfo");
            return View("AzConfigurations", model);
        }
        [HttpPost]
        public IActionResult AzConfigurations(string resGrp, string AzLocation, string AzAppSvcPlan, string AzAppName, string AzContainerRegistry, string ContainerTag)
        {
            AppServiceConfiguration appSvcCfg = new AppServiceConfiguration();
            appSvcCfg.ResourceGrp = resGrp;
            appSvcCfg.location = AzLocation;
            appSvcCfg.appSvcPlan = AzAppSvcPlan;
            appSvcCfg.paaswebapp = AzAppName;
            appSvcCfg.AzCR = AzContainerRegistry;
            appSvcCfg.ContainerTag = ContainerTag;
            string json = (string)TempData["appInfo"];
            AppServiceConfiguration appSvcCfgTemp = JsonConvert.DeserializeObject<AppServiceConfiguration>(json);
            appSvcCfg.AppRuntime = appSvcCfgTemp.AppRuntime;
            appSvcCfg.DeploymentType = appSvcCfgTemp.DeploymentType;
            appSvcCfg.appdirectory = appSvcCfgTemp.appdirectory;
            appSvcCfg.zipFileName = appSvcCfgTemp.zipFileName;
            appSvcCfg.Container = appSvcCfgTemp.Container;
            appSvcCfg.GitUrl = appSvcCfgTemp.GitUrl;
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
           var path = _config.GetValue<string>("FileServer");
            using (var stream = new FileStream(Path.Combine(path, zipFolder.FileName), FileMode.Create))
           {
                await zipFolder.CopyToAsync(stream);
            }
            ViewBag.zipFile= zipFolder.FileName;
            TempData["zipFile"] = zipFolder.FileName;

            return RedirectToAction("AppInformation");
        }

        public ActionResult _BindSSLCertificate(int Id)
        {
            ViewBag.Id = Id;
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _BindSSLCertificate(IFormFile zipFolder)
        {
            if (zipFolder == null || zipFolder.Length == 0)
                return Content("file not selected");
            var path = _config.GetValue<string>("FileServer");
            using (var stream = new FileStream(Path.Combine(path, zipFolder.FileName), FileMode.Create))
            {
                await zipFolder.CopyToAsync(stream);
            }
            ViewBag.zipFile = zipFolder.FileName;
            TempData["zipFile"] = zipFolder.FileName;

            return RedirectToAction("AppInformation");
        }
        private async Task<string> GetDataAsync() {
            string resultContent = null;
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://localhost:55831/api/azrm");
                    var result = await client.GetAsync("http://localhost:55831/api/azrm");
                    resultContent = await result.Content.ReadAsStringAsync();
                }
                catch (Exception ex) {

                }
                return resultContent;
            }

        }
    }
}
