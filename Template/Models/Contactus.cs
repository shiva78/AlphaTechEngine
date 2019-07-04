using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Models
{
    public class Contactus
    {
        public string fullname { get; set; }
        public string emailaddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string phone { get; set; }
        public string message { get; set; }
    }

}
