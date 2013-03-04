using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao.Estados
{
    public class Finalizada : Estado<PreInscricao, PreInscricaoDTO>
    {
        public override void ProximoEstado()
        {
            throw new Exception("Esta pré-inscrição já foi finalizada!");
        }
    }
}
