using CaixaEmp.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.DomainTest
{
    public class ExpenseUnitTest
    {
        [Fact(DisplayName = "CreateEmplooyerWithInvalidId")]
        public void CreateEmplooyer_WithInvalidId_ResultObjectValidState()
        {
            Action action = () => new Emplooyer(-1, "EmplooyerName", "EmplooyerFunction");
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id");
        }

        [Fact(DisplayName="CreateExpenseWithValidParameters")]
        public void CreateExpense_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Expense(1, "ExpenseName", "ExpenseDescription", 10, "ExpensePriority");
            action.Should().NotThrow<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName ="CreateExenseWithNullDescription")]
        public void CreateExpense_WithNullDescription_DomainExceptionNullDescription()
        {
            Action action = () => new Expense(1,"ExpenseName",null, 10, "ExpensePriority");
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }
    }
}
