using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgeIt.Models
{
    public class EFCheckingsRepository : ICheckingsRepository
    {
        private ApplicationDbContext context;
        public EFCheckingsRepository(ApplicationDbContext ctx) { context = ctx; }
        public IQueryable<Checkings> Checkings => context.Checkings;
    }
}
