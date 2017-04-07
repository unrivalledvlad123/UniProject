using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Common.Classes;
using DB3Server.BusinessLogic;

namespace DB3Server.Controllers
{
    public class UserController : ApiController
    {
        [System.Web.Http.Route("api/users/create")]
        public void PostCreateUser([FromBody] CommonUser user)
        {
            BLAuthenticationProvider.CreateUser(user);
        }

        [System.Web.Http.Route("api/users/login/{username}/{password}")]
        public CommonUser GetLogin(string username, string password)
        {
            return BLAuthenticationProvider.Login(username, password);
        }

    }

}
