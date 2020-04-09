using System;
using System.Collections.Generic;

namespace BudgeIt.Models
{
    public partial class Calculator
    {
        public int Id { get; set; }
        public int CustId { get; set; }
        public bool IsSavingsCalc { get; set; }
        public decimal Amount { get; set; }
        public decimal Apr { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public int? PayOffTime { get; set; }

        public virtual UserInfo Cust { get; set; }
    }
}
