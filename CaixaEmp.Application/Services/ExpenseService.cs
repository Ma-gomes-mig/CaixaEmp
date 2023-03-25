using AutoMapper;
using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interfaces;
using CaixaEmp.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Services
{
    public class ExpenseService : IExpenseService
    {
        private IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;
        public ExpenseService( IExpenseRepository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ExpenseDTO>> GetAllExpenseAsync()
        {
            var expense = await _expenseRepository.GetAllExpenseAsync();
            return _mapper.Map<IEnumerable<ExpenseDTO>>(expense);
        }

        public Task<ExpenseDTO> GetExpenseById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExpenseDTO>> GetExpenseByEmplooyer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ExpenseDTO> GetExpenseCategory(int? id)
        {
            var entity = await _expenseRepository.GetExpenseCategory(id);
            return _mapper.Map<ExpenseDTO>(entity);
        }

        public async Task Create(ExpenseDTO expense)
        {
            var expenseEntity = _mapper.Map<Expense>(expense);
            await _expenseRepository.Create(expenseEntity);
        }

        public Task Update(ExpenseDTO expense)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ExpenseDTO expense)
        {
            throw new NotImplementedException();
        }
    }
}
