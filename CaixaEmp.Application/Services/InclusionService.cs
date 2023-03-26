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
    public class InclusionService : IInclusionService
    {
        private IInclusionRepository _inclusionRepository;
        private readonly IMapper _mapper;
        public InclusionService(IInclusionRepository inclusionRepository, IMapper mapper)
        {
            _inclusionRepository = inclusionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InclusionDTO>> GetAllInclusionAsync()
        {
            var inclusion = await _inclusionRepository.GetAllInclusionAsync();
            return _mapper.Map<IEnumerable<InclusionDTO>>(inclusion);    
        }

        public Task<InclusionDTO> GetInclusionById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InclusionDTO>> GetInclusionByExpense(int expenseId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InclusionDTO>> GetInclusionByEmplooyer(int emplooyerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InclusionDTO>> GetInclusionByPeriod(DateTime beginDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InclusionDTO>> GetInclusionByPriority(string priority)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InclusionDTO>> GetInclusionAproved(bool status)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InclusionDTO>> GetInclusionReproved(bool status)
        {
            throw new NotImplementedException();
        }

        public Task Create(InclusionDTO inclusion)
        {
            throw new NotImplementedException();
        }

        public Task Update(InclusionDTO inclusion)
        {
            throw new NotImplementedException();
        }

        public Task Delete(InclusionDTO inclusion)
        {
            throw new NotImplementedException();
        }
    }
}
