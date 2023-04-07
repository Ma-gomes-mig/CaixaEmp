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
    public class EmplooyerDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Função")]
        public string Office { get; set; }

        //Definição da cardinalidade N Expense para 1 Emplooyer
        public ICollection<Withdrawal> Withdrawal { get; set; }
        //Definição da cardinalidade N Inclusion para 1 Emplooyer
        public ICollection<Inclusion> Inclusions { get; set; }
    }
}
