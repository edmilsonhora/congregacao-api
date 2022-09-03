using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Modelo.DomainModel
{
   public class Convenio:EntityBase
    {
        public string Nome { get; set; }
        public int ModalidadeId { get; set; }
    }
}
