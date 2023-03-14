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

        public async Task<Inclusion> GetInclusionById(int? id)
        {
            return await _inclusionContext.Inclusions.FindAsync(id);
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

        public async Task<Inclusion> Create(Inclusion inclusion)
        {
            _inclusionContext.Add(inclusion);
            await _inclusionContext.SaveChangesAsync();
            return inclusion;
        }

        public async Task<Inclusion> Delete(Inclusion inclusion)
        {
            _inclusionContext.Remove(inclusion);
            await _inclusionContext.SaveChangesAsync();
            return inclusion;
        }

        public async Task<Inclusion> Update(Inclusion inclusion)
        {
            _inclusionContext.Update(inclusion);
            await _inclusionContext.SaveChangesAsync();
            return inclusion;
        }
    }
}
