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
    public class WithdrawalDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Valor")]
        public decimal Value { get; set; }

        [Required]
        [DisplayName("Data")]
        public DateTime DateWithdrawal { get; set; }

        [MaxLength(30)]
        [DisplayName("Prioridade")]
        public string Priority { get; set; }

        [MaxLength(30)]
        [DisplayName("Status")]
        public bool Status { get; set; }



        //Desclaração da cardinalidade N Withdrawal para 1 Emplooyer
        public int EmplooyerId { get; set; }

        public Emplooyer Emplooyer { get; set; }

        //Definição da cardinalidade N Withdrawal para 1 Expense
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }

        //Definição da cardinalidade N Withdrawal para 1 Balance
        public int BalanceId { get; set; }
        public Balance Balance { get; set; }
    }
}
