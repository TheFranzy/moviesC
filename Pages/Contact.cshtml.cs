using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoviePages.Pages
{
    public class ContactModel : PageModel
    {
        public string Name { get; set; }
        public string Email {get; set; }
        public string Phone {get; set;}
        public void OnGet()
        {
            Name = "Galen Housego";
            Email = "galen.housego@gmail.com";
            Phone = "504 235 1973";
        }
    }
}
