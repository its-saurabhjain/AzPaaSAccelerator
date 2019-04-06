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
        public async Task<ActionResult<IEnumerable<string>>> GetAzSubscriptions()
        {
            IEnumerable<string> res = await Utility.getSubscriptionList();

            return CreatedAtAction("GetAzSubscriptions", res);
        }
        
    }
}