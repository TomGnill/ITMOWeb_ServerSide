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
    public class PostModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int PageId { get;set; }
        private IPostServ _postServ;

        private List<Post> _posts;
        public Post selectedPost;

        public PostModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _postServ = new PostServ();
        }
        public void OnGet()
        {
        }
        public void OnGetById(int id)
        {
            _posts = _postServ.GetPostsDB();
            PageId = id;
            selectedPost = _posts[id];
        }
    }
}
