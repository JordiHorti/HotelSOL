using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using HotelSOL.Models;
using static System.Collections.Specialized.BitVector32;

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
                try
                {
                    if (transaction != null)
                    {
                        _session.Save(entity);
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al insertar entidad: {ex.Message}");
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw; // Lanza la excepción para que se maneje en niveles superiores
                }
            }
        }

        public void Update(T entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    _session.Update(entity);
                    if (transaction != null)
                    {
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar entidad: {ex.Message}");
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw; // Lanza la excepción para que se maneje en niveles superiores
                }
            }
        }

        public void Delete(T entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    _session.Delete(entity);
                    if (transaction != null)
                    {
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al eliminar entidad: {ex.Message}");
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw; // Lanza la excepción para que se maneje en niveles superiores
                }
            }
        
        }

        public IList<T> GetAll()
        {
            try
            {
                using (var transaction = _session.BeginTransaction())
                {
                    var query = _session.Query<T>().ToList();
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener todos los registros de {typeof(T).Name}: {ex.Message}");
                throw; // Lanza la excepción para que se maneje en niveles superiores
            }
        }
        public Booking GetLastInsertedBooking()
        {
            try
            {
                // Hacer una consulta para obtener la última reserva insertada basándote en el ID de la reserva
                // Esto es un ejemplo, asegúrate de adaptarlo a tu esquema de base de datos y a tu lógica de negocio
                return _session.Query<Booking>().OrderByDescending(b => b.bookings_id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la última reserva insertada: {ex.Message}");
                throw;
            }
        }
    }
}
