using CaixaEmp.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.DomainTest
{
    public class EmplooyerUnitTest
    {
        [Fact(DisplayName ="CreateEmplooyerWithValidTest")]
        public void CreateEmplooyer_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Emplooyer(1, "EmplooyerName","EmplooyerFunction");
            action.Should()
                .NotThrow<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }
    }
}
