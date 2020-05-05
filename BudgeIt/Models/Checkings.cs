using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BudgeIt.Models
{
    public partial class Checkings
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        [Key]
        public int TransactionId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        public virtual UserInfo User { get; set; }
    }
}
