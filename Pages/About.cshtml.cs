using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoviePages.Pages {
    public class AboutModel : PageModel {
        public string Message { get; set; }

        public void OnGet () {
            Message = "Movie Hub is an app used to sell and rate your favorite movies";
        }
    }
}