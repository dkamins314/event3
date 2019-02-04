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

        [Required]
        [Display(Name = "Name of Organization")]
        public string NameofOrganization { get; set; }
        [Required]
        [Display(Name = "Address of Organization")]
        public string StreetAddressOfOrganization { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string City { get; set; }

        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }


    }
}
