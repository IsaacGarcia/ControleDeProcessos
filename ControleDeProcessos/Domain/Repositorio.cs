using ControleDeProcessos.Domain.ComponenteDePreInscricao;
using ControleDeProcessos.Domain.ComponenteDePreInscricao.Estados;
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

        public PreInscricao ObterPreInscricaoDeAcordoComA(Transacao transacao)
        {
            switch (transacao.UltimaAtividade)
            {
                case "Iniciada": return new PreInscricao();
                case "Carregada": return new PreInscricao(new Carregada());
                case "Rejeitada": return new PreInscricao(new Rejeitada());
                case "PreProcessada": return new PreInscricao(new PreProcessada());
                case "Processada": return new PreInscricao(new Processada());
                case "Impressa": return new PreInscricao(new Impressa());
                case "Finalizada": return new PreInscricao(new Finalizada());

                default: return null;
            }
        }
    }
}
