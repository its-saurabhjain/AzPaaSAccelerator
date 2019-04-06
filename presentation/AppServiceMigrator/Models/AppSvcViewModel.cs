using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationAcceleratorApp.Models
{
    public class AppSvcViewModel
    {
        public AzAccountsViewModel accounts {get; set;}
        public AppServiceConfiguration configuration { get; set; }

    }
}
