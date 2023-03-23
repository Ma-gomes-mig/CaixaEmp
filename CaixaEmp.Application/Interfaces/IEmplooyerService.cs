﻿using CaixaEmp.Application.DTOs;
using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Interfaces
{
    public interface IEmplooyerService
    {
        Task<IEnumerable<EmplooyerDTO>> GetAllEmplooyerAsync();
        Task<EmplooyerDTO> GetEmplooyerByIdAsync(int? id);
        Task<EmplooyerDTO> GetEmplooyerByName(string name);
        Task<EmplooyerDTO> Create(Emplooyer emplooyer);
        Task<EmplooyerDTO> Update(Emplooyer emplooyer);
        Task<EmplooyerDTO> Delete(Emplooyer emplooyer);
    }
}
