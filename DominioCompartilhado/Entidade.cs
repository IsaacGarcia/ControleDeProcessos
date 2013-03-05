using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCompartilhado
{
    public class Objeto
    {
        public virtual Guid Id { get; set; }
        public virtual string Nome { get; set; }
    }

    public class Entidade : Objeto 
    {
        public virtual IList<Plano> Planos { get; set; }
    }
}
