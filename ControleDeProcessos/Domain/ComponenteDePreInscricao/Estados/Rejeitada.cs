using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao.Estados
{
    public class Rejeitada : Estado<PreInscricao, PreInscricaoDTO>
    {
        public override void ProximoEstado()
        {
            //RESET
            Contexto.Esta = "iniciada";
            Contexto.Estado = new Iniciada();
            Contexto.Estado.DTO = this.DTO;
            Contexto.Estado.Contexto = this.Contexto;

            //GO
            Contexto.Estado.ProximoEstado();
        }
    }
}
