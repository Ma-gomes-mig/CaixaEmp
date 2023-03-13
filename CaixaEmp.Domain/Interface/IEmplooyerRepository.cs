using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Interface
{
    public interface IEmplooyerRepository
    {
        Task<IEnumerable<Emplooyer>> GetAllEmplooyerAsync();
        Task<Emplooyer> GetEmplooyerByIdAsync(int? id);
        Task<Emplooyer> GetEmplooyerByName(string name);
        Task<IEnumerable<Emplooyer>> GetEmplooyerByExpense(int expenseId);

        Task<Emplooyer> Create(Emplooyer emplooyer);
        Task<Emplooyer> Update(Emplooyer emplooyer);
        Task<Emplooyer> Delete(Emplooyer emplooyer);
    }    
}
