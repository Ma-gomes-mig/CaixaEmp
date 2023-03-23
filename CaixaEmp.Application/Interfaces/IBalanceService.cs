using CaixaEmp.Application.DTOs;
using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Interfaces
{
    public interface IBalanceService
    {
        Task<IEnumerable<BalanceDTO>> GetAllBalanceAsync();
    }
}
