﻿    using CaixaEmp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Entities
{
    public sealed class Inclusion : Base
    {
        //Atributos Inclusion
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public DateTime DateInclusion { get; private set; }
        public string Priority { get; private set; }
        public bool Status { get; private set; }

        //Construtor vazio
        public Inclusion()
        {

        }

        public Inclusion(int id, string name, string description, decimal value)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidateName(name);
            ValidateDescription(description);
            ValidateValueIsNegative(value);
        }

        //Construtor com todas as propriedades
        public Inclusion(int id, string name, string description, decimal value, DateTime dateInclusion, string priority, bool status)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidateName(name);
            ValidateDescription(description);
            ValidateValueIsNegative(value);
            DateInclusion = dateInclusion;
            Priority = priority;
            Status = status;
        }

        //Construtor para Update
        public void Update(string name, string description, DateTime dateInclusion, string priority, bool status)
        {
            ValidateName(name);
            ValidateDescription(description);
            DateInclusion = dateInclusion;
            Priority = priority;
            Status = status;
        }

        //Definição da cardinalidade N Inclusion para 1 Emplooyer
        public int EmplooyerId { get; set; }
        public Emplooyer Emplooyer { get; set; }

        //Definição da cardinalidade N inclusion para 1 Expense - Nesse caso não será necessário o Expense fazer referência no Inclusion pois é o
        //Emplooyer que vai fazer uma inclusão.
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }

        //Definição da cardinalidade N Inclusion para 1 balance
        public int BalanceId { get; set; }
        public Balance Balance { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Month
        public int MonthId { get; set; }
        public Month Month { get; set; }

        //Fazendo validação Se nome null msg erro
        private void ValidateName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "O nome é necessário");
            Name = name;
        }

        private void ValidateDescription(string description)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "O nome é necessário");
            Description = description;
        }

        private void ValidateValueIsNegative(decimal value)
        {
            DomainExceptionValidation.When(decimal.IsNegative(value), "O valor não pode ser negativo");
            Value = value;
        }
    }
}
