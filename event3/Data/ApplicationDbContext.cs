using System;
using System.Collections.Generic;
using System.Text;
using event3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using event3.ViewModels;

namespace event3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
          // properties that we want to persist
          public  DbSet<addNewOrganizationViewModel> Organization { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        
        {
        }

        public DbSet<event3.ViewModels.AddNewOrganizationViewModel> AddNewOrganizationViewModel { get; set; }
    }
}
