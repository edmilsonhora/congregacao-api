using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Modelo.DomainModel
{
   public class Cliente:EntityBase
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
