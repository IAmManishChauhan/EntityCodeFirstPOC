using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityCodeFirst.BusinessLayer.Interfaces;
using Entity_CodeFirst.DataLayer;

namespace EntityCodeFirst.BusinessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public PocPortalDb dbContext;
        public DbSet<T> dbSet;
 
        public Repository() {
            dbContext = new PocPortalDb();
            dbSet = dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public void Add(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            dbSet.Remove(entity);
            dbContext.SaveChanges();
        }

        public T FindById(int Id)
        {
            return dbSet.Find(Id);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            dbContext.SaveChanges();
        }
    }
}
