using CaixaEmp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Entities
{
    public class Balance : Base
    {
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }

        //Construtor vazio
        public Balance() { }

        public Balance(decimal value)
        {
            ValidateValue(value);            
        }

        public Balance(decimal value, DateTime date)
        {
            ValidateValue(value);
            Date = date;
        }

        public ICollection<Withdrawal> Withdrawals { get; set; }

        public ICollection<Inclusion> Inclusions { get; set; } 

        private void ValidateValue(decimal value) 
        {
            DomainExceptionValidation.When(decimal.IsNegative(value), "O valor deve ser maior que 0");
            Value = value;
        }

    }
}
