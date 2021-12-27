using HWusingDbInProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.ViewModels
{
    public class HomeVM
    {
        public List<Employee> Employees { get; set; }
        public List<Category> Categories { get; set; }
        public List<Count> Counts { get; set; }
        public List<Service> Services { get; set; }
        public List<Logo> Logos { get; set; }
        public List<MoreService> MoreServices { get; set; }
    }
}
