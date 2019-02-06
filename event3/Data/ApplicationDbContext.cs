using System;
using System.Collections.Generic;
using System.Text;
using event3.Models;
using event3.ModelsContact;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using event3.ViewModels;

namespace event3.Data
{
    public class OrganizationDbContext : IdentityDbContext
    {
          // properties that we want to persist
          public  DbSet<Organization> Organization { get; set; }

        public OrganizationDbContext(DbContextOptions<OrganizationDbContext> options)
            : base(options)
        
        {
        }

        public DbSet<event3.ViewModels.AddNewOrganizationViewModel> AddNewOrganizationViewModel { get; set; }
    }
}
