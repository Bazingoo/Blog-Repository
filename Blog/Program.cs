using Blog.ClassRepository;
using Blog.Repository;
using System;

namespace Blog
{
    class Program
    {
        static EFContext context = new EFContext();
        static void Main(string[] args)
        {
            IPost postservice = new PostRepository(context);
           
            Service postserviceadd = new Service(postservice);

            postserviceadd.AddPost(new ProducAddModel
            {
                Title = "Заголовок №1",
                ShortDescription = "Короткий опим №1",
                Description = "Максимально повний опис №1",
                Meta = "Стиль №1",
                UrlSlug = "www.blog/1",
            });
            postserviceadd.AddPost(new ProducAddModel
            {
                Title = "Заголовок №2",
                ShortDescription = "Короткий опим №2",
                Description = "Максимально повний опис №2",
                Meta = "Стиль №1",
                UrlSlug = "www.blog/2",
            });
        }
    }
}
