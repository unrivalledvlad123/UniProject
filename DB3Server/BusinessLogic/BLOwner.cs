using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Classes;

namespace DB3Server.BusinessLogic
{
    public class BLOwner
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
                owner.Bulstat = dbOwner.Bulstat;
                owner.VatNumber = dbOwner.VATNumber;
            }
            return owner;
        }

        internal static bool UpdateOwner(CompanyOwner oldOwner)
        {
            DatabaseEntities entities = new DatabaseEntities();
            Owner dbOwner = entities.Owners.FirstOrDefault(p => p.OwnerId == oldOwner.OwnerId);
            if (dbOwner == null) return false;
            dbOwner.CompanyName = oldOwner.CompanyName;
            dbOwner.Address = oldOwner.Address;
            dbOwner.Email = oldOwner.Email;
            dbOwner.Phone = oldOwner.Phone;
            dbOwner.VATNumber = oldOwner.VatNumber;
            dbOwner.Bulstat = oldOwner.Bulstat;

            entities.Owners.Attach(dbOwner);
            var entry = entities.Entry(dbOwner);
            entry.Property(e => e.CompanyName).IsModified = true;
            entry.Property(e => e.Address).IsModified = true;
            entry.Property(e => e.Email).IsModified = true;
            entry.Property(e => e.Phone).IsModified = true;
            entry.Property(e => e.VATNumber).IsModified = true;
            entry.Property(e => e.Bulstat).IsModified = true;
            entities.SaveChanges();
            return true;
        }

        internal static bool CreateMol(CommonMol newMol)
        {
            DatabaseEntities entities = new DatabaseEntities();
            MOL mol = new MOL();
            mol.OwnerId = newMol.OwnerId;
            mol.Address = newMol.Address;
            mol.Email = newMol.Email;
            mol.FirstName = newMol.FirstName;
            mol.LastName = newMol.LastName;
            mol.Phone = newMol.LastName;
            mol.MolId = Guid.NewGuid();
            entities.MOLs.Add(mol);
            entities.SaveChanges();
            return true;
        }

        internal static List<CommonMol> GetAllMols(Guid ownerId)
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<MOL> allDbMols = entities.MOLs.Where(p => p.OwnerId == ownerId).ToList();
            List<CommonMol> allMols = new List<CommonMol>();
            foreach (var dbMol in allDbMols)
            {
                CommonMol mol = new CommonMol();
                mol.OwnerId = dbMol.OwnerId;
                mol.Address = dbMol.Address;
                mol.Email = dbMol.Email;
                mol.FirstName = dbMol.FirstName;
                mol.LastName = dbMol.LastName;
                mol.MolId = dbMol.MolId;
                mol.Phone = dbMol.Phone;
                allMols.Add(mol);
            }
            return allMols;
        }

        internal static bool UpdateMol(CommonMol oldMol)
        {
            DatabaseEntities entities = new DatabaseEntities();
            MOL dbMol = entities.MOLs.FirstOrDefault(p => p.MolId == oldMol.MolId);
            if (dbMol == null) return false;
            dbMol.FirstName = oldMol.FirstName;
            dbMol.Address = oldMol.Address;
            dbMol.Email = oldMol.Email;
            dbMol.Phone = oldMol.Phone;
            dbMol.LastName = oldMol.LastName;

            entities.MOLs.Attach(dbMol);
            var entry = entities.Entry(dbMol);
            entry.Property(e => e.FirstName).IsModified = true;
            entry.Property(e => e.Address).IsModified = true;
            entry.Property(e => e.Email).IsModified = true;
            entry.Property(e => e.Phone).IsModified = true;
            entry.Property(e => e.LastName).IsModified = true;
            entities.SaveChanges();
            return true;
        }

        internal static bool DeleteMol(Guid molId)
        {
            DatabaseEntities entities = new DatabaseEntities();
            MOL mol = entities.MOLs.FirstOrDefault(p => p.MolId == molId);
            if (mol != null)
            {
                entities.MOLs.Remove(mol);
                entities.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
