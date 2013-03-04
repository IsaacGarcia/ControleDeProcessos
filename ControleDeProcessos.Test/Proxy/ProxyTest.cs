using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Test
{
    [TestFixture]
    public class ProxyTest
    {
        private Proxy proxy;

        [SetUp]
        public void inicializar()
        {
            proxy = new Proxy();
        }

        [Test]
        public void executa_uma_atividade_do_processo_retorna_o_objeto_modificado()
        {
            SoldadoDTO soldadoDTO = proxy.Executar(new SoldadoDTO { Nome = "João"});

            Assert.AreEqual(soldadoDTO.Esta, "sentado");
        }
    }
}
