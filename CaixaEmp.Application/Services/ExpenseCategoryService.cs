using AutoMapper;
using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interfaces;
using CaixaEmp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Services
{
    public class ExpenseCategoryService : IExpenseCategoryService
    {
        ApplicationDbContext _context;
        private IExpenseCategoryRepository _expenseCategoryRepository;
        private readonly IMapper _mapper;
        public ExpenseCategoryService(IExpenseCategoryRepository expenseRepository, IMapper mapper)
        {
            _expenseCategoryRepository = expenseRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ExpenseCategoryDTO>> GetAllCategoryAsync()
        {
            var categoryEntity = await _expenseCategoryRepository.GetAllCategoryAsync();
            return _mapper.Map<IEnumerable<ExpenseCategoryDTO>>(categoryEntity);
        }

        public async Task<IEnumerable<ExpenseCategoryDTO>> GetCategoryByExpense(int expenseId)
        {
            var categoryEntity = _mapper.Map<ExpenseCategory>(expenseId);
            await _context.Categories.Where(c => c.Id == expenseId).ToListAsync();
            return 
        }

        public async Task<ExpenseCategoryDTO> GetCategoryByIdAsync(int? Id)
        {
            var categoryEntity = await _expenseCategoryRepository.GetCategoryByIdAsync(Id);
            return _mapper.Map<ExpenseCategoryDTO>(categoryEntity);
        }

        public Task Create(ExpenseCategoryDTO expenseCategory)
        {
            throw new NotImplementedException();
        }

        public Task Update(ExpenseCategoryDTO expenseCategory)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ExpenseCategoryDTO expenseCategory)
        {
            throw new NotImplementedException();
        }
    }
}
