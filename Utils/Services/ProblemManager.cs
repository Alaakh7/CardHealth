using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Utils.Services
{
    public class ProblemManager
    {
        public static HttpStatusCodeResult Display401(string message)
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, message);
        }
    }
}
