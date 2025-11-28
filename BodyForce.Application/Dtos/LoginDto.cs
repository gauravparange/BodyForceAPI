using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(6, ErrorMessage = "Username cannot exceed 6 characters.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
