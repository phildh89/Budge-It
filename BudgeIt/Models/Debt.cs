using System;
using System.Collections.Generic;

namespace BudgeIt.Models
{
    public partial class Debt
    {
        public int AccountId { get; set; }
        public int CustId { get; set; }
        public int TransactionId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
    }
}
