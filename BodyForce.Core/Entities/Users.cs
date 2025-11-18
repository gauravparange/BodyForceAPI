using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI
{
    public class Users 
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? FullName { get; set; }
        public string? PasswordHash { get; set; }
        public string? Phone { get; set; }
        public int RoleId { get; set; }
        public string? Address { get; set; }
        public DateTime? DOB { get; set; }  


    }
}
