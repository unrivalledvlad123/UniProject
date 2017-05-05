using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Common.Classes;
using Common.Classes.DTOs;
using Common.Classes.ReportClasses;
using DB3Server.BusinessLogic;

namespace DB3Server.Controllers
{
    public class ReportController : ApiController
    {
        [System.Web.Http.Route("api/reports/generate")]
        public List<ReportBuySell> PostGeneratereport([FromBody] ReportDTO dto)
        {
            return BLReports.GenerateReport(dto);
        }


    }
}
