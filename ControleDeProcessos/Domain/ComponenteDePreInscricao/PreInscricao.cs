using ControleDeProcessos.Domain.ComponenteDePreInscricao.Estados;
using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao
{
    public class PreInscricao : UtilizaEstado<PreInscricao, PreInscricaoDTO>
    {
        public PreInscricao()
        {
            Esta = "iniciada";
            Estado = new Iniciada();
        }

        public PreInscricao(Estado<PreInscricao, PreInscricaoDTO> estado)
        {
            Estado = estado;
        }

        public void SubirArquivo(string extensao)
        {
            if (extensao == "pdf")
                throw new Exception("erro ao carregar");
        }

        public void Processar(string parametro)
        {
            if (parametro == "a")
                throw new Exception("erro");
        }

        public void ProximoEstado()
        {
            Estado.Contexto = this;
            Estado.ProximoEstado();
        }
    }
}
