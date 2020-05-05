using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgeIt.Models;

namespace BudgeIt.Models.ViewModels
{
    public class ListViewModel
    {
        public IEnumerable<Checkings> Checkings { get; set; }
        public IEnumerable<Debt> Debt { get; set; }
        public IEnumerable<Savings> Savings { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
