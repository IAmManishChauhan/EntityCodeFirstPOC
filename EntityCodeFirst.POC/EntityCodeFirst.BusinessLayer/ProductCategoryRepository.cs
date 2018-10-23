using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityCodeFirst.BusinessLayer.Interfaces;
using Entity_CodeFirst.DataLayer;
using EntityCodeFirst.Entities;

namespace EntityCodeFirst.BusinessLayer
{
    public class ProductCategoryRepository : Repository<ProductCategory>,IProductCategoryRepository
    {
        public ProductCategoryRepository() {

        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
