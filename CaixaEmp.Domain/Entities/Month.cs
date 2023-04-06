using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Domain.Entities
{
    public class Month : Base
    {
        public string Name { get; private set; }

        public Month(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Update(string name)
        {
            Name = name;
        }

        //Definição da cardinalidade N Inclusion para 1 Month
        public ICollection<Withdrawal> Withdrawals { get; set; }

        //Definição da cardinalidade N Inclusion para 1 Month
        public ICollection<Inclusion> Inclusions { get; set; }
    }
}
