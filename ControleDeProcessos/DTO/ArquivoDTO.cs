using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos
{
    public class ArquivoDTO : DTO
    {
        public Guid Id { get; set; }
        public string Caminho { get; set; }
        public byte[] Arquivo { get; set; }
        public DataTable DadosDoArquivo { get; set; }
    }
}
