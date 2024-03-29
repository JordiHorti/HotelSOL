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
using System.Globalization;
using static System.Collections.Specialized.BitVector32;

namespace HotelSOL.Cliente
{
    public partial class VerHabitaciones : Form
    {

        private IDAO<Room> _roomDAO;

        private IDAO<Service> _serviceDAO;

        private IDAO<Booking> _bookingDAO;

        private IDAO<Invoice> _invoiceDAO;


        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;

        public VerHabitaciones()
        {
            InitializeComponent();

            myConfiguration = new Configuration()
                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Booking.hbn.xml")
                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Invoice.hbn.xml")
                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Rooms.hbn.xml")
                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Service.hbn.xml");


            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _bookingDAO = new DAOimpl<Booking>(mySessionFactory.OpenSession());

            _roomDAO = new DAOimpl<Room>(mySessionFactory.OpenSession());

            _serviceDAO = new DAOimpl<Service>(mySessionFactory.OpenSession());

            _invoiceDAO = new DAOimpl<Invoice>(mySessionFactory.OpenSession());


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

                IList<Room> unbookedRooms = new List<Room>();


                foreach (Room room in rooms)
                {
                    if (!room.booked)
                    {
                        unbookedRooms.Add(room);
                    }
                }

                // Mostrar los clientes en el DataGridView
                dataGridViewSeaarchResult.DataSource = unbookedRooms;
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string servicesId = textBoxServiceId.Text;
            string customer_name = textBoxName.Text;
            string customer_email = textBoxEmail.Text;
            string room_number = textBoxRoomNumber.Text;
            string check_In = textBoxCheckIn.Text;
            string check_Out = textBoxCheckOut.Text;

            if (String.IsNullOrEmpty(customer_name) || String.IsNullOrEmpty(servicesId) || String.IsNullOrEmpty(customer_email) ||
                String.IsNullOrEmpty(room_number) || String.IsNullOrEmpty(check_In) || String.IsNullOrEmpty(check_Out))
            {
                MessageBox.Show("No empty fields allowed");
                return;
            }

            try
            {
                // Crear un nuevo objeto booking con los datos del formulario
                Booking newBooking = new Booking
                {
                    services_id = int.Parse(servicesId),
                    customerName = customer_name,
                    customerEmail = customer_email,
                    roomNumber = int.Parse(room_number),
                    checkIn = DateTime.ParseExact(check_In, "yyyy/MM/dd", CultureInfo.InvariantCulture),
                    checkOut = DateTime.ParseExact(check_Out, "yyyy/MM/dd", CultureInfo.InvariantCulture)
                };

                // Guardar el nuevo booking en la base de datos utilizando el DAO genérico
                _bookingDAO.Insert(newBooking);

                GenerateInvoice(newBooking);


                CargaDatos cargaDatos = new CargaDatos();

                cargaDatos.uploadBookings();

                cargaDatos.uploadBookingsBooked();

                MessageBox.Show("Booking added successfully!");
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void GenerateInvoice(Booking booking)
        {
            try
            {
                

                // Crear una nueva instancia de Invoice y asignar los valores
                Invoice newInvoice = new Invoice
                {
                    bookings_id = booking.bookings_id,
                    customer_id = booking.customer_id,
                    customerName = booking.customerName,
                    customerEmail = booking.customerEmail,
                    roomNumber = booking.roomNumber,
                    service = booking.service, // Puede ser nulo
                    checkIn = booking.checkIn,
                    checkOut = booking.checkOut,
                    days = (booking.checkOut - booking.checkIn).Days, // Calcular la duración de la reserva
                };

                // Guardar la nueva factura en la base de datos utilizando el DAO correspondiente
                _invoiceDAO.Insert(newInvoice);

                MessageBox.Show("Invoice generated and saved successfully!");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra al generar y guardar la factura
                string errorMessage = $"Error while generating and saving invoice: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSeaarchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
