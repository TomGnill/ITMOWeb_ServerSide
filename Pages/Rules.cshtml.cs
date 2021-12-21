using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMOWeb_Site.Pages
{
    public class RulesModel : PageModel
    {
        private readonly ILogger<RulesModel> _logger;

        public RulesModel(ILogger<RulesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
