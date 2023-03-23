using CaixaEmp.Application.DTOs;
using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Interfaces
{
    public interface IInclusionService
    {
        Task<IEnumerable<InclusionDTO>> GetAllInclusionAsync();
        Task<InclusionDTO> GetInclusionById(int? id);
        Task<IEnumerable<InclusionDTO>> GetInclusionByExpense(int expenseId);
        Task<IEnumerable<InclusionDTO>> GetInclusionByEmplooyer(int emplooyerId);
        Task<IEnumerable<InclusionDTO>> GetInclusionByPeriod(DateTime beginDate, DateTime endDate);
        Task<IEnumerable<InclusionDTO>> GetInclusionByPriority(string priority);
        Task<IEnumerable<InclusionDTO>> GetInclusionAproved(bool status);
        Task<IEnumerable<InclusionDTO>> GetInclusionReproved(bool status);

        Task Create(InclusionDTO inclusion);
        Task Update(InclusionDTO inclusion);
        Task Delete(InclusionDTO inclusion);
    }
}
