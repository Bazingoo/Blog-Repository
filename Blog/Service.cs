using Blog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class ProducAddModel
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
    }
   
    public class Service
    {
        private readonly IPost _postservice;
        public Service (IPost postservice)
        {
            _postservice = postservice;
        }
        public void AddPost(ProducAddModel model)
        {
            var post = new Post();
            post.Title = model.Title;
            post.ShortDescription = model.ShortDescription;
            post.Description = model.Description;
            post.Meta = model.Meta;
            post.UrlSlug = model.UrlSlug;
            _postservice.Add(post);

        }

    }
}
