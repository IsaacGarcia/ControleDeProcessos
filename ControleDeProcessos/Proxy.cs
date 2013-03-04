using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos
{
    public class Proxy
    {
        public SoldadoDTO Executar(SoldadoDTO dto)
        {
            return new SoldadoDTO { Estado = "sentado" };
        }
    }
}
