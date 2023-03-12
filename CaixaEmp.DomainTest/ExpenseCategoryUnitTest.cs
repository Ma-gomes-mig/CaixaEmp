using CaixaEmp.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.DomainTest
{
    public class ExpenseCategoryUnitTest
    {
        [Fact(DisplayName = "CreateEmplooyerWithInvalidId")]
        public void CreateEmplooyer_WithInvalidId_ResultObjectPositiveId()
        {
            Action action = () => new Emplooyer(-1, "EmplooyerName", "EmplooyerFunction");
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id");
        }

        [Fact(DisplayName = "CreateExpenseCategoryWithValidParameters")]
        public void CreateExpenseCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new ExpenseCategory(1, "ExpenseCategoryName", "Description");
            action.Should().NotThrow<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "CreateExenseCategoryWithNullDescription")]
        public void CreateExpenseCategory_WithNullDescription_DomainExceptionNullDescription()
        {
            Action action = () => new ExpenseCategory(1, "ExpenseCategoryName", null);
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }
    }
}
