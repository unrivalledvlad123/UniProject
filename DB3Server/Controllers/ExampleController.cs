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

            //[BasicAuthorizationFilter(Roles = "Administrator")]
            //[System.Web.Http.HttpPut]
            //[System.Web.Http.Route("nodes")]
            //public List<OpcNode> GetAllnodes([FromBody]dynamic data /* OpcServer server, string node = ""*/)
            //{
            //    OpcConnection opc = new OpcConnection();
            //    OpcServer server = JsonConvert.DeserializeObject<OpcServer>(data.server.ToString());
            //    string nodeId = data.nodeId.Value as string; // JsonConvert.DeserializeObject<string>(data.nodeId.ToString());

            //    var nodes = opc.BrowseNodes(server.UriString, nodeId);
            //    return nodes;
            //}

            //[BasicAuthorizationFilter(Roles = "Administrator")]
            //[System.Web.Http.HttpGet]
            //[System.Web.Http.Route("resubscribe")]
            //public bool Resubscribe()
            //{
            //    BLOPC.ManualResuscribeAll();
            //    return true;
            //}
        }
    }
}
