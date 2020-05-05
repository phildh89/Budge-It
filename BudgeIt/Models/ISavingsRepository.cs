using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgeIt.Models
{
    public interface ISavingsRepository
    {
        IQueryable<Savings> Savings { get; }
    }
}
