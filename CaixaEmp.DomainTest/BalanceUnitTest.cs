using CaixaEmp.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.DomainTest
{
    public class BalanceUnitTest
    {
        [Fact(DisplayName ="CreateBalanceWithPositiveValue")]
        public void CreateBalace_WithPositiveValue_ResultPositiveValue()
        {
            Action action = () => new Balance(-52);
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>();                
        }

    }
}
