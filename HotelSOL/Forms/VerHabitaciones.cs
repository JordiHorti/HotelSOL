using HotelSOL.DAO;
using HotelSOL.Models;
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
using HotelSOL.Models;
using HotelSOL.DAO;
using NHibernate;
using NHibernate.Cfg;

namespace HotelSOL.Cliente
{
    public partial class VerHabitaciones : Form
    {
        private IDAO<Room> _roomDAO;

        private IDAO<Service> _serviceDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;

        public VerHabitaciones()
        {
            InitializeComponent();

            myConfiguration = new Configuration()
                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Rooms.hbn.xml")
                                    .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Service.hbn.xml");

            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _roomDAO = new DAOimpl<Room>(mySessionFactory.OpenSession());
            _serviceDAO = new DAOimpl<Service>(mySessionFactory.OpenSession());

            dataGridViewAllServices.CellContentClick += dataGridViewAllServices_CellContentClick;

        }
        private void VerHabitaciones_Load(object sender, EventArgs e)
        {
            showDataRooms();
            showDataServices();
        }

        private void showDataRooms()
        {
            try
            {
                // Obtener todos las habitaciones utilizando el DAO 
                IList<Room> rooms = _roomDAO.GetAll();

                // Mostrar los clientes en el DataGridView
                dataGridViewSeaarchResult.DataSource = rooms;
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void showDataServices()
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string roomType = "";

            if (radioButtonDoble.Checked)
            {
                roomType = "Doble";
            }
            else if (radioButtonIndividual.Checked)
            {
                roomType = "Individual";
            }
            else if (radioButtonSuite.Checked)
            {
                roomType = "Suite";
            }
            else if (radioButtonFamiliar.Checked)
            {
                roomType = "Familiar";
            }
            else if (radioButtonTodas.Checked && radioButtonTodas.Checked)
            {
                showDataRooms();
                MessageBox.Show("Se mostrarán todas las habitaciones con todos los precios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            try
            {
                using (ISession mySession = mySessionFactory.OpenSession())
                {
                    dataGridViewSeaarchResult.Columns.Clear();

                    // Crear una consulta HQL base para buscar habitaciones por tipo
                    string hqlQuery = "FROM Room WHERE roomType = :type";

                    // Agregar condiciones para el precio de la habitación según la opción seleccionada
                    if (radioButtonPrice100.Checked)
                    {
                        hqlQuery += " AND price < 101";
                    }
                    else if (radioButtonPrice300.Checked)
                    {
                        hqlQuery += " AND price > 100 AND price < 301";
                    }

                    // Si ninguna opción está seleccionada, no se agregan condiciones de precio

                    // Ejecutar la consulta utilizando NHibernate
                    IQuery query = mySession.CreateQuery(hqlQuery);
                    query.SetString("type", roomType);

                    // Obtener los resultados de la consulta
                    IList<Room> rooms = query.List<Room>();

                    // Llenar el DataGridView con los resultados
                    dataGridViewSeaarchResult.DataSource = rooms;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAllServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDataServices();
        }
    }
}
