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
    }
}
