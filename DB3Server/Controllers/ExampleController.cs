//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web.Http;
//using System.Web.Mvc;
//using Newtonsoft.Json;

//namespace DB3Server.Controllers
//{
//    public class ExampleController : Controller
//    {
//        // GET api/channels 
//        [BasicAuthorizationFilter]
//        public List<RSChannel> Get()
//        {
//            return BLChannel.ListChannels();
//        }

//        // GET api/channels/id
//        [BasicAuthorizationFilter]
//        public RSChannel Get(int id)
//        {
//            return BLChannel.Get(id);
//        }

//        // POST api/channels 
//        [BasicAuthorizationFilter(Roles = "Administrator")]
//        public int Post([FromBody]RSChannel channel)
//        {
//            return BLChannel.Insert(channel.Name, channel.PrimeConnection, channel.SecondConnection, channel.ChannelType);
//        }

//        // PUT api/channels/{id}
//        [BasicAuthorizationFilter(Roles = "Administrator")]
//        public int Put(int id, [FromBody]RSChannel channel)
//        {
//            return BLChannel.Update(id, channel.Name, channel.PrimeConnection, channel.SecondConnection, channel.ChannelType);
//        }

//        // DELETE api/channels/id
//        [BasicAuthorizationFilter(Roles = "Administrator")]
//        public HttpResponseMessage Delete(int id)
//        {
//            BLChannel.Delete(id);

//            return new HttpResponseMessage(HttpStatusCode.OK);
//        }

//        // POST api/channels/test 
//        [System.Web.Mvc.Route("api/channels/test")]
//        [BasicAuthorizationFilter(Roles = "Administrator")]
//        public HttpResponseMessage PostChannelTest([FromBody]RSConnection connection)
//        {
//            BLChannel.TestConnections(connection);

//            return new HttpResponseMessage(HttpStatusCode.OK);
//        }
//    }
//}
