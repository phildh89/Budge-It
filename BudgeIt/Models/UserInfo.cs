using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgeIt.Models
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            AccountInfo = new HashSet<AccountInfo>();
            Calculator = new HashSet<Calculator>();
            Checkings = new HashSet<Checkings>();
        }

        public int UserId { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[NotMapped]
        //[DisplayName("Confirm Password")]
        //[DataType(DataType.Password)]
        //[Compare("Password")]
        //public string ConfirmPassword { get; set; }

        public virtual ICollection<AccountInfo> AccountInfo { get; set; }
        public virtual ICollection<Calculator> Calculator { get; set; }
        public virtual ICollection<Checkings> Checkings { get; set; }
    }
}
