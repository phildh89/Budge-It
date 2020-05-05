using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BudgeIt.Models
{
    public partial class AccountInfo
    {
        public int UserId { get; set; }
        [Key]
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public string AccountDescription { get; set; }
        public decimal? Apr { get; set; }
        public decimal? InitialBal { get; set; }

        public virtual UserInfo User { get; set; }
    }
}
