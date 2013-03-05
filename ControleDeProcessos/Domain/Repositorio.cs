using ControleDeProcessos.Domain.ComponenteDePreInscricao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain
{
    public class Repositorio
    {
        public Soldado ObterSoldadoPeloNome(string nome)
        {
            var soldado = new Soldado();

            if (nome == "João")
            {
                soldado.Nome = nome;
                soldado.Estado = new EstadoEmPe();
            }
            else
            {
                soldado.Nome = nome;
                soldado.Estado = new EstadoSentado();
            }

            return soldado;
        }
    }
}
