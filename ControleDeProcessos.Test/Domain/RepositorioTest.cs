using ControleDeProcessos.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Test.Domain
{
    [TestFixture]
    public class RepositorioTest
    {
        [Test]
        public void obter_com_atividade_nao_conhecida()
        {
            Assert.IsNull(new Repositorio().ObterPreInscricaoDeAcordoComA(new Transacao { UltimaAtividade = "jkghkjh" }));
        }
    }
}
