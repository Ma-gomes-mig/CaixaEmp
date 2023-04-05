using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interfaces;
using CaixaEmp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Infra.Data.Repositories
{
    public class MonthRepository : IMonthRepository
    {
        ApplicationDbContext _monthContext;
        public MonthRepository(ApplicationDbContext context)
        {
            _monthContext = context;
        }

        public async Task<IEnumerable<Month>> GetAllMonthAsync()
        {
            return await _monthContext.Months.ToListAsync();
        }
                

        public async Task<Month> GetMothByIdAsync(int? id)
        {
            return await _monthContext.Months.FindAsync(id);
        }
    }
}
