using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Interfaces
{
    public interface IBalanceRepository
    {
        Task<IEnumerable<Balance>> GetAllBalanceAsync();
    }
}
