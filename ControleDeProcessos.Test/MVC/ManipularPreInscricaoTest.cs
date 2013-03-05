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
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Usuario = "Isaac1", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Upload(preInscricao);

            Assert.AreEqual(dto.Esta, "Carregada");
        }

        [Test]
        public void rejeitar_uma_pre_inscricao_iniciada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "pdf", Usuario = "Isaac1", Processo = "Manipular Pré-Inscrição" };

            var dtoRetornado = manipularPreInscricao.Upload(preInscricao);

            Assert.That("Iniciada", Is.EqualTo(dtoRetornado.Esta));
        }

        [Test]
        public void pre_processar_uma_pre_inscricao_carregada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Usuario = "Isaac2", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.PreProcessar(preInscricao);

            Assert.AreEqual(dto.Esta, "PreProcessada");
        }

        [Test]
        public void processar_uma_pre_inscricao_pre_processada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Usuario = "Isaac3", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Processar(preInscricao);

            Assert.AreEqual(dto.Esta, "Processada");
        }

        [Test]
        public void imprimir_uma_pre_inscricao_processada()
        {
            var preInscricao = new PreInscricaoDTO { ExtensaoDoArquivo = "xls", Usuario = "Isaac4", Processo = "Manipular Pré-Inscrição" };

            var dto = manipularPreInscricao.Imprimir(preInscricao);

            Assert.AreEqual(dto.Esta, "Impressa");
        }
    }
}
