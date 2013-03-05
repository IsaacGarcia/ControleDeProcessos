using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCompartilhado
{
    public class Repositorio
    {
        protected ISession _session;

        public Repositorio(ISession session)
        {
            _session = session;
        }

        public virtual void Salvar(Objeto objeto)
        {
            var transaction = _session.BeginTransaction();

            try
            {
                _session.SaveOrUpdate(objeto);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
            }
        }
    }
}
