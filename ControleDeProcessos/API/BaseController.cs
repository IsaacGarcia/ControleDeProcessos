using ControleDeProcessos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos.API
{
    public abstract class BaseController
    {
        private GerenciadorDeTransacao _gerenciamentoDeTransacao;

        public BaseController(GerenciadorDeTransacao gerenciamentoDeTransacao)
        {
            _gerenciamentoDeTransacao = gerenciamentoDeTransacao;
        }

        public DTO ProximoPasso(DTO dto)
        {
            Transacao transacao = _gerenciamentoDeTransacao.ObterTransacao(dto);

            var resultado = ProximoPassoEspecifico(dto, transacao);

            RegistrarTransacao(dto, ultimaAtividade: resultado.Esta, ultimaTransacao: transacao);

            return resultado;
        }

        protected abstract DTO ProximoPassoEspecifico(DTO dto, Transacao ultimaTransacao);

        public void RegistrarTransacao(DTO dto, string ultimaAtividade, Transacao ultimaTransacao)
        {
            var gerenciadorDeTransacao = new GerenciadorDeTransacao();

            gerenciadorDeTransacao.Salvar(ultimaTransacao, ultimaAtividade, dto);
        }
    }
}
