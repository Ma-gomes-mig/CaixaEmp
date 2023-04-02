using CaixaEmp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Entities
{
    public sealed class Expense : Base
    {
        //Atributos de Expense
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public string Priority { get; private set; }


        //Constructor vazio
        public Expense() { }

        //Construtor com todos os atributos
        public Expense(int id, string name, string description, decimal value, string priority, int emplooyerId, int expenseCategoryId)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidateName(name);
            ValidateDescription(description);
            Value = value;
            Priority = priority;
            EmplooyerId = emplooyerId;
            ExpenseCategoryId = expenseCategoryId;
        }

        public void Update(string name, string description, string priority)
        {
            ValidateName(name);
            ValidateDescription(description);

        }

        //Definição da cardinalidade N Expense para 1 Emplooyer
        public int EmplooyerId { get; set; }
        public Emplooyer Emplooyer { get; set; }

        //Definição da cardinalidade N Expense para 1 ExpenseCategory
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }

        //Definição da cardinalidade N Withdrawal para 1 Expense
        public ICollection<Withdrawal> Withdrawals { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Expense
        public ICollection<Inclusion> Inclusions { get; set; }

        //Validação Se nome nulo ou vazio msg erro
        private void ValidateName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "O nome é necessário");
            Name = name;
        }
        private void ValidateDescription(string description)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "A descrição é necessária");
            Description = description;
        }
    }
}
