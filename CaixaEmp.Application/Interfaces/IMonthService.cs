using CaixaEmp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Interfaces
{
    public interface IMonthService
    {
        Task <IEnumerable<MonthDTO>> GetAllMonthAsync();
        Task<MonthDTO> GetMonthByIdAsync(int id);
    }
}
