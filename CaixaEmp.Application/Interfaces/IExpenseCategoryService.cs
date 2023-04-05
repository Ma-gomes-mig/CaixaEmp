using CaixaEmp.Application.DTOs;
using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Interfaces
{
    public interface IExpenseCategoryService
    {
        //Task<IEnumerable<ExpenseCategoryDTO>> GetAllCategoryAsync();
        //Task<IEnumerable<ExpenseCategoryDTO>> GetCategoryByExpense(int expenseId);
        //Task<ExpenseCategoryDTO> GetCategoryByIdAsync(int? Id);
        Task Create(ExpenseCategoryDTO expenseCategory);
        Task Update(ExpenseCategoryDTO expenseCategory);
        Task Delete(ExpenseCategoryDTO expenseCategory);
    }
}
