using Blog.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.ClassRepository
{
    public class TagRepository : Repository<Category, long>, ITag
    {
        public TagRepository(DbContext context) : base(context)
        {

        }
    }
}
