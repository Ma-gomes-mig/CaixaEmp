using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interface;
using CaixaEmp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Infra.Data.Repositories
{
    public class WithdrawalRepository : IWithdrawalRepository
    {
        ApplicationDbContext _withdrawalContext;
        public WithdrawalRepository(ApplicationDbContext context)
        {
            _withdrawalContext = context;
        }        

        public async Task<IEnumerable<Withdrawal>> GetAllWithdrawalAsync()
        {
            return await _withdrawalContext.Withdrawals.ToListAsync();
        }        

        public async Task<IEnumerable<Withdrawal>> GetWithdrawalByEmplooyer(int emplooyerId)
        {
            var query = from i in _withdrawalContext.Withdrawals
                        where i.EmplooyerId == emplooyerId
                        select i;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Withdrawal>> GetWithdrawalByExpense(int expenseId)
        {
            var query = from i in _withdrawalContext.Withdrawals
                        where i.ExpenseId == expenseId
                        select i;
            foreach(Withdrawal item in query)
            {
                Console.WriteLine(item);
            }
            return await query.ToListAsync();
        }

        public async Task<Withdrawal> GetWithdrawalById(int? id)
        {
            return await _withdrawalContext.Withdrawals.FindAsync(id);
        }

        public async Task<IEnumerable<Withdrawal>> GetWithdrawalByPeriod(DateTime beginDate, DateTime endDate)
        {
            var query = from i in _withdrawalContext.Withdrawals
                        where i.DateInclusion > beginDate && i.DateInclusion < endDate
                        select i;
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Withdrawal>> GetWithdrawalByPriority(string priority)
        {
            var query = from i in _withdrawalContext.Withdrawals
                        where i.Priority == priority
                        select i;
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Withdrawal>> GetInclusionReproved(bool status)
        {
            var query = from i in _withdrawalContext.Withdrawals
                        where i.Status == false
                        select i;
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
            return await query.ToListAsync();
        }

        public Task<IEnumerable<Withdrawal>> GetWithdrawalAproved(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<Withdrawal> Create(Withdrawal withdrawal)
        {
            _withdrawalContext.Add(withdrawal);
            await _withdrawalContext.SaveChangesAsync();
            return withdrawal;
        }

        public async Task<Withdrawal> Delete(Withdrawal withdrawal)
        {
            _withdrawalContext.Add(withdrawal);
            await _withdrawalContext.SaveChangesAsync();
            return withdrawal;
        }
        public async Task<Withdrawal> Update(Withdrawal withdrawal)
        {
            _withdrawalContext.Add(withdrawal);
            await _withdrawalContext.SaveChangesAsync();
            return withdrawal;
        }
    }
}
