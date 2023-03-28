using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interfaces;
using CaixaEmp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
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
        

        public async Task<IEnumerable<Emplooyer>> GetAllEmplooyerAsync()
        {
            return await _emplooyerContext.Emplooyers.ToListAsync();
        }

        public async Task<Emplooyer> GetEmplooyerByIdAsync(int? id)
        {
            return await _emplooyerContext.Emplooyers.FindAsync(id);
        }

        public async Task<Emplooyer> GetEmplooyerByName(string name)
        {
            //return await _emplooyerContext.Emplooyers.FindAsync(name);
            return await _emplooyerContext.Emplooyers.Where(e => e.Name.Contains(name)).FirstAsync();
        }

        public async Task<Emplooyer> Create(Emplooyer emplooyer)
        {
            _emplooyerContext.Add(emplooyer);
            await _emplooyerContext.SaveChangesAsync();
            return emplooyer;
        }

        public async Task<Emplooyer> Delete(Emplooyer emplooyer)
        {
            _emplooyerContext.Remove(emplooyer);
            await _emplooyerContext.SaveChangesAsync();
            return emplooyer;
        }

        public async Task<Emplooyer> Update(Emplooyer emplooyer)
        {
            _emplooyerContext.Update(emplooyer);
            await _emplooyerContext.SaveChangesAsync();
            return emplooyer;
        }
    }
}
