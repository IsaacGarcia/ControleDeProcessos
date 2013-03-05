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
    public class PreInscricoesController : BaseController
    {
        public PreInscricoesController(GerenciadorDeTransacao gerenciamentoDeTransacao)
            : base(gerenciamentoDeTransacao)
        {
        }

        protected override DTO ProximoPassoEspecifico(DTO dto, Transacao ultimaTransacao)
        {
            return dto;
        }

        protected override void ConfigurarMaquina(StateMachine<string, string> maquina, DTO dto)
        {
            Acao carregar = new Acao();
            Acao processar = new Acao();

            carregar.Registrar(new AtividadeSubirArquivo());
            processar.Registrar(new AtividadeProcessarArquivo());

            maquina.Configure("Iniciada")
                .PermitIf("Carregar", "Carregada", () =>  carregar.Executar(dto) );

            maquina.Configure("Carregada")
                .Permit("PreProcessar", "PreProcessada");

            maquina.Configure("PreProcessada")
                .PermitIf("Processar", "Processada", ()=> processar.Executar(dto));

            maquina.Configure("Processada")
                .Permit("Imprimir", "Impressa");
        }
    }
}
