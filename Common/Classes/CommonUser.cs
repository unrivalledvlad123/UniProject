using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
     public class CommonUser
    {
        public string Username { get; set; }
        public Guid OwnerId { get; set; }
        public string Password { get; set; }
        public string AssignedTo { get; set; }
        public DateTime RegisteredAt { get; set; }
        public int Role { get; set; }
        public Guid UserId { get; set; }
    }
}
