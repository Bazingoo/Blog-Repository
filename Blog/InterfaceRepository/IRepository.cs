using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public interface IRepository<T, K> where T : class
    {
        void Add(T item);
        T FindById(K id);
        void Update(T item);
        void Remove(T item);
        IQueryable<T> Get(Func<T, bool> predicate);
    }
}
