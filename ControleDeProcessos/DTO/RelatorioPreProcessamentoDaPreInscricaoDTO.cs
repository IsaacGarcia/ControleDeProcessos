using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos
{
    public class RelatorioPreProcessamentoDaPreInscricaoDTO:DTO
    {
        public int NumeroDeNovosPreInscritos { get; set; }
        public int NumeroDePreInscritosPendentesDeAtualizacao { get; set; }
    }
}
