using CaixaEmp.Application.DTOs;
using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Interfaces
{
    public interface IExpenseService
    {
        Task<IEnumerable<ExpenseDTO>> GetAllExpenseAsync();
        Task<ExpenseDTO> GetExpenseById(int? id);
        Task<IEnumerable<ExpenseDTO>> GetExpenseByEmplooyer(int id);
        Task<ExpenseDTO> GetExpenseCategory(int? id);
        Task<ExpenseDTO> GetExpenseEmplooyer(int? id);

        Task Create(ExpenseDTO expense);
        Task Update(ExpenseDTO expense);
        Task Delete(ExpenseDTO expense);
    }
}
