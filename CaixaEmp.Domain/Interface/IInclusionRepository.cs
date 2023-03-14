using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Interface
{
    public interface IInclusionRepository
    {
        Task<IEnumerable<Inclusion>> GetAllInclusionAsync();
        Task<Inclusion> GetInclusionById(int? id);
        Task<IEnumerable<Inclusion>> GetInclusionByExpense(int expenseId);
        Task<IEnumerable<Inclusion>> GetInclusionByEmplooyer(int emplooyerId);
        Task<IEnumerable<Inclusion>> GetInclusionByPeriod(DateTime beginDate, DateTime endDate);
        Task<IEnumerable<Inclusion>> GetInclusionByPriority(string priority);
        Task<IEnumerable<Inclusion>> GetInclusionAproved(bool status);
        Task<IEnumerable<Inclusion>> GetInclusionReproved(bool status);

        Task<Inclusion> Create(Inclusion inclusion);
        Task<Inclusion> Update(Inclusion inclusion);
        Task<Inclusion> Delete(Inclusion inclusion);
    }
}
