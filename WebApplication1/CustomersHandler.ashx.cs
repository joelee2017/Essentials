using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    /// <summary>
    /// CustomersHandler 的摘要描述
    /// </summary>
    public class CustomersHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            Thread.Sleep(600);
            string CustomerID = context.Request["CustomerID"];

            NorthwindEntities db = new NorthwindEntities();
            bool bExists = db.Customers.Any(c => c.CustomerID == CustomerID);

            context.Response.ContentType = "text/plain";
            context.Response.Write(bExists? "true":"false"); 
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}