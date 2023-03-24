using AutoMapper;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Services
{
    public class ExpenseCategory : IExpenseService
    {
        private IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;
        public ExpenseCategory(IExpenseRepository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }
    }
}
