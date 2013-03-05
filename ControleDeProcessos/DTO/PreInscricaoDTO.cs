using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos
{
    public class PreInscricaoDTO : DTO
    {
        public string ExtensaoDoArquivo { get; set; }

        public string Parametro { get; set; }

        public byte[] Arquivo { get; set; }

        public int NumeroInsert { get; set; }

        public int NumeroUpdate { get; set; }
    }
}
