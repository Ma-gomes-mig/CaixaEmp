using AutoMapper;
using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Services
{
    public class BalanceService : IBalanceService
    {
        private IBalanceRepository _balanceRepository;
        private readonly IMapper _mapper;

        public BalanceService(IMapper mapper, IBalanceRepository balanceRepository)
        {
            _balanceRepository = balanceRepository;
            _mapper = mapper;
        }

        //public async Task<IEnumerable<BalanceDTO>> GetAllBalanceAsync()
        //{
        //    var balanceEntity = await _balanceRepository.GetAllBalanceAsync();
        //    return _mapper.Map<IEnumerable<BalanceDTO>>(balanceEntity);
        //}
    }
}
