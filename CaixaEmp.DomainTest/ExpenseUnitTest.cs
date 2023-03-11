﻿using CaixaEmp.Domain.Entities;
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
        [Fact(DisplayName="CreateExpenseWithValidParameters")]
        public void CreateExpense_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Expense(1, "ExpenseName", "ExpenseDescription", 10, "ExpensePriority");
            action.Should().NotThrow<CaixaEmp.Domain.Validation.DomainExceptionValidation>();
        }
    }
}
