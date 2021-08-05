using Blog.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.ClassRepository
{
    public class PostRepository : Repository<Post, long>, IPost
    {
        public PostRepository(DbContext context) : base(context)
        {

        }
    }
}
