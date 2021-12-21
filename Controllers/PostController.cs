using Microsoft.AspNetCore.Mvc;
using ITMOWeb_Site.services;
using System.Collections.Generic;
using ITMOWeb_Base.Classes;

namespace ITMOWeb_Site.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PostController
    {
        private readonly IPostServ _postServ;
        public PostController(IPostServ postServ)
        {
            _postServ = postServ;
        }

        [HttpGet("DB")]
        public List<Post> OnGetDb()
        {
            return _postServ.GetPostsDB();
        }
    }
}
