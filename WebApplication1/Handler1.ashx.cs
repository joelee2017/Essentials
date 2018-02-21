using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string Name = context.Request["Name"];
            string Age = context.Request["Age"];
            Thread.Sleep(2000);
            context.Response.Write($"{Name},{Age}");
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