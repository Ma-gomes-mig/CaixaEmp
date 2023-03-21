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
<<<<<<< HEAD
        ApplicationDbContext _applicationDbContext;
        public BalanceRespository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
=======
        ApplicationDbContext _balanceContext;
        public BalanceRespository(ApplicationDbContext context)
        {
            _balanceContext = context;
>>>>>>> 49446cfa523fdfd4389817c38a44b7aa2e177797
        }

        public async Task<IEnumerable<Balance>> GetAllBalanceAsync()
        {
<<<<<<< HEAD
            return await _applicationDbContext.Balances.ToListAsync();
=======
            return await _balanceContext.Balances.ToListAsync();
>>>>>>> 49446cfa523fdfd4389817c38a44b7aa2e177797
        }
    }
}
