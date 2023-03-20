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
    public class ExpenseDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName]
        public string Name { get; set; }

        [StringLength(150)]
        [DisplayName("Descrição")]
        public string Description { get; set; }

       public decimal Value { get; set; }
        [Required]
        [StringLength(30)]
       public string Priority { get; set; }

        //Definição da cardinalidade N Expense para 1 Emplooyer
        public int EmplooyerId { get; set; }
        public Emplooyer Emplooyer { get; set; }

        //Definição da cardinalidade N Expense para 1 ExpenseCategory
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }

        //Definição da cardinalidade N withdrawal para 1 Expense
        public ICollection<Withdrawal> Withdrawals { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Expense
        public ICollection<Inclusion> Inclusions { get; set; }       
    }
}
