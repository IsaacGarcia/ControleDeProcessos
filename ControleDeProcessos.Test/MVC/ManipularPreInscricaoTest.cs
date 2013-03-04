using ControleDeProcessos.MVC;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Test.MVC
{
    [TestFixture]
    public class ManipularPreInscricaoTest
    {
        private ManipularPreInscricao manipularPreInscricao;

        [SetUp]
        public void inicializar()
        {
            manipularPreInscricao = new ManipularPreInscricao(new Proxy());
        }

        [Test]
        public void carregar_pre_inscricao_iniciada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Nome = "Isaac1", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Executar(preInscricao);

            Assert.AreEqual(dto.Esta, "Carregada");
        }

        [Test]
        public void rejeitar_uma_pre_inscricao_iniciada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "pdf", Nome = "Isaac1", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Executar(preInscricao);

            Assert.AreEqual(dto.Esta, "Rejeitada");
        }

        [Test]
        public void carregar_uma_pre_inscricao_rejeitada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Nome = "Isaac2b", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Executar(preInscricao);

            Assert.AreEqual(dto.Esta, "Carregada");
        }

        [Test]
        public void pre_processar_uma_pre_inscricao_carregada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Nome = "Isaac2", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Executar(preInscricao);

            Assert.AreEqual(dto.Esta, "Pré-processada");
        }

        [Test]
        public void processar_uma_pre_inscricao_pre_processada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Nome = "Isaac3", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Executar(preInscricao);

            Assert.AreEqual(dto.Esta, "processada");
        }

        [Test]
        public void imprimir_uma_pre_inscricao_processada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Nome = "Isaac4", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Executar(preInscricao);

            Assert.AreEqual(dto.Esta, "Impressa");
        }

        [Test]
        public void finalizar_uma_pre_inscricao_impressa()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Nome = "Isaac5", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Executar(preInscricao);

            Assert.AreEqual(dto.Esta, "Finalizada");
        }

        [Test]
        public void finalizar_uma_pre_inscricao_finalizada_deve_lancar_excecao()
        {
            string message = string.Empty;

            try
            {
                var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Nome = "Isaac6", Processo = "Manipular Pré-Inscrição" };

                var dto = manipularPreInscricao.Executar(preInscricao);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Esta pré-inscrição já foi finalizada!", message);
        }
    }
}
