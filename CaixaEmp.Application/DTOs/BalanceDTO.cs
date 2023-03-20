using CaixaEmp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Application.DTOs
{
    public class BalanceDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Valor")]
        public decimal Value { get; set; }

        [Required]
        [DisplayName("Data")]
        public DateTime Date { get; set; }

        public ICollection<Inclusion> Inclusions { get; set; }
        public ICollection<Withdrawal> Withdrawals { get; set; }

    }
}
