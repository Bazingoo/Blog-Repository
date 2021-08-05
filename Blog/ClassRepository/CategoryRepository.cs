using Blog.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class CategoryRepository : Repository<Category, long>, ICategory
    {
        public CategoryRepository(DbContext context) : base(context)
        {

        }
    }
}
