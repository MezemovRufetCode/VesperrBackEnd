using HWusingDbInProject.DAL;
using HWusingDbInProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Employees = _context.Employees.Include(x => x.Socials).ToList(),
                Categories = _context.Categories.Include(x => x.CardCategories).ThenInclude(x => x.Card).ToList(),
                Counts=_context.Counts.ToList(),
                Services=_context.Services.ToList(),
                Logos=_context.Logo.ToList(),
                MoreServices=_context.MoreServices.ToList(),
                Features=_context.Features.ToList(),
                Clients=_context.Clients.ToList(),
                Heroes=_context.Heroes.ToList(),
                AboutUs=_context.AboutUs.ToList(),
                Sliders=_context.Sliders.ToList(),
                BuyCards=_context.BuyCards.Include(x=>x.CardFeaturesBuyCards).ThenInclude(x=>x.CardFeature).ToList()
            };
            return View(homeVM);
        }
    }
}
