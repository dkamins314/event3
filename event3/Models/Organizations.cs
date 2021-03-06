﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace event3.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string NameofOrganization { get; set; }
        public string StreetAddressOfOrganization { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
