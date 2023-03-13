﻿using CaixaEmp.Domain.Entities;
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
        

        public async Task<IEnumerable<Emplooyer>> GetAllEmplooyerAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Emplooyer>> GetEmplooyerByExpense(int expenseId)
        {
            throw new NotImplementedException();
        }

        public async Task<Emplooyer> GetEmplooyerByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<Emplooyer> GetEmplooyerByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Emplooyer> Create(Emplooyer emplooyer)
        {
            _emplooyerContext.Add(emplooyer);
            await _emplooyerContext.SaveChangesAsync();
            return emplooyer;
        }

        public async Task<Emplooyer> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Emplooyer> Update(Emplooyer emplooyer)
        {
            throw new NotImplementedException();
        }
    }
}
