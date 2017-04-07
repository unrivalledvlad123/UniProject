using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Classes;

namespace DB3Server.BusinessLogic
{
   public  class BLOwner
    {
        internal static CompanyOwner GetOwnerById(Guid ownerId)
        {
            CompanyOwner owner = new CompanyOwner();
            DatabaseEntities entities = new DatabaseEntities();
            Owner dbOwner = entities.Owners.FirstOrDefault(p => p.OwnerId == ownerId);
            if (dbOwner != null)
            {
                owner.OwnerId = dbOwner.OwnerId;
                owner.Address = dbOwner.Address;
                owner.CompanyName = dbOwner.CompanyName;
                owner.Email = dbOwner.Email;
                owner.Phone = dbOwner.Phone;
            }

            return owner;
        }

    }
}
