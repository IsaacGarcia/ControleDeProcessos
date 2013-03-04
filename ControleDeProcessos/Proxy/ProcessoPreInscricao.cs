using ControleDeProcessos.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos
{
    public class ProcessoPreInscricao
    {
        private GerenciadorDeTransacao _gerenciadorDeTransacao;

        public ProcessoPreInscricao(GerenciadorDeTransacao gerenciadorDeTransacao)
        {
            _gerenciadorDeTransacao = gerenciadorDeTransacao;
        }

        public virtual DTO Upload(DTO dto)
        {
            dto.Acao = "Carregar";
            return (PreInscricaoDTO)new PreInscricoesController(_gerenciadorDeTransacao).ProximoPasso(dto);
        }

        public virtual DTO PreProcessar(DTO dto)
        {
            return (PreInscricaoDTO)new PreInscricoesController(_gerenciadorDeTransacao).ProximoPasso(dto);
        }

        public virtual DTO Processar(DTO dto)
        {
            return (PreInscricaoDTO)new PreInscricoesController(_gerenciadorDeTransacao).ProximoPasso(dto);
        }

        public virtual DTO Imprimir(DTO dto)
        {
            return (PreInscricaoDTO)new PreInscricoesController(_gerenciadorDeTransacao).ProximoPasso(dto);
        }
    }
}
