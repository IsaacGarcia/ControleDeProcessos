using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Core
{
    public interface IServicoRepositorioDeArquivos
    {
        DTO Salvar(DTO arquivo);
        DTO ObterArquivo(DTO dadosDoArquivo);
    }
}
