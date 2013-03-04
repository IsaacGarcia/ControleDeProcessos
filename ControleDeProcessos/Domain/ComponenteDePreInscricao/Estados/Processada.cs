using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao.Estados
{
    public class Processada : Estado<PreInscricao, PreInscricaoDTO>
    {
        public override void ProximoEstado()
        {
            PreInscricaoDTO dto = (PreInscricaoDTO)DTO;
            try
            {
                Contexto.Processar(dto.Parametro);

                Contexto.Esta = "Impressa";
                Contexto.Estado = new Impressa();

            }
            catch (Exception)
            {

                Contexto.Esta = "Rejeitada";
                Contexto.Estado = new Rejeitada();
            }

        }
    }
}
