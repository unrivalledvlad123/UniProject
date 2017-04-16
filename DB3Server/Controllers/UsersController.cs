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
        public bool PostCreateUser([FromBody] CommonUser user)
        {
          return  BLAuthenticationProvider.CreateUser(user);
        }


        [System.Web.Http.Route("api/users/edit")]
        public bool PostEditUser([FromBody] CommonUser user)
        {
            return BLAuthenticationProvider.UpdateUser(user);
        }

        [System.Web.Http.Route("api/users/login/{username}/{password}")]
        public CommonUser GetLogin(string username, string password)
        {
            return BLAuthenticationProvider.Login(username, password);
        }

        [System.Web.Http.Route("api/users/allusers/{ownerId}")]
        public List<CommonUser> GetAllUsers(Guid ownerId)
        {
            return BLAuthenticationProvider.GetAllUsers(ownerId);
        }

        [System.Web.Http.Route("api/users/delete")]
        public bool PostDeleteUser([FromBody] Guid userId)
        {
            return BLAuthenticationProvider.DeleteUser(userId);
        }


    }

}
