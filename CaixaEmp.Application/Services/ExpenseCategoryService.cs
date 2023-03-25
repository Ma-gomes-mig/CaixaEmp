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

        //public async Task<IEnumerable<ExpenseCategoryDTO>> GetCategoryByExpense(int expenseId)
        //{
        //    var categoryEntiy = await _expenseCategoryRepository.GetCategoryByExpense(expenseId);
        //    return _mapper.Map<>
        //}

        public async Task<ExpenseCategoryDTO> GetCategoryByIdAsync(int? Id)
        {
            var categoryEntity = await _expenseCategoryRepository.GetCategoryByIdAsync(Id);
            return _mapper.Map<ExpenseCategoryDTO>(categoryEntity);
        }

        public async Task Create(ExpenseCategoryDTO expenseCategory)
        {
            var category = _mapper.Map<ExpenseCategory>(expenseCategory);
            await _expenseCategoryRepository.Create(category);
        }

        public async Task Update(ExpenseCategoryDTO expenseCategory)
        {
            var category = _mapper.Map<ExpenseCategory>(expenseCategory);
            await _expenseCategoryRepository.Update(category);
        }

        public async Task Delete(ExpenseCategoryDTO expenseCategory)
        {
            var category = _mapper.Map<ExpenseCategory>(expenseCategory);
            await _expenseCategoryRepository.Delete(category);
        }
    }
}
