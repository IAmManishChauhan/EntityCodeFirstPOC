using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;


namespace EntityCodeFirst.WebApi.Response
{
    public class ResponseMetadata
    {
        public string Version { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public object Result { get; set; }
        public DateTime Timestamp { get; set; }
        public long? Size { get; set; }
    }
}