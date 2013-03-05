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

        public ProcessoPreInscricao ProcessoPreInscricao { get; set; }

        public Proxy()
        {
            gerenciadorDeTransacao = new GerenciadorDeTransacao();
            ProcessoPreInscricao = new ProcessoPreInscricao(gerenciadorDeTransacao);
        }

        public SoldadoDTO Executar(SoldadoDTO dto)
        {
            dto.UltimaTransacao = gerenciadorDeTransacao.ObterTransacao(dto);

            return new SoldadosController().ProximoPasso(dto);
        }
    }
}
