using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.API
{
    public class Soldados
    {
        public SoldadoDTO ProximoPasso(SoldadoDTO dto)
        {
            return new SoldadoDTO { Nome = "João", Esta = "sentado" };
        }
    }
}
