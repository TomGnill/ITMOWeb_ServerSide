using ITMOWeb_Base.Classes;
using ITMOWeb_Base.Methods;
using System;
using ITMOWeb_Base.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ITMOWeb_Site.services
{
    public class PostServ : IPostServ
    {
        public PostServ()
        { }
        public List<Post> GetPostsDB()
        {
            return LogicMethods.GetPosts();
        }
        public void LoadPostOnDb(User user, Post post)
        {
            SiteContext db = new SiteContext();
            db.Users.Add(user);
            post.Author = user;
            db.Posts.Add(post);
            db.SaveChanges();
        }
    }
}
