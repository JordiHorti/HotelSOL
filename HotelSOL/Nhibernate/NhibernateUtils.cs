using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using NHibernate;

namespace HotelSOL.Nhibernate
{
   
    internal class NhibernateUtils
    {
        private string connStr = @"Data Source=.\DESKTOP-DR4N647\SQLEXPRESS01;Initial Catalog=HotelSOL;User Id=root;Password=1234;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public Configuration Config { get; private set; }

        public ISessionFactory SessionFactory { get; private set; } // Añadimos una propiedad para almacenar la sesión de fábrica


        public NhibernateUtils() { 

            Config = new Configuration();

            Config.DataBaseIntegration(d => {
                d.ConnectionString= connStr;
                d.Dialect<MsSql2012Dialect>();
                d.Driver<SqlClientDriver>();
            });
            Config.AddAssembly(Assembly.GetExecutingAssembly());
            SessionFactory = Config.BuildSessionFactory();
        }

        public ISession GetSession()
        {
            return SessionFactory.OpenSession();
        }

    }
}
