using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI
{
    public class Users 
    {
        [Key]
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? FullName { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public string? Phone { get; set; }
        public int RoleId { get; set; }
        public string? Address { get; set; }
        public DateTime? DOB { get; set; }  


    }
}
