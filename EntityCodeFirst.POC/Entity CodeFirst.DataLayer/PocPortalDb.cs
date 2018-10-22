using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityCodeFirst.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Entity_CodeFirst.DataLayer
{
    public class PocPortalDb : DbContext
    {
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        public PocPortalDb()
        {
            Database.SetInitializer<PocPortalDb>(null); //disable auto db migration
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
