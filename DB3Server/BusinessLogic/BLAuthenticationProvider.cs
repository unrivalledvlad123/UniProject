using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Classes;

namespace DB3Server.BusinessLogic
{
    class BLAuthenticationProvider
    {
        #region // < ====== Event Methods ====== > //
        internal static CommonUser Login(string username, string password)
        {
            CommonUser user = new CommonUser();
            DatabaseEntities entities = new DatabaseEntities();
            User dbUser = entities.Users.FirstOrDefault(p => p.Username == username);
            if (dbUser == null)
            {
                return null;
            }
            string encodedPassword = EncodePassword(password + dbUser.PasswordSalt);
            if (dbUser.Password == encodedPassword)
            {
                user.Password = dbUser.Password;
                user.AssignedTo = dbUser.AssignedTo;
                user.Role = dbUser.Role;
                user.Username = dbUser.Username;
                user.OwnerId = dbUser.OwnerId;
                user.RegisteredAt = dbUser.RegisteredAt;
                user.UserId = dbUser.UserId;
                user.IsRestrictedUser = dbUser.IsRestrictedUser ?? true;
               

                return user;
            }
            return null;
        }

        internal static List<CommonUser> GetAllUsers(Guid ownerId)
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<CommonUser> users = new List<CommonUser>();
            List<User> dbUsers = entities.Users.Where(p => p.OwnerId == ownerId).ToList();
            foreach (User dbUser in dbUsers)
            {
                CommonUser user = new CommonUser();
                user.OwnerId = dbUser.OwnerId;
                user.AssignedTo = dbUser.AssignedTo;
                user.RegisteredAt = dbUser.RegisteredAt;
                user.Role = dbUser.Role;
                user.UserId = dbUser.UserId;
                user.Username = dbUser.Username;
                Enums.UserRoles role = (Enums.UserRoles)dbUser.Role;
                user.RoleString = role.ToString();
                user.IsRestrictedUser = dbUser.IsRestrictedUser ?? true;
                users.Add(user);
            }
            return users;
        }

        internal static bool DeleteUser(Guid userId)
        {
            DatabaseEntities entities = new DatabaseEntities();
            User user = entities.Users.FirstOrDefault(p => p.UserId == userId);
            if (user != null)
            {
                entities.Users.Remove(user);
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        internal static bool CreateUser(CommonUser user)
        {
            DatabaseEntities entities = new DatabaseEntities();
            User check = entities.Users.FirstOrDefault(p => p.Username == user.Username);
            if (check != null)
            {
                return false;
            }
            User newUser = new User();
            string salt = GenerateSalt();

            newUser.Username = user.Username;
            newUser.OwnerId = user.OwnerId;
            newUser.PasswordSalt = salt;
            newUser.Password = EncodePassword(user.Password + salt);
            newUser.RegisteredAt = DateTime.UtcNow;
            newUser.AssignedTo = user.AssignedTo;
            newUser.Role = user.Role;
            newUser.UserId = Guid.NewGuid();
            newUser.IsRestrictedUser = user.IsRestrictedUser;
            entities.Users.Add(newUser);
            entities.SaveChanges();
            return true;
        }

        internal static bool UpdateUser(CommonUser oldUser)
        {
            DatabaseEntities entities = new DatabaseEntities();
            User user = entities.Users.FirstOrDefault(p => p.UserId == oldUser.UserId);
            if (user == null) return false;
            user.Role = oldUser.Role;
            user.AssignedTo = oldUser.AssignedTo;
            user.IsRestrictedUser = oldUser.IsRestrictedUser;
            if (!string.IsNullOrEmpty(oldUser.Password))
            {
                string newSalt = GenerateSalt();
                user.PasswordSalt = newSalt;
                user.Password = EncodePassword(oldUser.Password + newSalt);
            }

            entities.Users.Attach(user);
            var entry = entities.Entry(user);
            entry.Property(e => e.Role).IsModified = true;
            entry.Property(e => e.AssignedTo).IsModified = true;
            entry.Property(e => e.Password).IsModified = true;
            entry.Property(e => e.PasswordSalt).IsModified = true;
            entry.Property(e => e.IsRestrictedUser).IsModified = true;
            entities.SaveChanges();
            return true;
        }

        
        #endregion

        #region // <===== Util methods ======> //

        private static string EncodePassword(string password)
        {
            var provider = new SHA256CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
        }

        private static string GenerateSalt()
        {
            Random rnd = new Random();
            int saltLenght = rnd.Next(10, 20);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789qwertyuiopasdfghjklzxcvbnm";
            return new string(Enumerable.Repeat(chars, saltLenght)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        #endregion
        

    }
}
