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
        [Fact(DisplayName ="CreateEmplooyerWithValidParameters  ")]
        public void CreateEmplooyer_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Emplooyer(1, "EmplooyerName","EmplooyerFunction");
            action.Should()
                .NotThrow<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "CreateEmplooyerWithInvalidId")]
        public void CreateEmplooyer_WithInvalidId_ResultObjectValidState()
        {
            Action action = () => new Emplooyer(-1, "EmplooyerName", "EmplooyerFunction");
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id");
        }
    }
}
