using DominioCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioA
{
    public class PessoaPreInscrita : PessoaFisica
    {
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual Plano Plano { get; set; }
        public virtual string Matricula { get; set; }
    }
}
