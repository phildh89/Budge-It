using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BudgeIt.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [RegularExpression(".+\\@.+\\..+",                      //TODO: Change password validation.
        ErrorMessage = "Please enter a valid password")]
        public string Password { get; set; }

        //TODO: Add another section for re-enter password
    }
}
