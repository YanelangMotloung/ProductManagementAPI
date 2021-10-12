using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementAPI.Models
{
    public class User
    {
        [Required(ErrorMessage = "Email is Required")]
        [Key]
        public string Email { get; set; }

        [Required(ErrorMessage = " Password is Required")]
        public string Password { get; set; }
    }
}
