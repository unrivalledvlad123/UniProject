using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using Common.Classes;

namespace DB3Server.BusinessLogic
{
    class BLContract
    {
        internal static Guid CreateContract(CommonContract contract)
        {
            try
            {
                DatabaseEntities entities = new DatabaseEntities();

                Partner p = new Partner();
                p.CompanyName = contract.CompanyName;
                p.Address = contract.Address;
                p.Email = contract.Email;
                p.Phone = contract.Phone;
                p.VATNumber = contract.VatNumber;
                p.Bulstat = contract.Bulstat;
                Guid tempGuid = Guid.NewGuid();
                p.PartnerId = tempGuid;

                entities.Partners.Add(p);
                entities.SaveChanges();
                return tempGuid;
            }
            catch (Exception e)
            {
                return Guid.Empty;
            }
           
        }
        internal static List<CommonContract> GetAllPartners(String search)
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<Partner> allDbPartners = new List<Partner>();
            if (search.IsEmpty())
            {
                allDbPartners = entities.Partners.ToList();
            }
            else
            {
                allDbPartners = entities.Partners.Where(p => p.CompanyName.Contains(search)).ToList();
            }
           
            List<CommonContract> allPartners = new List<CommonContract>();
            foreach (var dbPartner in allDbPartners)
            {
                CommonContract contract = new CommonContract();
                contract.PartnerId = dbPartner.PartnerId;
                contract.Address = dbPartner.Address;
                contract.Bulstat = dbPartner.Bulstat;
                contract.CompanyName = dbPartner.CompanyName;
                contract.Email = dbPartner.Email;
                contract.Phone = dbPartner.Phone;
                contract.VatNumber = dbPartner.VATNumber;
                allPartners.Add(contract);
            }
            return allPartners;
        }

        internal static CommonContract GetPartnersById(String search)
        {
            DatabaseEntities entities = new DatabaseEntities();
            Partner dbPartner = entities.Partners.Find(new Guid(search));
          
            if (dbPartner != null)
            {
                CommonContract contract = new CommonContract();
                contract.PartnerId = dbPartner.PartnerId;
                contract.Address = dbPartner.Address;
                contract.Bulstat = dbPartner.Bulstat;
                contract.CompanyName = dbPartner.CompanyName;
                contract.Email = dbPartner.Email;
                contract.Phone = dbPartner.Phone;
                contract.VatNumber = dbPartner.VATNumber;
                return contract;
            }
            return null;
        }
        internal static bool UpdateContract(CommonContract oldPartner)
        {
            DatabaseEntities entities = new DatabaseEntities();
            Partner dbPartner = entities.Partners.FirstOrDefault(p => p.PartnerId == oldPartner.PartnerId);
            if (dbPartner == null) return false;
            dbPartner.CompanyName = oldPartner.CompanyName;
            dbPartner.Address = oldPartner.Address;
            dbPartner.Email = oldPartner.Email;
            dbPartner.Phone = oldPartner.Phone;
            dbPartner.VATNumber = oldPartner.VatNumber;
            dbPartner.Bulstat = oldPartner.Bulstat;

            entities.Partners.Attach(dbPartner);
            var entry = entities.Entry(dbPartner);
            entry.Property(e => e.CompanyName).IsModified = true;
            entry.Property(e => e.Address).IsModified = true;
            entry.Property(e => e.Email).IsModified = true;
            entry.Property(e => e.Phone).IsModified = true;
            entry.Property(e => e.VATNumber).IsModified = true;
            entry.Property(e => e.Bulstat).IsModified = true;
            entities.SaveChanges();
            return true;
        }

       
    }
}
