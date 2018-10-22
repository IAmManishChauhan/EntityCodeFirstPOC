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
        private readonly PocPortalDb dbContext;
        private DbSet<T> dbSet;
        string errorMessage = string.Empty;

        public Repository() {
            this.dbContext = new PocPortalDb();
            dbSet = dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList<T>();
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
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            dbContext.SaveChanges();
        }
    }
}
