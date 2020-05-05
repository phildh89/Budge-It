using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgeIt.Models
{
    public class EFSavingsRepository:ISavingsRepository
    {
        private ApplicationDbContext context;
        public EFSavingsRepository(ApplicationDbContext ctx) { context = ctx; }
        public IQueryable<Savings> Savings => context.Savings;
    }
}
