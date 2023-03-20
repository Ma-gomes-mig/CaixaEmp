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

        [DisplayName("Valor")]
        public decimal Value { get; set; }

        [DisplayName("Data")]
        public DateTime DateWithdrawal { get; set; }
    }
}
