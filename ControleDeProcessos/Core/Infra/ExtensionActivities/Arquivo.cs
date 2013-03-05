using ControleDeProcessos.Core.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Core.Infra.ExtensionActivities
{
    public static class Arquivo
    {
        public static IServicoRepositorioDeArquivos FabricarServicoRepositorioDeArquivo()
        {
            return new ServicoRepositorioDeArquivo();
        }

        public static ArquivoDTO Salvar(this byte[] arquivo)
        {
            ArquivoDTO dto = new ArquivoDTO { Arquivo = arquivo };

            return (ArquivoDTO)FabricarServicoRepositorioDeArquivo().Salvar(dto);
        }
    }
}
