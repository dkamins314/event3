using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace event3.ViewModels
{
    public class AddNewOrganizationViewModel
    {
        [Key]
        [Required, Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name of Organization")]
        public string NameofOrganization { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address of Organization")]
        public string StreetAddressOfOrganization { get; set; }
        [Required(ErrorMessage = "Zip Code is required")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        public string State { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }


    }
}
