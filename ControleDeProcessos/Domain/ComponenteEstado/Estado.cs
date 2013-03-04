using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteEstado
{
    public abstract class Estado<T, Dto> where Dto: DTO
    {
        public T Contexto { get; set; }
        public Dto DTO { get; set; }
        public abstract void ProximoEstado();
    }
}
