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
    public class OwnerController : ApiController
    {
        [System.Web.Http.Route("api/owner/{ownerId}")]
        public CompanyOwner GetUserById(Guid ownerId)
        {
            return BLOwner.GetOwnerById(ownerId);
        }
    }


}
