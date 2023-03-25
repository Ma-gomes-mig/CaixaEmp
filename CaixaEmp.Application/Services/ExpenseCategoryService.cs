using AutoMapper;
using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Services
{
    public class ExpenseCategoryService : IExpenseCategoryService
    {
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

        public Task<IEnumerable<ExpenseCategoryDTO>> GetCategoryByExpense(int expenseId)
        {
            throw new NotImplementedException();
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
