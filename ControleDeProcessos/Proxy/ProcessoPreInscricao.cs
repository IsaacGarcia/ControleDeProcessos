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
            return new PreInscricoesController(_gerenciadorDeTransacao).ProximoPasso(dto);
        }

        public virtual DTO PreProcessar(DTO dto)
        {
            dto.Acao = "PreProcessar";
            return new PreInscricoesController(_gerenciadorDeTransacao).ProximoPasso(dto);
        }

        public virtual DTO Processar(DTO dto)
        {
            dto.Acao = "Processar";
            return new PreInscricoesController(_gerenciadorDeTransacao).ProximoPasso(dto);
        }

        public virtual DTO Imprimir(DTO dto)
        {
            dto.Acao = "Imprimir";
            return new PreInscricoesController(_gerenciadorDeTransacao).ProximoPasso(dto);
        }
    }
}
