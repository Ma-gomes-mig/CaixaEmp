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

        [Required(ErrorMessage ="O nome é necessário")]
        [StringLength(50)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage ="A descrição é necessária")]
        [StringLength(150)]
        [DisplayName("Descrição")]
        public string Description { get; set; }
        

        //Definição da cardinalidade N Expense para 1 ExpenseCategory
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }

        //Definição da cardinalidade N withdrawal para 1 Expense
        public ICollection<Withdrawal> Withdrawals { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Expense
        public ICollection<Inclusion> Inclusions { get; set; }

       
    }
}
