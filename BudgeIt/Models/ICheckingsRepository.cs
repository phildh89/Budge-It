using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgeIt.Models
{
    public interface ICheckingsRepository
    {
        IQueryable<Checkings> Checkings { get; }
    }
}
