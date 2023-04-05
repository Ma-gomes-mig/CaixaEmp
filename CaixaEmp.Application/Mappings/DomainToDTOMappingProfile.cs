using AutoMapper;
using CaixaEmp.Application.DTOs;
using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Balance, BalanceDTO>().ReverseMap();
            CreateMap<Emplooyer, EmplooyerDTO>().ReverseMap();
            CreateMap<ExpenseCategory, ExpenseCategoryDTO>().ReverseMap();
            CreateMap<Expense, ExpenseCategoryDTO>().ReverseMap();
            CreateMap<Inclusion, InclusionDTO>().ReverseMap();
            CreateMap<Withdrawal, WithdrawalDTO>().ReverseMap();
            CreateMap<Month, MonthDTO>().ReverseMap();

        }
    }
}
