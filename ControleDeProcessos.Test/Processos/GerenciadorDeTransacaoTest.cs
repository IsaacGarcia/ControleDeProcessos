using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Test
{
    [TestFixture]
    public class GerenciadorDeTransacaoTest
    {
        private GerenciadorDeTransacao gerenciadorDeTransacao;

        [SetUp]
        public void inicializar()
        {
            gerenciadorDeTransacao = new GerenciadorDeTransacao();
        }

        [Test]
        public void obter_uma_transacao_de_acordo_com_processo_e_usuario()
        {
            Transacao transacao = gerenciadorDeTransacao.ObterTransacao(new SoldadoDTO() { Usuario = "João", Processo = "Manipular Soldado" });

            Assert.AreEqual(transacao.Estado, "aberta");
        }
    }
}
