using System;
using System.Collections.Generic;
using System.Linq;
using ITMOWeb_Base.Classes;
using ITMOWeb_Site.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ITMOWeb_Site.Pages
{
    public class AuthModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private IPostServ _postServ;
        public string Name = string.Empty;
        public string Password = string.Empty;
        public string Message { get; set; }


        public AuthModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _postServ = new PostServ();
        }

        public void OnGet()
        {
            Message = String.Empty;
        }
        public void OnPost(string name, string password)
        {
            List<User> users = _postServ.GetPostsDB().Select(post => post.Author).ToList();
            var user = users.FirstOrDefault(a => a.Name == name && a.Password == password);
            if (user != null)
            {
                Message = "Успешно";
                LoginedUser.Id = user.Id;
                LoginedUser.Name = name;
            }
            else
            {
                Message = "Попробуй снова";
            }
        }
    }
}
