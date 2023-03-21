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
    public class BalanceRespository : IBalanceRepository
    {
        ApplicationDbContext _applicationDbContext;
        public BalanceRespository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Balance>> GetAllBalanceAsync()
        {
            return await _applicationDbContext.Balances.ToListAsync();
        }
    }
}
