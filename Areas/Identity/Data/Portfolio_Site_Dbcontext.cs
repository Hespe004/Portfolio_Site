using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio_Site.Areas.Identity.Data;
using Portfolio_Site.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Portfolio_Site.Data
{
    public class _Portfolio_Site_Dbcontext : IdentityDbContext<_Portfolio_Site_User>
    {
        public _Portfolio_Site_Dbcontext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Categorie> Categorie { get; set; }

        public DbSet<Port_Eigenaar> Port_Eigenaar { get; set; }

        public DbSet<Programeertaal> Programeertaal { get; set; }
        public DbSet<Hobby> Hobbys { get; set; }
        public DbSet<MiddelbareSchool> MiddelbareSchools {get;set;}
        public DbSet<HogereSchool> HogereSchools {get;set;}

    }
}
