using Blog.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class Repository<T, K> : IRepository<T, K> where T : class
    {
        DbContext _context;
        DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Remove(T item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
        public T FindById(K id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<T> Get(Func<T, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).AsQueryable();
        }
    }
}
