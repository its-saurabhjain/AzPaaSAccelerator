using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationAcceleratorApp.Models
{
    public class AppServiceConfiguration
    {
        public Guid ID { get; set;}
        public string Subscription { get; set; }
        public string ResourceGrp { get; set; }
        public string location { get; set; }
        public string appSvcPlan { get; set; }
        public string paaswebapp { get; set; }
        public string appdirectory { get; set; }
        public string zipDirectory { get; set; }
        public string DeploymentType { get; set; }
        public string AppRuntime { get; set; }
        public string Container { get; set; }
    }
}
