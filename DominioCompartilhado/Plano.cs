using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCompartilhado
{
    public class Plano : Objeto
    {
        public virtual IList<PessoaJuridica> PessoasJuridicas { get; set; }
    }
}
