using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos.Domain
{
    public class Soldado : UtilizaEstado<Soldado, SoldadoDTO>
    {
        public string Nome { get; set; }

        public void ProximoEstado()
        {
            Estado.Contexto = this;
            Estado.ProximoEstado();
        }
    }

    public class EstadoEmPe : Estado<Soldado, SoldadoDTO>
    {
        public override void ProximoEstado()
        {
            Contexto.Esta = "sentado";
            Contexto.Estado = new EstadoSentado();
        }
    }

    public class EstadoSentado : Estado<Soldado, SoldadoDTO>
    {
        public override void ProximoEstado()
        {
            Contexto.Esta = "em pé";
            Contexto.Estado = new EstadoEmPe();
        }
    }

}
