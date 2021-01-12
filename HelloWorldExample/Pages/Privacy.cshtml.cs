using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorldExample.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public List<string> fileNames = new List<string>(16);

        public void OnGet()
        {
            foreach (var item in Directory.EnumerateFiles("wwwroot/Images"))
                fileNames.Add(new FileInfo(item).Name);
        }
    }
}
