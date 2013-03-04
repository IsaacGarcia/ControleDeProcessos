using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos.Domain
{
    public class Soldado
    {
        public string Esta { get; set; }

        public string Nome { get; set; }

        public EstadoDoSoldado Estado { get; set; }

        public void ProximoEstado()
        {
            Estado.Soldado = this;
            Estado.ProximoEstado();
        }
    }


    public abstract class EstadoDoSoldado
    {
        public Soldado Soldado { get; set; }
        public abstract void ProximoEstado();
    }

    public class EstadoEmPe : EstadoDoSoldado
    {
        public override void ProximoEstado()
        {
            Soldado.Esta = "sentado";
            Soldado.Estado = new EstadoSentado();
        }
    }

    public class EstadoSentado : EstadoDoSoldado
    {
        public override void ProximoEstado()
        {
            Soldado.Esta = "em pé";
            Soldado.Estado = new EstadoEmPe();
        }
    }

}
