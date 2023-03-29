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

        public async Task<ExpenseDTO> GetExpenseById(int? id)
        {
            var expense = await _expenseRepository.GetExpenseById(id);
            return _mapper.Map<ExpenseDTO>(expense);
        }

        public async Task<IEnumerable<ExpenseDTO>> GetExpenseByEmplooyer(int id)
        {
            var expense = await _expenseRepository.GetExpenseByEmplooyer(id);
            return _mapper.Map<IEnumerable<ExpenseDTO>>(expense);
        }
        public async Task<ExpenseDTO> GetExpenseEmplooyer(int? id)
        {
            var expense = await _expenseRepository.GetExpenseEmplooyer(id);
            return _mapper.Map<ExpenseDTO>(expense);
        }
        

        public async Task<ExpenseDTO> GetExpenseCategory(int? id)
        {
            var expense = await _expenseRepository.GetExpenseCategory(id);
            return _mapper.Map<ExpenseDTO>(expense);
        }

        public async Task Create(ExpenseDTO expense)
        {
            var expenseEntity = _mapper.Map<Expense>(expense);
            await _expenseRepository.Create(expenseEntity);
        }

        public async Task Update(ExpenseDTO expense)
        {
            var expenseEntity = _mapper.Map<Expense>(expense);
            await _expenseRepository.Update(expenseEntity);
        }

        public async Task Delete(ExpenseDTO expense)
        {
            var expenseEntity = _mapper.Map<Expense>(expense);
            await _expenseRepository.Delete(expenseEntity);
        }

        
    }
}
