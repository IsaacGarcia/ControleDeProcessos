using ControleDeProcessos.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleDeProcessos
{
    public class Proxy
    {
        private GerenciadorDeTransacao gerenciadorDeTransacao;

        public Proxy()
        {
            gerenciadorDeTransacao = new GerenciadorDeTransacao();
        }

        public SoldadoDTO Executar(SoldadoDTO dto)
        {
            dto.UltimaTransacao = gerenciadorDeTransacao.ObterTransacao(dto);

            return new SoldadosController().ProximoPasso(dto);
        }

        public PreInscricaoDTO Executar(PreInscricaoDTO preInscricaoDTO)
        {
            preInscricaoDTO.UltimaTransacao = gerenciadorDeTransacao.ObterTransacao(preInscricaoDTO);

            return (PreInscricaoDTO)new PreInscricoesController(gerenciadorDeTransacao).ProximoPasso(preInscricaoDTO);
        }
    }
}
