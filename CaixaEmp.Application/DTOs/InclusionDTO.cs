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
    public class InclusionDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        [Required]
        [DisplayName("Valor")]
        public decimal Value { get; set; }

        [DisplayName("Data")]
        public DateTime DateInclusion { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Prioridade")]
        public string Priority { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Status")]
        public string Status { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Emplooyer
        public int EmplooyerId { get; set; }
        public Emplooyer Emplooyer { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Expense
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Balance
        public int BalanceId { get; set; }
        public Balance Balance { get; set; }
    }
}
