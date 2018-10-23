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
        public HttpResponseMessage getAll() {

           var productCategorys = productCategoryRepository.GetAll();

            if (productCategorys ==  null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, productCategorys);
        }
    }
}
