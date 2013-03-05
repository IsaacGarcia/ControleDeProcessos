using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Core.Servicos
{
    public class ServicoTransformarArquivo:IServicoTransformarArquivo
    {
        public DTO DeTextoParaDataTable(DTO arquivo)
        {
            return new ArquivoDTO(); 
        }
    }
}
