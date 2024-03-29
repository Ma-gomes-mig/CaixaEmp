﻿using AutoMapper;
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
    public class InclusionService : IInclusionService
    {
        private IInclusionRepository _inclusionRepository;
        private readonly IMapper _mapper;
        public InclusionService(IInclusionRepository inclusionRepository, IMapper mapper)
        {
            _inclusionRepository = inclusionRepository;
            _mapper = mapper;
        }

        //public async Task<IEnumerable<InclusionDTO>> GetAllInclusionAsync()
        //{
        //    var inclusion = await _inclusionRepository.GetAllInclusionAsync();
        //    return _mapper.Map<IEnumerable<InclusionDTO>>(inclusion);    
        //}

        //public async Task<InclusionDTO> GetInclusionById(int? id)
        //{
        //    var inclusion = await _inclusionRepository.GetInclusionById(id);
        //        return _mapper.Map<InclusionDTO>(inclusion);
        //}

        //public async Task<IEnumerable<InclusionDTO>> GetInclusionByExpense(int expenseId)
        //{
        //    var inclusion = await _inclusionRepository.GetInclusionByExpense(expenseId);
        //    return _mapper.Map<IEnumerable<InclusionDTO>>(inclusion);
        //}

        //public async Task<IEnumerable<InclusionDTO>> GetInclusionByEmplooyer(int emplooyerId)
        //{
        //    var inclusion = await _inclusionRepository.GetInclusionByEmplooyer(emplooyerId);
        //    return _mapper.Map<IEnumerable<InclusionDTO>>(inclusion);
        //}

        //public async Task<IEnumerable<InclusionDTO>> GetInclusionByPeriod(DateTime beginDate, DateTime endDate)
        //{
        //    var inclusion = await _inclusionRepository.GetInclusionByPeriod(beginDate, endDate);
        //    return _mapper.Map<IEnumerable<InclusionDTO>>(inclusion);
        //}

        //public async Task<IEnumerable<InclusionDTO>> GetInclusionByPriority(string priority)
        //{
        //    var inclusion = await _inclusionRepository.GetInclusionByPriority(priority);
        //    return _mapper.Map<IEnumerable<InclusionDTO>>(inclusion); 
        //}

        //public async Task<IEnumerable<InclusionDTO>> GetInclusionAproved(bool status)
        //{
        //    var inclusion = await _inclusionRepository.GetInclusionAproved(status);
        //    return _mapper.Map<IEnumerable<InclusionDTO>>(inclusion);
        //}

        //public async Task<IEnumerable<InclusionDTO>> GetInclusionReproved(bool status)
        //{
        //    var inclusion = await _inclusionRepository.GetInclusionReproved(status);
        //    return _mapper.Map<IEnumerable<InclusionDTO>>(inclusion);
        //}

        public async Task Create(InclusionDTO inclusion)
        {
            var inclusionEntity = _mapper.Map<Inclusion>(inclusion);
            await _inclusionRepository.Create(inclusionEntity);
        }

        public async Task Update(InclusionDTO inclusion)
        {
            var inclusionEntity = _mapper.Map<Inclusion>(inclusion);
            await _inclusionRepository.Update(inclusionEntity);
        }

        public async Task Delete(InclusionDTO inclusion)
        {
            var inclusionEntity = _mapper.Map<Inclusion>(inclusion);
            await _inclusionRepository.Delete(inclusionEntity);
        }
    }
}
