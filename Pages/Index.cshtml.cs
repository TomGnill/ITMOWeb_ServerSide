using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMOWeb_Base.Classes;
using ITMOWeb_Site.services;
using Microsoft.AspNetCore.Http;

namespace ITMOWeb_Site.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Post> Posts { get; set; }
        private IPostServ _postServ;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _postServ = new PostServ();
            OnGet();
        }

        public void OnGet()
        {
        }
    }
}
