using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.MVC
{
    public class ManipularPreInscricao
    {
        private Proxy _proxy;

        public ManipularPreInscricao(Proxy proxy)
        {
            _proxy = proxy;
        }

        public DTO Upload(PreInscricaoDTO preInscricaoDTO)
        {
            return _proxy.ProcessoPreInscricao.Upload(preInscricaoDTO);
        }

        public DTO PreProcessar(PreInscricaoDTO preInscricaoDTO)
        {
            return _proxy.ProcessoPreInscricao.PreProcessar(preInscricaoDTO);
        }

        public DTO Processar(PreInscricaoDTO preInscricaoDTO)
        {
            return _proxy.ProcessoPreInscricao.Processar(preInscricaoDTO);
        }

        public DTO Imprimir(PreInscricaoDTO preInscricaoDTO)
        {
            return _proxy.ProcessoPreInscricao.Imprimir(preInscricaoDTO);
        }
    }
}
