using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgeIt.Models
{
    public class EFDebtRepository:IDebtRepository
    {
        private ApplicationDbContext context;
        public EFDebtRepository(ApplicationDbContext ctx) { context = ctx; }
        public IQueryable<Debt> Debt => context.Debt;
    }
}
