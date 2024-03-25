using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;

namespace HotelSOL.DAO
{
    public class DAOimpl<T> : IDAO<T> where T : class
    {
        private ISession _session;

        public DAOimpl(ISession session)
        {
            _session = session;
        }

        public T GetById(int id)
        {
            return _session.Get<T>(id);
        }

        public void Insert(T entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                _session.Save(entity);
                transaction.Commit();
            }
        }

        public void Update(T entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                _session.Update(entity);
                transaction.Commit();
            }
        }

        public void Delete(T entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                _session.Delete(entity);
                transaction.Commit();
            }
        }

        public IList<T> GetAll()
        {
            try
            {
                using (var transaction = _session.BeginTransaction())
                {
                    var query = _session.Query<T>().ToList();
                    transaction.Commit();
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener todos los registros de {typeof(T).Name}: {ex.Message}");
            }
            return new List<T>();
        }

    }
}
