using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityCodeFirst.Entities;

namespace EntityCodeFirst.BusinessLayer.Interfaces
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        void InsertProduct(Product product);
    }
}
