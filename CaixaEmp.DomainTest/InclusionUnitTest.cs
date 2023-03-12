using CaixaEmp.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.DomainTest
{
    public class InclusionUnitTest
    {

        [Fact(DisplayName = "CreateInclusionWithInvalidId")]
        public void CreateInclusion_WithInvalidId_ResultObjectValidState()
        {
            Action action = () => new Inclusion(-1, "InclusionName", "InclusionFunction", 10);
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id");
        }

        [Fact(DisplayName = "CreateInclusionWithValidParameters")]
        public void CreateInclusion_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Inclusion(1, "InclusionName", "InclusionDescription", 10);
            action.Should().NotThrow<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "CreateInclusionWithNullDescription")]
        public void CreateInclusion_WithNullDescription_DomainExceptionNullDescription()
        {
            Action action = () => new Inclusion(1, "InclusionName", null, 10);
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }        

        [Fact(DisplayName = "CreateInclusionWithNegativeValue")]
        public void CreateInclusion_WithNegativeValue_ResultObjectWithNegativeValue()
        {
            Action action = () => new Inclusion(1, "InclusionName", "InclusionDescription", -10);
            action.Should()
                .Throw<CaixaEmp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("O valor não pode ser negativo");
        }
    }
}
