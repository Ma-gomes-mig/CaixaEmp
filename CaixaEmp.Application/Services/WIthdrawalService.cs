﻿using AutoMapper;
using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Entities;
using CaixaEmp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Services
{
    public class WithdrawalService : IWithdrawalService
    {
        private IWithdrawalRepository _withdrawalRepository;
        private readonly IMapper _mapper;
        public WithdrawalService(IWithdrawalRepository withdrawalRepository, IMapper mapper)
        {
            _withdrawalRepository = withdrawalRepository;
            _mapper = mapper;
        }

        //public async Task<IEnumerable<WithdrawalDTO>> GetAllWithdrawalAsync()
        //{
        //    var withdrawal = await _withdrawalRepository.GetAllWithdrawalAsync();
        //    return _mapper.Map<IEnumerable<WithdrawalDTO>>(withdrawal);
        //}

        //public async Task<WithdrawalDTO> GetWithdrawalById(int? id)
        //{
        //    var withdrawal = await _withdrawalRepository.GetWithdrawalById(id);
        //    return _mapper.Map<WithdrawalDTO>(withdrawal);
        //}

        //public async Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByExpense(int expenseId)
        //{
        //    var withdrawal = await _withdrawalRepository.GetWithdrawalByExpense(expenseId);
        //    return _mapper.Map<IEnumerable<WithdrawalDTO>>(withdrawal);
        //}

        //public async Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByEmplooyer(int emplooyerId)
        //{
        //    var withdrawal = await _withdrawalRepository.GetWithdrawalByEmplooyer(emplooyerId);
        //    return _mapper.Map<IEnumerable<WithdrawalDTO>>(withdrawal);
        //}

        //public async Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByPeriod(DateTime beginDate, DateTime endDate)
        //{
        //    var withdrawal = await _withdrawalRepository.GetWithdrawalByPeriod(beginDate, endDate);
        //    return _mapper.Map<IEnumerable<WithdrawalDTO>>(withdrawal);
        //}

        //public async Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByPriority(string priority)
        //{
        //    var withdrawal = await _withdrawalRepository.GetWithdrawalByPriority(priority);
        //    return _mapper.Map<IEnumerable<WithdrawalDTO>>(withdrawal);
        //}

        //public async Task<IEnumerable<WithdrawalDTO>> GetWithdrawalAproved(bool status)
        //{
        //    var withdrawal = await _withdrawalRepository.GetWithdrawalAproved(status);
        //    return _mapper.Map<IEnumerable<WithdrawalDTO>>(withdrawal);
        //}

        //public async Task<IEnumerable<WithdrawalDTO>> GetWithdrawalReproved(bool status)
        //{
        //    var withdrawal = await _withdrawalRepository.GetInclusionReproved(status);
        //    return _mapper.Map<IEnumerable<WithdrawalDTO>>(withdrawal);
        //}

        public async Task Create(WithdrawalDTO withdrawal)
        {
            var withdrawalEntity = _mapper.Map<Withdrawal>(withdrawal);
            await _withdrawalRepository.Create(withdrawalEntity);
        }

        public async Task Update(WithdrawalDTO withdrawal)
        {
            var withdrawalEntity = _mapper.Map<Withdrawal>(withdrawal);
            await _withdrawalRepository.Update(withdrawalEntity);
        }

        public async Task Delete(WithdrawalDTO withdrawal)
        {
            var withdrawalEntity = _mapper.Map<Withdrawal>(withdrawal);
            await _withdrawalRepository.Delete(withdrawalEntity);
        }

        
    }
}
