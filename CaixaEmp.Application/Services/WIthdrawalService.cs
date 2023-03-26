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
    public class WithdrawalService : IWithdrawalService
    {
        private IWithdrawalRepository _withdrawalRepository;
        private readonly IMapper _mapper;
        public WithdrawalService(IWithdrawalRepository withdrawalRepository, IMapper mapper)
        {
            _withdrawalRepository = withdrawalRepository;
            _mapper = mapper;
        }

        public Task<IEnumerable<WithdrawalDTO>> GetAllWithdrawalAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WithdrawalDTO> GetWithdrawalById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByExpense(int expenseId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByEmplooyer(int emplooyerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByPeriod(DateTime beginDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WithdrawalDTO>> GetWithdrawalByPriority(string priority)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WithdrawalDTO>> GetWithdrawalAproved(bool status)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WithdrawalDTO>> GetInclusionReproved(bool status)
        {
            throw new NotImplementedException();
        }

        public Task Create(WithdrawalDTO withdrawal)
        {
            throw new NotImplementedException();
        }

        public Task Update(WithdrawalDTO withdrawal)
        {
            throw new NotImplementedException();
        }

        public Task Delete(WithdrawalDTO withdrawal)
        {
            throw new NotImplementedException();
        }
    }
}
