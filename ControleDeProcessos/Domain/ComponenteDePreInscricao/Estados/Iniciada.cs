using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao.Estados
{
    public class Iniciada : Estado<PreInscricao, PreInscricaoDTO>
    {
        public override void ProximoEstado()
        {
            PreInscricaoDTO dto = (PreInscricaoDTO)DTO;

            try
            {
                Contexto.SubirArquivo(dto.ExtensaoDoArquivo);
                Contexto.Esta = "Carregada";
                Contexto.Estado = new Carregada();
            }
            catch (Exception)
            {
                Contexto.Esta = "Rejeitada";
                Contexto.Estado = new Rejeitada();
            }
        }
    }
}
