using System;
using System.Collections.Generic;

namespace BudgeIt.Models
{
    public partial class AccountInfo
    {
        public int CustId { get; set; }
        public int AccountId { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public decimal? Apr { get; set; }
        public decimal? InitialBal { get; set; }

        public virtual UserInfo Cust { get; set; }
    }
}
