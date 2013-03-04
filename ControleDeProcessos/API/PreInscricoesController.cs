using ControleDeProcessos.Domain;
using ControleDeProcessos.Domain.ComponenteDePreInscricao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.API
{
    public class PreInscricoesController: BaseController
    {
        private GerenciadorDeTransacao _gerenciamentoDeTransacao;

        public PreInscricoesController(GerenciadorDeTransacao gerenciamentoDeTransacao)
        {
            _gerenciamentoDeTransacao = gerenciamentoDeTransacao;
        }

        protected override DTO ProximoPassoEspecifico(DTO dto)
        {
            Repositorio repositorio = new Repositorio();

            Transacao transacao = _gerenciamentoDeTransacao.ObterTransacao((PreInscricaoDTO)dto);

            PreInscricao preInscricao = repositorio.ObterPreInscricaoDeAcordoComA(transacao);

            preInscricao.Estado.DTO = (PreInscricaoDTO)dto;
            preInscricao.ProximoEstado();

            RegistrarTransacao(dto, ultimaAtividade: preInscricao.Esta);

            return new PreInscricaoDTO { Esta = preInscricao.Esta };
        }


    }
}
