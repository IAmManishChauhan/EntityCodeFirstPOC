using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductName { get; set; }

        public ProductCategory ProductCategory { get; set; }
    }

}
