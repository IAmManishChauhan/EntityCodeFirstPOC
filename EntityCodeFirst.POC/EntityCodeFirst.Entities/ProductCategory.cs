using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int CategoryName { get; set; }

        public IList<Product> Products { get; set; }
    }
}
