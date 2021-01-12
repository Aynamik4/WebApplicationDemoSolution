using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldExample.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public AddressInfo Address { get; set; }

        public string DataFromForm { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            DataFromForm = $"Name: {Address.Name}. Street: {Address.Street}";
        }
    }

    public class AddressInfo
    {
        public string Name { get; set; }
        public string Street { get; set; }
    }
}