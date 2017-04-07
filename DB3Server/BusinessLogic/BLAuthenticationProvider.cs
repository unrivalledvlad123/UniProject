using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

                return user;
            }
            return null;
        }

        internal static List<User> GetAllUsers(Guid ownerId)
        {
            DatabaseEntities entities = new DatabaseEntities();
            return entities.Users.Where(p => p.OwnerId == ownerId).ToList();
        }

        internal static void DeleteUser(Guid userId)
        {
            DatabaseEntities entities = new DatabaseEntities();
            User user = entities.Users.FirstOrDefault(p => p.UserId == userId);
            if (user != null) entities.Users.Remove(user);
            entities.SaveChanges();
        }

        internal static void CreateUser(CommonUser user)
        {
            DatabaseEntities entities = new DatabaseEntities();
            
            User check = entities.Users.FirstOrDefault(p => p.Username == user.Username);
            if (check != null)
            {
                throw new AuthenticationException(Common.DataHolder.GetString("username_already_exist"));
            }
            User newUser = new User();
            string salt = GenerateSalt();

            newUser.Username = user.Username;
           // newUser.OwnerId = ownerId;
            newUser.OwnerId =Guid.Parse("14A4C2B8-4571-4ABC-A8BD-CE78625FBF1E");
            newUser.PasswordSalt = salt;
            newUser.Password = EncodePassword(user.Password + salt);
            newUser.RegisteredAt = DateTime.UtcNow;
            newUser.AssignedTo = user.AssignedTo;
            newUser.Role = user.Role;
            newUser.UserId = Guid.NewGuid();
            entities.Users.Add(newUser);
            entities.SaveChanges();
        }

        internal static void UpdateUser(Guid userId, int userRole, string assignedTo)
        {
            DatabaseEntities entities = new DatabaseEntities();

            User user = entities.Users.FirstOrDefault(p => p.UserId == userId);
            if (user == null) throw new Exception("user_not_found");
            user.Role = userRole;
            user.AssignedTo = assignedTo;

            entities.Users.Attach(user);
            var entry = entities.Entry(user);
            entry.Property(e => e.Role).IsModified = true;
            entry.Property(e => e.AssignedTo).IsModified = true;
            entities.SaveChanges();
        }

        internal static void ChangePassword(Guid userId, string oldPassword, string newPassword)
        {
            DatabaseEntities entities = new DatabaseEntities();
            User user = entities.Users.FirstOrDefault(p => p.UserId == userId);
            if (user == null) throw new AuthenticationException(Common.DataHolder.GetString("invalid_username_or_password"));
            if (user.Password == EncodePassword(oldPassword + user.PasswordSalt))
            {
                string newSalt = GenerateSalt();
                string newPasswordGenerated = EncodePassword(newPassword + newSalt);
                user.Password = newPasswordGenerated;
                user.PasswordSalt = newSalt;
                entities.SaveChanges();
            }
            else
            {
                throw new AuthenticationException(Common.DataHolder.GetString("password_mismatch"));
            }
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
