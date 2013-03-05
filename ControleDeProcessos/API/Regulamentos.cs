using DominioCompartilhado;
using DominioRegulamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vital.InfraStructure.Persistence.SessionManagement;
using Vital.InfraStructure.Persistence.UnitOfWorkComponent;

namespace ControleDeProcessos.API
{
    public class Regulamentos
    {
        public Regulamentos()
        {
            var session = new SessionBuilder().GetSession();

            Guid id = new RepositorioRegulamento(session).Todos().First().Id;

            Regulamento regulamento = new RepositorioRegulamento(session).Obter(id);
        }

        public void SalvarRegulamento()
        {
            var session = new SessionBuilder().GetSession();
            Repositorio repositorio = new Repositorio(session);

            Plano plano = new Plano { Nome = "Plano a" };

            repositorio.Salvar(plano);

            Regulamento regulamento = new Regulamento();

            regulamento.Caminho = @"C:\";
            regulamento.Nome = "Teste";
            regulamento.Plano = plano;

            repositorio.Salvar(regulamento);
        }
    }
}
