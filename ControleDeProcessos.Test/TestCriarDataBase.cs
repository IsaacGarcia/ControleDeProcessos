using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vital.InfraStructure.Persistence.SessionManagement;

namespace ControleDeProcessos.Test
{
    [TestFixture]
    public class TestCriarDataBase
    {
        [Test]
        public void criar_banco()
        {
            var fullSessionState = new FullSessionState();
            fullSessionState.CreateDataBase();
        }
    }
}
