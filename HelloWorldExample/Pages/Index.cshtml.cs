using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldExample.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FirstName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = $"Hello world! Today it is {DateTime.Now.DayOfWeek}";
        }
    }
}
