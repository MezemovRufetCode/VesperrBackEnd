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
    }
}
