using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldExample.Pages
{
    public class AboutModel : PageModel
    {
        public StaffCategory staff = new StaffCategory();
        
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        public void OnGet()
        {
            switch (Id)
            {
                case "chefen":
                    staff.ImageUrl = "IMG_5093.jpg";
                    staff.Header = Id.ToUpper();
                    staff.Info = "The Boss";
                    break;
                case "personalen":
                    staff.ImageUrl = "IMG_5126.jpg";
                    staff.Header = Id.ToUpper();
                    staff.Info = "The Staff";
                    break;
                case "kunder":
                    staff.ImageUrl = "IMG_5270.jpg";
                    staff.Header = Id.ToUpper();
                    staff.Info = "The Customer";
                    break;
                default:
                    //staff.ImageUrl = "IMG_5093.jpg";
                    //staff.Header = Id.ToUpper();
                    //staff.Info = "The Boss";
                    break;
            }
        }
    }

    public class StaffCategory
    {
        public string ImageUrl { get; set; } // Header Info
        public string Header { get; set; }
        public string Info { get; set; }
    }
}
