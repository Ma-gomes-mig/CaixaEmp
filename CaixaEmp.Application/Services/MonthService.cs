using AutoMapper;
using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Interfaces;
using CaixaEmp.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Services
{
    public class MonthService : IMonthService
    {
        private IMonthRepository _monthRepository;
        private readonly IMapper _mapper;
        public MonthService(IMonthRepository monthRepository, IMapper mapper)
        {
            _monthRepository = monthRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MonthDTO>> GetAllMonthAsync()
        {
            var month = await _monthRepository.GetAllMonthAsync();
            return _mapper.Map<IEnumerable<MonthDTO>>(month);
        }

        public async Task<MonthDTO> GetMonthByIdAsync(int id)
        {
            var month = await _monthRepository.GetMonthByIdAsync(id);
            return _mapper.Map<MonthDTO>(month);
        }
    }
}
