//using gymWebApplication.utilites;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Web.Http.Controllers;
//using System.Web.Http.Filters;

//namespace gymWebApplication.filters
//{
//    public  class Logging: Attribute, IActionFilter
//    {
//        public bool AllowMultiple => false;

//        public Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
//        {
//            Logger logger = new Logger();
//            logger.Log("executing action");
//            var result = continuation();

//            logger.Log("after execution");
//            return result;

//        }

     

//    }
//}