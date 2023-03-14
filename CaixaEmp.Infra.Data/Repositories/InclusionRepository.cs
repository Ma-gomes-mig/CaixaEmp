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
    }
}
