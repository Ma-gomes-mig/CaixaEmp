using AutoMapper;
using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Services
{
    public class EmplooyerService : IEmplooyerService
    {
        private IEmplooyerRepository _emplooyerRepository;
        private readonly IMapper _mapper;
        public EmplooyerService(IEmplooyerRepository emplooyerRepository, IMapper mapper)
        {
            _emplooyerRepository = emplooyerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmplooyerDTO>> GetAllEmplooyerAsync()
        {
            var emplooyerEntity = await _emplooyerRepository.GetAllEmplooyerAsync();
            return _mapper.Map<IEnumerable<EmplooyerDTO>>(emplooyerEntity);
        }

        public async Task<EmplooyerDTO> GetEmplooyerByIdAsync(int? id)
        {
            var emplooyerEntity = await _emplooyerRepository.GetEmplooyerByIdAsync(id);
            return _mapper.Map<EmplooyerDTO>(emplooyerEntity);
        }

        public async Task<EmplooyerDTO> GetEmplooyerByName(string name)
        {
            var emplooyerEntity = await _emplooyerRepository.GetEmplooyerByName(name);
            return _mapper.Map<EmplooyerDTO>(emplooyerEntity);
        }

        public async Task Create(EmplooyerDTO emplooyerDto)
        {
            var emplooyerEntity = _mapper.Map<Emplooyer>(emplooyerDto);
            await _emplooyerRepository.Create(emplooyerEntity);
        }

        public async Task Update(EmplooyerDTO emplooyerDto)
        {
            var emplooyerEntity = _mapper.Map<Emplooyer>(emplooyerDto);
            await _emplooyerRepository.Update(emplooyerEntity);
        }

        public async Task Delete(EmplooyerDTO emplooyerDto)
        {
            var emplooyerEntity = _mapper.Map<Emplooyer>(emplooyerDto);
            await _emplooyerRepository.Delete(emplooyerEntity);
        }
    }
}
