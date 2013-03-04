using ControleDeProcessos.API;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Test
{
    [TestFixture]
    public class SoldadosTest
    {
        private SoldadosController soldados;

        [SetUp]
        public void inicializar()
        {
            soldados = new SoldadosController();
        }

        [Test]
        public void ao_obter_um_soldado_em_pe_e_executando_o_metodo_proximo_estado_o_mesmo_fica_sentado()
        {
            var soldado = soldados.ProximoPasso(new SoldadoDTO { Nome = "João" });

            Assert.AreEqual(soldado.Esta, "sentado");
        }

          [Test]
        public void ao_obter_um_soldado_em_pe_e_executando_o_metodo_proximo_estado_o_mesmo_fica_em_pe()
        {
            var soldado = soldados.ProximoPasso(new SoldadoDTO { Nome = "João2" });

            Assert.AreEqual(soldado.Esta, "em pé");
        }
    }
}
