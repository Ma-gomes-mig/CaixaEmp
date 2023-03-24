using AutoMapper;
using CaixaEmp.Application.Interfaces;
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

    }
}
