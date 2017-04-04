using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using DB3Server.BusinessLogic;
using Newtonsoft.Json;

namespace DB3Server.Controllers
{
    public class ExampleController : Controller
    {
        public class OPCController : ApiController
        {
           [System.Web.Http.HttpGet]
            [System.Web.Http.Route("api/test")]
            public string GetAllServers()
           {

               string test = BLTest.Test();
                return test;
            }

        }
    }
}
