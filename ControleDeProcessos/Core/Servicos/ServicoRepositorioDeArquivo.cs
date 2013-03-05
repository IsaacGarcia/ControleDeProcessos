using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Core.Servicos
{
    public class ServicoRepositorioDeArquivo : IServicoRepositorioDeArquivos
    {
        public DTO Salvar(DTO arquivo)
        {
            return new ArquivoDTO() { Id = Guid.NewGuid() }; 
        }

        public DTO ObterArquivo(DTO dadosDoArquivo)
        {
            ArquivoDTO arquivo = (ArquivoDTO)dadosDoArquivo;

            return new ArquivoDTO { Id = arquivo.Id };
        }
    }
}
