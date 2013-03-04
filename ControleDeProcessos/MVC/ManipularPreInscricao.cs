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

        public PreInscricaoDTO Executar(PreInscricaoDTO preInscricaoDTO)
        {
            return (PreInscricaoDTO)_proxy.ProcessoPreInscricao.Upload(preInscricaoDTO);
        }
    }
}
