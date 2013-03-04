using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao.Estados
{
    public class Carregada : Estado<PreInscricao, PreInscricaoDTO>
    {
        public override void ProximoEstado()
        {
            Contexto.Esta = "Pré-processada";
            Contexto.Estado = new PreProcessada();
        }
    }
}
