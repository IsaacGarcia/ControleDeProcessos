using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain
{
    public class ServicoPreProcessamentoPreInscricao
    {
        public RelatorioPreProcessamentoDaPreInscricaoDTO PreProcessar(DataTable dadosPreInscritos)
        {
            return new RelatorioPreProcessamentoDaPreInscricaoDTO { NumeroDeNovosPreInscritos = 1, NumeroDePreInscritosPendentesDeAtualizacao = 3 };
        }
    }
}
