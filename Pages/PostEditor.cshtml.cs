using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using ITMOWeb_Base.Classes;
using ITMOWeb_Base.Methods;
using ITMOWeb_Base.Context;
using ITMOWeb_Site.services;
using Microsoft.EntityFrameworkCore;

namespace ITMOWeb_Site.Pages
{
    public class PostEditorModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IPostServ _postServ;
        public string Text = string.Empty;
        public string AuthorName = string.Empty;
        public string Message { get; set; }

        [BindProperty]
        public string Title { get; set; }

        public PostEditorModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _postServ = new PostServ();
        }

        public void OnGet()
        {
            Message = String.Empty;
        }

        public void OnPost(string name, string title, string text)
        {
            User newUser = new User() { Name = name, Password = "***" };
            Post newPost = new Post() { Title = title, Body = text };
            _postServ.LoadPostOnDb(newUser, newPost);
            Message = "Чекни главную страницу";
        }
    }
}
