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
        public PreInscricoesController(GerenciadorDeTransacao gerenciamentoDeTransacao):base(gerenciamentoDeTransacao)
        {
        }

        protected override DTO ProximoPassoEspecifico(DTO dto, Transacao ultimaTransacao)
        {
            Repositorio repositorio = new Repositorio();
            PreInscricao preInscricao = repositorio.ObterPreInscricaoDeAcordoComA(ultimaTransacao);

            preInscricao.Estado.DTO = (PreInscricaoDTO)dto;
            preInscricao.ProximoEstado();

            dto.UltimaTransacao = ultimaTransacao;

            return new PreInscricaoDTO { Esta = preInscricao.Esta };
        }


    }
}
