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
    public class ExpenseRepository : IExpenseRepository
    {
        ApplicationDbContext _expenseContext;
        public ExpenseRepository(ApplicationDbContext context)
        {
            _expenseContext = context;
        }        

        public Task<IEnumerable<Expense>> GetAllExpenseAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Expense> GetExpenseById(int? id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Expense>> GetExpenseByEmplooyer(int emplooyerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Expense>> GetExpenseByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }      

        public async Task<Expense> Create(Expense expense)
        {
            _expenseContext.Add(expense);
            await _expenseContext.SaveChangesAsync();
            return expense;
        }

        public Task<Expense> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Expense> Update(Expense expense)
        {
            throw new NotImplementedException();
        }
    }
}
