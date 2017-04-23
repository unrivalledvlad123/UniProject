using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
   public class CommonContract
    {
        public Guid PartnerId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Bulstat { get; set; }
        public string VatNumber { get; set; }
    }
}

