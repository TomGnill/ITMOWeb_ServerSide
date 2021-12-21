using System.Collections.Generic;
using System.Linq;
using ITMOWeb_Base.Classes;
using ITMOWeb_Site.services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ITMOWeb_Site.Pages
{
    public class AuthorModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        public int UserId { get; set; } = 999999;
        private IPostServ _postServ;

        public List<Post> Posts;

        public List<Post> UserPost { get; set; }
        public User selectedUser; 

        public AuthorModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _postServ = new PostServ();
        }
        public void OnGet()
        {
        }
        public void OnGetById(int id)
        {
            Posts = _postServ.GetPostsDB();
            UserId = id;
            selectedUser = Posts[id].Author;
            UserPost = selectedUser.Posts.ToList();
        }

        public void OnGetByUserId(int id)
        {
            Posts = _postServ.GetPostsDB();
            UserId = id;
            foreach (var post in Posts.Where(post => post.Author.Id == id))
            {
                selectedUser = post.Author;
            }
            UserPost = selectedUser.Posts.ToList();
        }
    }
}
