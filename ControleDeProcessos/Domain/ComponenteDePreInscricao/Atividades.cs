using ControleDeProcessos.API;
using ControleDeProcessos.Core;
using ControleDeProcessos.Core.Servicos;
using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeProcessos.Core.Infra.ExtensionActivities;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao
{
    public class Acao
    {
        public string Nome { get; set; }

        private IList<Atividade> _atividades;

        public Acao()
        {
            _atividades = new List<Atividade>();
        }

        public virtual void Registrar(Atividade atividade)
        {
            _atividades.Add(atividade);
        }

        public virtual void Remover(Atividade atividade)
        {
            _atividades.Remove(atividade);
        }

        public virtual bool Executar(DTO dto)
        {
            try
            {
                foreach (var atividade in _atividades)
                    atividade.Executar(dto);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    public abstract class Atividade
    {
        public abstract void Executar(DTO dto);
    }

    public class AtividadeProcessarArquivo : Atividade
    {
        public override void Executar(DTO dto)
        {

        }
    }

    public class AtividadeSubirArquivo : Atividade
    {
        public IServicoTransformarArquivo FabricarServicoTransformarArquivo()
        {
            return new ServicoTransformarArquivo();
        }

        public override void Executar(DTO dto)
        {
            var preInscricaoDTO = (PreInscricaoDTO)dto;

            if (preInscricaoDTO.ExtensaoDoArquivo == "pdf")
                throw new Exception("");

            var arquivo = preInscricaoDTO.Arquivo.Salvar();

            var relatorio =  PreProcessar(arquivo);

            preInscricaoDTO.NumeroInsert = relatorio.NumeroDeNovosPreInscritos;
            preInscricaoDTO.NumeroUpdate = relatorio.NumeroDePreInscritosPendentesDeAtualizacao;
        }

        private RelatorioPreProcessamentoDaPreInscricaoDTO PreProcessar(ArquivoDTO arquivo)
        {
            ArquivoDTO arquivoDto = (ArquivoDTO)FabricarServicoTransformarArquivo().DeTextoParaDataTable(arquivo);

            return ObterPreProcessamento(arquivoDto.DadosDoArquivo);
        }

        private RelatorioPreProcessamentoDaPreInscricaoDTO ObterPreProcessamento(DataTable dadosDosPreInscritos)
        {
            return new ServicoPreProcessamentoPreInscricao().PreProcessar(dadosDosPreInscritos);
        }
    }
}
