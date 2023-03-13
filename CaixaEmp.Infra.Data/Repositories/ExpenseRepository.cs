﻿using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interface;
using CaixaEmp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Expense>> GetAllExpenseAsync()
        {
            return await _expenseContext.Expenses.ToListAsync();
        }

        public async Task<Expense> GetExpenseById(int? id)
        {
            return await _expenseContext.Expenses.FindAsync(id);
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

        public async Task<Expense> Delete(Expense expense)
        {
            _expenseContext.Remove(expense);
            await _expenseContext.SaveChangesAsync();
            return expense;
        }

        public async Task<Expense> Update(Expense expense)
        {
            _expenseContext.Update(expense);
            await _expenseContext.SaveChangesAsync();
            return expense;
        }
    }
}
