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

        [System.Web.Http.Route("api/owner/update")]
        public bool PostUpdateOwner([FromBody] CompanyOwner owner)
        {
            return BLOwner.UpdateOwner(owner);
        }

        [System.Web.Http.Route("api/owner/mols/{ownerId}")]
        public List<CommonMol> GetAllMols(Guid ownerId)
        {
            return BLOwner.GetAllMols(ownerId);
        }

        [System.Web.Http.Route("api/owner/createmol")]
        public bool PostCreateMol([FromBody] CommonMol mol)
        {
            return BLOwner.CreateMol(mol);
        }

        [System.Web.Http.Route("api/owner/updatemol")]
        public bool PostUpdateMol([FromBody] CommonMol mol)
        {
            return BLOwner.UpdateMol(mol);
        }

        [System.Web.Http.Route("api/owner/deletemol")]
        public bool PostDeleteMol([FromBody] Guid molId)
        {
            return BLOwner.DeleteMol(molId);
        }

        [System.Web.Http.Route("api/owner/changeprimery")]
        public CommonMol PostChangePrimety([FromBody] List<Guid> molIds)
        {
            return BLOwner.ChangePrimary(molIds[0], molIds[1]);
        }
       
    }


}
