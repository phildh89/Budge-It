using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgeIt.Models
{
    public interface IDebtRepository
    {
        IQueryable<Debt> Debt { get; }
    }
}
