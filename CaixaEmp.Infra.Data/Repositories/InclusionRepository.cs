using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interface;
using CaixaEmp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Infra.Data.Repositories
{
    public class InclusionRepository : IInclusionRepository
    {
        ApplicationDbContext _inclusionContext;
        public InclusionRepository(ApplicationDbContext context)
        {
            _inclusionContext = context;
        }       

        public Task<IEnumerable<Inclusion>> GetAllInclusionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inclusion>> GetInclusionAproved(Inclusion status)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inclusion>> GetInclusionByEmplooyer(int emplooyerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inclusion>> GetInclusionByExpense(int expenseId)
        {
            throw new NotImplementedException();
        }

        public Task<Inclusion> GetInclusionById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inclusion>> GetInclusionByPeriod(DateTime beginDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inclusion>> GetInclusionByPriority(Inclusion priority)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inclusion>> GetInclusionReproved(Inclusion status)
        {
            throw new NotImplementedException();
        }

        public Task<Inclusion> Create(Inclusion inclusion)
        {
            throw new NotImplementedException();
        }

        public Task<Inclusion> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Inclusion> Update(Inclusion inclusion)
        {
            throw new NotImplementedException();
        }
    }
}
