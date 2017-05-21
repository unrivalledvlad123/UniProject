using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Common.Classes;
using DB3Server.BusinessLogic;

namespace DB3Server.Controllers
{
    public class ContractController : ApiController
    {
        [System.Web.Http.Route("api/contract/create")]
        public Guid PostCreatePartner([FromBody]CommonContract contract)
        {
            return BLContract.CreateContract(contract);
        }

        [System.Web.Http.Route("api/contract/update")]
        public bool PostUpdatePartner([FromBody]CommonContract contract)
        {
            return BLContract.UpdateContract(contract);
        }

        [System.Web.Http.Route("api/contract/list/{search?}")]
        public List<CommonContract> GetAllPartners(String search = "")
        {
            return BLContract.GetAllPartners(search);
        }

        [System.Web.Http.Route("api/contract/get/{search}")]
        public CommonContract GetPartnersById(String search)
        {
            return BLContract.GetPartnersById(search);
        }
    }
}
