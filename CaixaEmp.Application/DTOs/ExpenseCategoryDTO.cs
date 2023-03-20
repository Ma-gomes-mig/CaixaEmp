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
    public class ExpenseCategoryDTO
    {
        [Key]
       public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        public ICollection<Expense> Expenses { get; set; }
    }
}
