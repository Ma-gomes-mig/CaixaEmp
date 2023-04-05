using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Interfaces
{
    public interface IExpenseCategoryRepository
    {
        Task<IEnumerable<ExpenseCategory>> GetAllCategoryAsync();
        //Task<IEnumerable<ExpenseCategory>> GetCategoryByExpense(int expenseId);
        //Task<ExpenseCategory> GetCategoryByIdAsync(int? Id);
        Task<ExpenseCategory> Create(ExpenseCategory expenseCategory);
        Task<ExpenseCategory> Update(ExpenseCategory expenseCategory);
        Task<ExpenseCategory> Delete(ExpenseCategory expenseCategory);
    }
}
