using CaixaEmp.Domain.Validation;
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
        public int Value { get; private set; }
        public DateTime DateInclusion { get; private set; }
        public string Priority { get; private set; }
        public string Status { get; private set; }

        //Construtor vazio
        public Inclusion()
        {

        }

        //Construtor com todas as propriedades
        public Inclusion(int id, string name, string description, int value, DateTime dateInclusion, string priority, string status)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidateName(name);
            Description = description;
            Value = value;
            DateInclusion = dateInclusion;
            Priority = priority;
            Status = status;
        }

        //Construtor para Update
        public void Update(string name, string description, DateTime dateInclusion, string priority, string status)
        {
            ValidateName(name);
            ValidateDescription(description);
            DateInclusion = dateInclusion;
            Priority = priority;
            Status = status;
        }

        //Definição da cardinalidade N Withdrawal para 1 Emplooyer
        public int EmplooyerId { get; set; }
        public Emplooyer Emplooyer { get; set; }

        //Definição da cardinalidade N Withdrawal para 1 Expense
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }

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
    }
}
