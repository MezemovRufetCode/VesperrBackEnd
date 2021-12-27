using HWusingDbInProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CardCategory> CardCategories { get; set; }
        public DbSet<Count> Counts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Logo> Logo { get; set; }
        public DbSet<MoreService> MoreServices { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
