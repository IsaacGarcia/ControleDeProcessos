using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Test
{
    [TestFixture]
    public class ManipularSoldadoTest
    {
        private ManipularSoldado manipularSoldado;

        [SetUp]
        public void inicializar()
        {
            Proxy proxy = new Proxy();
            manipularSoldado = new ManipularSoldado(proxy);
        }

        [Test]
        public void ao_executar_o_proxy_com_uma_transacao_aberta_faz_o_soldado_mudar_de_estado()
        {
            SoldadoDTO soldado = manipularSoldado.Executar(new SoldadoDTO { Nome = "João"});

            Assert.AreEqual(soldado.Esta, "sentado");
        }
    }
}
