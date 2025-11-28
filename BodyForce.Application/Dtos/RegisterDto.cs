using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI
{
    public class RegisterDto
    {
        [Required(ErrorMessage ="First name is required.")]
        [StringLength(20,ErrorMessage = "First name cannot exceed 20 characters.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name can only contain letters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(20, ErrorMessage = "Last name cannot exceed 20 characters.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name can only contain letters.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        [MaxLength(10,ErrorMessage ="Number should not exceed 10 digits.")]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Date of birth is required.")]
        public DateTime? DOB { get; set; }
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*#?&]).{8,}$",
            ErrorMessage = "Password must be at least 8 characters long and include uppercase, lowercase, number, and special character.")]
        public string Password { get; set; }

    }
}
