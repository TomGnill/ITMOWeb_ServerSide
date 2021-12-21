using ITMOWeb_Base.Classes;
using System.Collections.Generic;
namespace ITMOWeb_Site.services
{
    public interface IPostServ
    {
        List<Post> GetPostsDB();
        void LoadPostOnDb(User user, Post post);
    }
}
