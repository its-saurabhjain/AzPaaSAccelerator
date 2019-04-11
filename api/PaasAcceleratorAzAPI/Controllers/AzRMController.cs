using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PaasAcceleratorAzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AzRMController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAzResourceGroups()
        {
            IEnumerable<string> subscriptions = await Utility.getSubscriptionList();
            string e = subscriptions.FirstOrDefault();
            string subscription = JObject.Parse(e)["value"][0]["subscriptionId"].ToString();
            string resourceGrps = await Utility.getResourceGroupList(subscription);
            List<string> resGrpList = new List<string>();
            JObject jo = JObject.Parse(resourceGrps);
            string jsonArray = JObject.Parse(resourceGrps)["value"].ToString();
            JArray a = JArray.Parse(jsonArray);

            foreach (JObject o in a.Children<JObject>())
            {
                foreach (JProperty p in o.Properties())
                {
                    string name = p.Name;
                    var value = p.Value;
                    if (name == "name") {
                        resGrpList.Add(value.ToString());
                    }
                    
                }
            }
            return CreatedAtAction("GetAzResourceGroups", resGrpList);
        }
    }
}