using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Interface
{
    public interface IWithdrawalRepository
    {
        Task<IEnumerable<Withdrawal>> GetAllWithdrawalAsync();
        Task<Withdrawal> GetWithdrawalById(int? id);
        Task<IEnumerable<Withdrawal>> GetWithdrawalByExpense(int expenseId);
        Task<IEnumerable<Withdrawal>> GetWithdrawalByEmplooyer(string emplooyerName);
        Task<IEnumerable<Withdrawal>> GetWithdrawalByPeriod(DateTime beginDate, DateTime endDate);
        Task<IEnumerable<Withdrawal>> GetWithdrawalByPriority(string priority);
        Task<IEnumerable<Withdrawal>> GetWithdrawalAproved(bool status);
        Task<IEnumerable<Withdrawal>> GetInclusionReproved(bool status);

        Task<Withdrawal> Create(Withdrawal withdrawal);
        Task<Withdrawal> Update(Withdrawal withdrawal);
        Task<Withdrawal> Delete(Withdrawal withdrawal);
    }
}
