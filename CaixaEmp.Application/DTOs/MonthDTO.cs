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
    public class MonthDTO
    {
        [Key]
        public int Month { get; set; }
        [Required]
        [StringLength(20)]
        [DisplayName("Nome Mês")]

        public ICollection<Expense> Expenses { get; set; }
    }
}
