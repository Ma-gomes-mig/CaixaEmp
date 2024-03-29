﻿using CaixaEmp.Domain.Entities;
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
    public class InclusionRepository : IInclusionRepository
    {
        ApplicationDbContext _inclusionContext;
        public InclusionRepository(ApplicationDbContext context)
        {
            _inclusionContext = context;
        }       

        //public async Task<IEnumerable<Inclusion>> GetAllInclusionAsync()
        //{
        //    return await _inclusionContext.Inclusions.ToListAsync();
        //}        

        //public async Task<IEnumerable<Inclusion>> GetInclusionByEmplooyer(int emplooyerId)
        //{
        //    return await _inclusionContext.Inclusions.Where(i => i.Id == emplooyerId).ToListAsync();
        //}

        //public async Task<IEnumerable<Inclusion>> GetInclusionByExpense(int expenseId)
        //{
        //    return await _inclusionContext.Inclusions.Where(i => i.Id == expenseId).ToListAsync();
        //}

        //public async Task<Inclusion> GetInclusionById(int? id)
        //{
        //    return await _inclusionContext.Inclusions.FindAsync(id);
        //}

        //public async Task<IEnumerable<Inclusion>> GetInclusionByPeriod(DateTime beginDate, DateTime endDate)
        //{
        //    var query = from i in _inclusionContext.Inclusions
        //                where i.DateInclusion > beginDate && i.DateInclusion < endDate
        //                select i;
        //    foreach (var i in query)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    return await query.ToListAsync();
        //}

        //public async Task<IEnumerable<Inclusion>> GetInclusionByPriority(string priority)
        //{
        //    return await _inclusionContext.Inclusions.Where(i=>i.Priority == priority).ToListAsync();
        //}

        //public async Task<IEnumerable<Inclusion>> GetInclusionAproved(bool status)
        //{
        //    var query = from i in _inclusionContext.Inclusions
        //                where i.Status == true
        //                select i;
        //    foreach(var item in query)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    return await query.ToListAsync();
        //}

        //public async Task<IEnumerable<Inclusion>> GetInclusionReproved(bool status)
        //{
        //    var query = from i in _inclusionContext.Inclusions
        //                where i.Status != true
        //                select i;
        //    foreach(var item in query)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    return await query.ToListAsync();
        //}

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
