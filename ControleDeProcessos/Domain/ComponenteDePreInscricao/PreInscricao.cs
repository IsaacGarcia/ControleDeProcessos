using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao
{
    public class PreInscricao 
    {
        public PreInscricao()
        {
           
        }

        public void SubirArquivo(string extensao)
        {
            if (extensao == "pdf")
                throw new Exception("erro ao carregar");
        }

        public void Processar(string parametro)
        {
            if (parametro == "a")
                throw new Exception("erro");
        }
    }
}
