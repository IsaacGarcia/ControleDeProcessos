using ControleDeProcessos.Domain;
using Stateless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos.API
{
    public abstract class BaseController
    {
        private GerenciadorDeTransacao _gerenciamentoDeTransacao;

        public StateMachine<string, string> Maquina { get; set; }

        public DTO Retorno { get; set; }

        public BaseController(GerenciadorDeTransacao gerenciamentoDeTransacao)
        {
            _gerenciamentoDeTransacao = gerenciamentoDeTransacao;
        }

        public DTO ProximoPasso(DTO dto)
        {
            Transacao transacao = _gerenciamentoDeTransacao.ObterTransacao(dto);

            Maquina = new StateMachine<string,string>(transacao.UltimaAtividade);

            ConfigurarMaquina(Maquina, dto);

            var resultado = new DTO();

            try
            {
                ExecutarAtividade(dto);
            }
            catch(Exception ex)
            {
                resultado.Erros = ex.Message;
            }

            resultado.Esta = Maquina.State;

            RegistrarTransacao(dto, ultimaAtividade: resultado.Esta, ultimaTransacao: transacao);

            return resultado;
        }
        
        public void ExecutarAtividade(DTO dto)
        {
            if (Maquina.CanFire(dto.Acao))
                Maquina.Fire(dto.Acao);
            else
                throw new Exception("Transição não permitida");
        }


        protected abstract DTO ProximoPassoEspecifico(DTO dto, Transacao ultimaTransacao);
        protected abstract void ConfigurarMaquina(StateMachine<string, string> maquina, DTO dto);

        public void RegistrarTransacao(DTO dto, string ultimaAtividade, Transacao ultimaTransacao)
        {
            var gerenciadorDeTransacao = new GerenciadorDeTransacao();

            gerenciadorDeTransacao.Salvar(ultimaTransacao, ultimaAtividade, dto);
        }
    }
}
