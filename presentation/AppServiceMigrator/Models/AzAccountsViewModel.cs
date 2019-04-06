using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationAcceleratorApp.Models
{
    public class AzAccountsViewModel
    {
        public string Subscription { get; set; }
        [Display(Name = "ResourceGroups")]
        public List<string> ResourceGroupList { get; set; }
    }
}
