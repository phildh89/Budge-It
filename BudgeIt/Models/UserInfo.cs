using System;
using System.Collections.Generic;

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

        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<AccountInfo> AccountInfo { get; set; }
        public virtual ICollection<Calculator> Calculator { get; set; }
        public virtual ICollection<Checkings> Checkings { get; set; }
    }
}
