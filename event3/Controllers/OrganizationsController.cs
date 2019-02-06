using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using event3.Data;
using event3.Models;
using event3.ModelsContact;
using event3.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace event3.Controllers
{
    public class OrganizationsController : Controller
    {

        private OrganizationDbContext context;

        public OrganizationsController(OrganizationDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            var organizations = context.Organization.ToList();
            return View(organizations);
        }

        public IActionResult Add()
        {
            AddNewOrganizationViewModel addOrganization = new AddNewOrganizationViewModel();

             return View(addOrganization);
        }

        [HttpPost]
        public IActionResult Add(AddNewOrganizationViewModel addNewOrganizationViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Organization addOrganization = new Organization

                    {
                        ContactName = addNewOrganizationViewModel.ContactName,
                        NameofOrganization = addNewOrganizationViewModel.NameofOrganization,
                        StreetAddressOfOrganization = addNewOrganizationViewModel.StreetAddressOfOrganization,
                        ZipCode = addNewOrganizationViewModel.ZipCode,
                        City = addNewOrganizationViewModel.City,
                        State = addNewOrganizationViewModel.State,
                        Country = addNewOrganizationViewModel.Country,
                        Phone = addNewOrganizationViewModel.Phone
                    };

                    return Redirect("/Home");

                }
            }

            catch

            {
                return View("/Add");
            }

           // {
           //     Console.WriteLine("Please complete form" );
                
          //  }

            return Redirect("/Home");
        }
    }
}
          