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
    public class EmplooyerRepository : IEmplooyerRepository
    {
        ApplicationDbContext _emplooyerContext;
        public EmplooyerRepository(ApplicationDbContext context)
        {
            _emplooyerContext = context;
        }

        public Task<Emplooyer> Create(Emplooyer emplooyer)
        {
            throw new NotImplementedException();
        }

        public Task<Emplooyer> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Emplooyer>> GetAllEmplooyerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Emplooyer>> GetEmplooyerByExpense(int expenseId)
        {
            throw new NotImplementedException();
        }

        public Task<Emplooyer> GetEmplooyerByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Emplooyer> GetEmplooyerByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Emplooyer> Update(Emplooyer emplooyer)
        {
            throw new NotImplementedException();
        }
    }
}
