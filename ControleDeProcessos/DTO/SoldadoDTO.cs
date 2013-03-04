using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos
{
    public abstract class DTO
    {
        public Transacao UltimaTransacao { get; set; }

        public string Processo { get; set; }
    }

    public class SoldadoDTO:DTO
    {
        public string Esta { get; set; }

        public string Nome { get; set; }
    }
}
