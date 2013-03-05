using DominioCompartilhado;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioRegulamento
{
    public class RepositorioRegulamento : Repositorio
    {
        public RepositorioRegulamento(ISession session):base(session)
        {

        }
        public IList<Regulamento> Todos()
        {
            return _session.QueryOver<Regulamento>().List<Regulamento>();
        }

        public Regulamento Obter(Guid id)
        {
            return _session.QueryOver<Regulamento>().Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
