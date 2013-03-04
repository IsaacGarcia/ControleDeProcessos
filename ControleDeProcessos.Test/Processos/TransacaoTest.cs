using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Test
{
    [TestFixture]
    public class TransacaoTest
    {
        private Transacao transacao;

        [SetUp]
        public void inicializar()
        {
            transacao = new Transacao();
        }

        [Test]
        public void executa_o_proximo_passo_de_uma_transacao_alterando_o_valor_do_objeto_de_requisicao()
        {
            var soldado = transacao.ProximoPasso(new SoldadoDTO { Nome = "João" });

            Assert.AreEqual(soldado.Esta, "sentado");
        }
    }
}
