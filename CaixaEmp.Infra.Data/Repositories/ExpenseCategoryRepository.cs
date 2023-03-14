using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interface;
using CaixaEmp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Infra.Data.Repositories
{
    public class ExpenseCategoryRepository : IExpenseCategoryRepository
    {
        ApplicationDbContext _expenseCategoryContext;
        public ExpenseCategoryRepository(ApplicationDbContext context)
        {
            _expenseCategoryContext = context;
        }

        public Task<IEnumerable<ExpenseCategory>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExpenseCategory>> GetCategoryByExpense(int expenseId)
        {
            throw new NotImplementedException();
        }

        public Task<ExpenseCategory> GetCategoryByIdAsync(int? Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ExpenseCategory> Create(ExpenseCategory expenseCategory)
        {
            _expenseCategoryContext.Add(expenseCategory);
            await _expenseCategoryContext.SaveChangesAsync();
            return expenseCategory;
        }

        public async Task<ExpenseCategory> Delete(ExpenseCategory expenseCategory)
        {
            _expenseCategoryContext.Remove(expenseCategory);
            await _expenseCategoryContext.SaveChangesAsync();
            return expenseCategory;
        }

        public async Task<ExpenseCategory> Update(ExpenseCategory expenseCategory)
        {
            _expenseCategoryContext.Update(expenseCategory);
            await _expenseCategoryContext.SaveChangesAsync();
            return expenseCategory;
        }
    }
}
