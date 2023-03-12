using CaixaEmp.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.DomainTest
{
    public class WithdrawalUnitTest
    {
        [Fact(DisplayName = "CreateWithdrawalWithInvalidId")]
        public void CreateEmplooyer_WithInvalidId_ResultObjectValidState()
        {
            Action action = () => new Withdrawal(-1, "WithdrawalName", "WithdrawalDescription", 10);
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id");
        }

        [Fact(DisplayName = "CreateWithdrawalWithValidParameters")]
        public void CreateWithdrawal_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Withdrawal(1, "WithdrawalName", "WithdrawalDescription", 10);
            action.Should().NotThrow<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "CreateWithdrawalWithNullDescription")]
        public void CreateWithdrawal_WithNullDescription_DomainExceptionNullDescription()
        {
            Action action = () => new Withdrawal(1, "WithdrawalName", null, 10);
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "CreateWithdrawalWithNegativeValue")]
        public void CreateWithdrawal_WithNegativeValue_ResultObjectWithNegativeValue()
        {
            Action action = () => new Withdrawal(1, "WithdrawalName", "WithdrawalDescription", -10);
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("O valor não pode ser negativo");
        }
    }
}
