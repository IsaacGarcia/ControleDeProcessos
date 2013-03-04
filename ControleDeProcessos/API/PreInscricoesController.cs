using ControleDeProcessos.Domain;
using ControleDeProcessos.Domain.ComponenteDePreInscricao;
using Stateless;
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
            PreInscricao preInscricao = new PreInscricao();

            // Observer
            preInscricao.Processar("jhghjG");

            return new PreInscricaoDTO();
        }

        protected override void ConfigurarMaquina(StateMachine<string, string> maquina)
        {
            maquina.Configure("Iniciada")
                .Permit("Carregar", "Carregada")
                .Permit("Rejeitar", "Rejeitada");

            maquina.Configure("Rejeitada")
                .Permit("Carregar", "Carregada");

            maquina.Configure("Carregada")
                .Permit("PreProcessar", "PreProcessada")
                .Permit("Rejeitar", "Rejeitada");

            maquina.Configure("PreProcessada")
                .Permit("Processar", "Processada")
                .Permit("Rejeitar", "Rejeitada");

            maquina.Configure("Processada")
                .Permit("Imprimir", "Impressa");
        }
    }
}
