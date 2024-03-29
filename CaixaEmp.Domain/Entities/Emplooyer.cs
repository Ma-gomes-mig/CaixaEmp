﻿using CaixaEmp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Entities
{
    public sealed class Emplooyer : Base
    {
        //Atributos de Emplooyer
        public string Name { get; private set; }
        public string Office { get; private set; }

        //Construtor vazio
        public Emplooyer() { }

        //Construtor com todos os atributos
        public Emplooyer(int id, string name, string office)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidateName(name);
            ValidadeOffice(office);
        }        

        public void Update(string name)
        {
            ValidateName(name);
        }

        //Definição da cardinalidade N Withdrawal para 1 Emplooyer
        public ICollection<Withdrawal> Withdrawals { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Expense
        public ICollection<Inclusion> Inclusions { get; set; }

        private void ValidateName(String name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "O nome é necessário");
            Name = name;
        }

        private void ValidadeOffice(string office)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(office), "A descrição é necessária");
            Office = office;
        }
    }
}
