using HotelSOL.DAO;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSOL.DAO;
using NHibernate;
using NHibernate.Cfg;
using HotelSOL.Models;

namespace HotelSOL.Forms
{
    public partial class ServiceForm : Form
    {
        private IDAO<Service> _serviceDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;

        public ServiceForm()
        {
            InitializeComponent();
            myConfiguration = new Configuration()
               .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Service.hbn.xml");
            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _serviceDAO = new DAOimpl<Service>(mySessionFactory.OpenSession());
        }


        private void showDataService()
        {
            try
            {
                // Obtener todos los usuaios utilizando el DAO 
                IList<Service> services = _serviceDAO.GetAll();

                // Mostrar los clientes en el DataGridView
                dataGridViewAllServices.DataSource = services;
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAllServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDataService();
        }

        private void ServiceForm_Load_1(object sender, EventArgs e)
        {
            showDataService();
        }
    }
}
