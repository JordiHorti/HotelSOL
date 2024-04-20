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
using System.Collections;
using static System.Collections.Specialized.BitVector32;

namespace HotelSOL.Forms
{
    public partial class BookingForm : Form
    {
        private IDAO<Invoice> _invoiceDAO;

        private IDAO<Booking> _bookingDAO;

        private IDAO<Room> _roomDAO;

        private IDAO<Service> _serviceDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;

        public BookingForm(DAOimpl<Booking> bookingsDAO)
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


        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            showDataBookings();
            showDataServices();
            showDataRooms();

            CargaDatos cargaDatos = new CargaDatos();
            cargaDatos.uploadBookings();

        }

        private void showDataBookings()
        {
            try
            {
                // Obtener todos los clientes utilizando el DAO 
                IList<Booking> bookings = _bookingDAO.GetAll();


                // Mostrar los clientes en el DataGridView
                dataGridViewAllBooking.DataSource = bookings;

            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showDataRooms()
        {
            using (ISession mySession = mySessionFactory.OpenSession())
            {
                try
                {
                    // Obtener todos las habitaciones utilizando el DAO 
                    IList<Room> rooms = _roomDAO.GetAll();

                    // Mostrar los clientes en el DataGridView
                    dataGridViewBookingRooms.DataSource = rooms;
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showDataServices()
        {
            using (ISession mySession = mySessionFactory.OpenSession())
            {
                try
                {
                    // Obtener todos las habitaciones utilizando el DAO 
                    IList<Service> services = _serviceDAO.GetAll();

                    // Mostrar los clientes en el DataGridView
                    dataGridViewBookingServices.DataSource = services;
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            CargaDatos cargaDatos = new CargaDatos();
            cargaDatos.uploadBookings();
            cargaDatos.ExportarDatosAXml("bookings", "data_bookings");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string textToSearch = textBoxSearch.Text;
            bool email = radioButtonIdentity.Checked;
            bool number = radioButtonRoomNumber.Checked;
            bool service = radioButtonBookingService.Checked;

            CargaDatos cargaDatos = new CargaDatos();

            cargaDatos.uploadBookings();

            if (email)
            {
                MessageBox.Show("Email search selected");



                try
                {
                    using (ISession mySession = mySessionFactory.OpenSession())
                    {
                        dataGridViewSeaarchResult.Columns.Clear();

                        // Crear una consulta HQL para buscar clientes por nombre
                        string hqlQuery = "FROM Booking WHERE customerEmail LIKE :name";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetString("name", "%" + textToSearch + "%");

                        // Obtener los resultados de la consulta
                        IList<Booking> bookings = query.List<Booking>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewSeaarchResult.DataSource = bookings;

                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (number)

             
            {
                MessageBox.Show("RoomNumber search selected");

                try
                {
                    using (ISession mySession = mySessionFactory.OpenSession())
                    {
                        dataGridViewSeaarchResult.Columns.Clear();


                        // Crear una consulta HQL para buscar clientes por nombre
                        string hqlQuery = "FROM Booking WHERE roomNumber LIKE :number";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetString("number", "%" + textToSearch + "%");

                        // Obtener los resultados de la consulta
                        IList<Booking> bookings = query.List<Booking>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewSeaarchResult.DataSource = bookings;

                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (service)
            {
                MessageBox.Show("ServiceId search selected");

                try
                {

                    using (ISession mySession = mySessionFactory.OpenSession())
                    {
                        // Crear una consulta HQL para buscar clientes por teléfono
                        string hqlQuery = "FROM Booking WHERE services_id LIKE :id";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetString("id", "%" + textToSearch + "%");

                        // Obtener los resultados de la consulta
                        IList<Booking> bookings = query.List<Booking>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewSeaarchResult.DataSource = bookings;
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ISession mySession = mySessionFactory.OpenSession())
            {
                try
                {
                    // Obtener todos las habitaciones utilizando el DAO 
                    IList<Room> rooms = _roomDAO.GetAll();

                    // Mostrar los clientes en el DataGridView
                    dataGridViewBookingRooms.DataSource = rooms;
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ISession mySession = mySessionFactory.OpenSession())
            {
                try
                {
                    // Obtener todos los servicios utilizando el DAO 
                    IList<Service> services = _serviceDAO.GetAll();

                    // Mostrar los servicios en el DataGridView
                    dataGridViewBookingServices.DataSource = services;
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonInsertCust_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string servicesId = textBoxBookingId.Text;
            string customer_name = textBoxCustomerName.Text;
            string customer_email = textBoxCustomerEmail.Text;
            string room_number = textBoxRoomNumber.Text;
            string check_In = textBoxChekIn.Text;
            string check_Out = textBoxChekIn.Text;

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


                _bookingDAO.Insert(newBooking);

                GenerateInvoice(newBooking);

                CargaDatos cargaDatos = new CargaDatos();
                cargaDatos.uploadBookings();

                showDataBookings(); // Actualizar la visualización de los Bookings en el formulario

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
        private void buttonUpdateRoom_Click(object sender, EventArgs e)
        {
            string booking_identityNo = textBoxBookingId.Text;

            try
            {
                // Intentar convertir el ID del cliente a entero
                if (int.TryParse(booking_identityNo, out int bookingId))
                {
                    // Utilizar el método GetById para obtener el cliente por su ID
                    Booking bookingToUpdate = _bookingDAO.GetById(bookingId);

                    if (bookingToUpdate != null)
                    {
                        // Actualizar los datos del cliente con los nuevos valores del formulario
                        bookingToUpdate.customerName = textBoxCustomerName.Text;
                        bookingToUpdate.customerEmail = textBoxCustomerEmail.Text;
                        bookingToUpdate.roomNumber = int.Parse(textBoxRoomNumber.Text);
                        bookingToUpdate.checkIn = DateTime.Parse(textBoxChekIn.Text);
                        bookingToUpdate.checkOut = DateTime.Parse(textBoxChekIn.Text);

                        // Utilizar el método Update del DAO para guardar los cambios
                        _bookingDAO.Update(bookingToUpdate);

                        MessageBox.Show("Customer updated successfully!");

                        // Actualizar la visualización de los clientes en el formulario
                        showDataBookings();
                    }
                    else
                    {
                        MessageBox.Show($"No customer found with ID: {bookingId}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid customer ID");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            string booking_identityNo = textBoxBookingId.Text;

            try
            {
                // Intentar convertir el ID del cliente a entero
                if (int.TryParse(booking_identityNo, out int customerId))
                {
                    // Utilizar el método GetById para obtener el cliente por su ID
                    Booking bookingToDelete = _bookingDAO.GetById(customerId);

                    if (bookingToDelete != null)
                    {
                        // Eliminar el cliente utilizando el método Delete del DAO
                        _bookingDAO.Delete(bookingToDelete);

                        MessageBox.Show("Customer deleted successfully!");

                        // Actualizar la visualización de los clientes en el formulario
                        showDataBookings();
                    }
                    else
                    {
                        MessageBox.Show($"No customer found with ID: {customerId}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid customer ID");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSeaarchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {
            CargaDatos cargaDatos = new CargaDatos();
            cargaDatos.importDataBookingsToDatabase();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


}
