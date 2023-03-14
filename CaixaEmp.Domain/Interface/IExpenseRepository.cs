using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Interface
{
    public interface IExpenseRepository
    {
        Task<IEnumerable<Expense>> GetAllExpenseAsync();
        Task<Expense> GetExpenseById(int? id);
        Task<IEnumerable<Expense>> GetExpenseByEmplooyer(int emplooyerId);
        Task<Expense> GetExpenseCategory(int? id);

        Task<Expense> Create(Expense expense);
        Task<Expense> Update(Expense expense);
        Task<Expense> Delete(Expense expense);
    }
}
