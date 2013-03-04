using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao.Estados
{
    public class Impressa : Estado<PreInscricao, PreInscricaoDTO>
    {
        public override void ProximoEstado()
        {
            Contexto.Esta = "Finalizada";
            Contexto.Estado = new Finalizada();
        }
    }
}
