using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos
{
    public class PreInscricaoDTO : DTO
    {
        public string Nome { get; set; }
        public string Esta { get; set; }

        public string ExtensaoDoArquivo { get; set; }

        public string Parametro { get; set; }
    }
}
