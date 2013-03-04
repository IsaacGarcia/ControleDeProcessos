using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos
{
    public class GerenciadorDeTransacao
    {
        public List<Transacao> Transacaoes { get; set; }

        public GerenciadorDeTransacao()
        {
            Transacaoes = new List<Transacao>()
            {
                new Transacao{  Usuario ="ABC", Processo="XXX", Estado="fechada"},
                new Transacao{  Usuario ="João", Processo="Manipular Soldado", Estado="aberta"}
            };
        }

        public Transacao ObterTransacao(SoldadoDTO soldadoDTO)
        {
            return Transacaoes.SingleOrDefault(x => x.Usuario == soldadoDTO.Nome && x.Processo == soldadoDTO.Processo);
        }
    }
}
