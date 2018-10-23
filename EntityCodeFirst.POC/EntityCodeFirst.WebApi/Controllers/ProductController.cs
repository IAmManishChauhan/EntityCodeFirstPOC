using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityCodeFirst.Entities;
using EntityCodeFirst.BusinessLayer.Interfaces;
using EntityCodeFirst.BusinessLayer;

namespace EntityCodeFirst.WebApi.Controllers
{
    public class ProductController : ApiController
    {

        IProductCategoryRepository productCategoryRepository;
        public ProductController() {
            productCategoryRepository = new ProductCategoryRepository();
        }

        [HttpGet]
        public string getAll() {
            var d = productCategoryRepository.GetAll();
            return "";
        }
    }
}
