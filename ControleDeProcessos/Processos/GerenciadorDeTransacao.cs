using ControleDeProcessos.Domain;
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
                new Transacao{  Usuario ="João", Processo="Manipular Soldado", Estado="aberta"},
                new Transacao{  Usuario ="Isaac1", Processo="Manipular Pré-Inscrição", Estado="aberta", UltimaAtividade = "Iniciada"},
                new Transacao{  Usuario ="Isaac2", Processo="Manipular Pré-Inscrição", Estado="aberta", UltimaAtividade = "Carregada"},
                new Transacao{  Usuario ="Isaac2b", Processo="Manipular Pré-Inscrição", Estado="aberta", UltimaAtividade = "Rejeitada"},
                new Transacao{  Usuario ="Isaac3", Processo="Manipular Pré-Inscrição", Estado="aberta", UltimaAtividade = "PreProcessada"},
                new Transacao{  Usuario ="Isaac4", Processo="Manipular Pré-Inscrição", Estado="aberta", UltimaAtividade = "Processada"},
                new Transacao{  Usuario ="Isaac5", Processo="Manipular Pré-Inscrição", Estado="aberta", UltimaAtividade = "Impressa"},
                new Transacao{  Usuario ="Isaac6", Processo="Manipular Pré-Inscrição", Estado="fechada", UltimaAtividade = "Finalizada"},
            };
        }

        public Transacao ObterTransacao(DTO dto)
        {
            return Transacaoes.SingleOrDefault(x => x.Usuario == dto.Usuario && x.Processo == dto.Processo);
        }

        public  void Salvar(Transacao transacao, string ultimaAtividade, DTO dto)
        {
            Transacaoes.Add(new Transacao { Usuario = transacao.Usuario, Processo = transacao.Processo, UltimaAtividade = ultimaAtividade, Data = DateTime.Now, Dto = dto });
        }
    }
}
