using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityCodeFirst.Entities;
using EntityCodeFirst.BusinessLayer.Interfaces;

namespace EntityCodeFirst.WebApi.Controllers
{
    public class ProductController : ApiController
    {
       
        public ProductController() {
           
        }

        [HttpGet]
        public string getAll() {
            return "test";
        }
    }
}
