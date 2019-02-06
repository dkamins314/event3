using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using event3.Models;
using event3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace event3.Controllers
{
    public class OrganizationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddNewOrganizationViewModel addNewOrganizationViewModel = new AddNewOrganizationViewModel();

             return View(addNewOrganizationViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddNewOrganizationViewModel addNewOrganizationViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Organization newOrganization = new Organization

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

                    return Redirect("/(Index)");

                }
            }

            catch

            {
                return View("/Add");
            }

            {
                Console.WriteLine("Please complete form" );
                

            
            }

            return Redirect("/Home");
        }
    }
}
          