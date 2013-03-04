using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos
{
    public class ManipularSoldado
    {
        private Proxy _proxy;

        public ManipularSoldado(Proxy proxy)
        {
            _proxy = proxy;
        }

        public SoldadoDTO Executar(SoldadoDTO soldado)
        {
            return _proxy.Executar(soldado);
        }
    }
}
