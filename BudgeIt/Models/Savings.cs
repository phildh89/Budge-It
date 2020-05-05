using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BudgeIt.Models
{
    public partial class Savings
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
    }
}
