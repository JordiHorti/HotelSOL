using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using HotelSOL.DAO;
using HotelSOL.Models;



namespace HotelSOL
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            CargaDatos cargadatos = new CargaDatos();
            cargadatos.uploadUsers();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}