using CaixaEmp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Entities
{
    public class ExpenseCategory : Base
    {
        //Atributos ExpenseCategory
        public string Name { get; set; }
        public string Description { get; set; }

        //Construtor vazio
        public ExpenseCategory()
        {

        }

        //Construtor com todas as propriedades
        public ExpenseCategory(int id, string name, string description)
        {
            Id = id;
            ValidateName(name);
            Description = description;
        }

        public void Update(string name, string description)
        {
            ValidateName(name);
            ValidadeDescription(description);
        }

        //Definição da cardinalidade N Expense para 1 ExpenseCategory
        public ICollection<Expense> Expenses { get; set; }

        private void ValidateName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "O nome é necessário");
            Name = name;
        }

        private void ValidadeDescription(string description)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "A descrição é necessária");
            Description = description;
        }
    }
}
