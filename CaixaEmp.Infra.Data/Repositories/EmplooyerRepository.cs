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
    }
}
