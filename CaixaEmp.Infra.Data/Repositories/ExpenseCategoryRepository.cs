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
    public class ExpenseCategoryRepository : IExpenseCategoryRepository
    {
        ApplicationDbContext _expenseCategoryContext;
        public ExpenseCategoryRepository(ApplicationDbContext context)
        {
            _expenseCategoryContext = context;
        }

        public async Task<IEnumerable<ExpenseCategory>> GetAllCategoryAsync()
        {
            return await _expenseCategoryContext.Categories.ToListAsync();
        }

        public async Task<IEnumerable<ExpenseCategory>> GetCategoryByExpense(int expenseId)
        {
            return await _expenseCategoryContext.Categories.Where(c => c.Id == expenseId).ToListAsync();
        }

        public async Task<ExpenseCategory> GetCategoryByIdAsync(int? Id)
        {
            return await _expenseCategoryContext.Categories.FindAsync(Id);
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
