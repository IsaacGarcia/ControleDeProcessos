using DominioCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioRegulamento
{
    public class Regulamento : Arquivo
    {
        public virtual Plano Plano { get; set; }
    }
}
