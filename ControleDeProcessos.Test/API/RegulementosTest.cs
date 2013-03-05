using ControleDeProcessos.API;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Test.API
{
    [TestFixture]
    public class RegulementosTest
    {
        [Test]
        public void salvar_regulamento()
        {
            new ControleDeProcessos.API.Regulamentos().SalvarRegulamento();
        }
    }
}
