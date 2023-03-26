using CaixaEmp.Application.DTOs;
using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Interfaces
{
    public interface IWithdrawalService
    {
        Task<IEnumerable<WithdrawalDTO>> GetAllWithdrawalAsync();
        Task<WithdrawalDTO> GetWithdrawalById(int? id);
        Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByExpense(int expenseId);
        Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByEmplooyer(int emplooyerId);
        Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByPeriod(DateTime beginDate, DateTime endDate);
        Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByPriority(string priority);
        Task<IEnumerable<WithdrawalDTO>> GetWithdrawalAproved(bool status);
        Task<IEnumerable<WithdrawalDTO>> GetWithdrawalReproved(bool status);

        Task Create(WithdrawalDTO withdrawal);
        Task Update(WithdrawalDTO withdrawal);
        Task Delete(WithdrawalDTO withdrawal);
    }
}
