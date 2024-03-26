using HotelSOL.Models;
using HotelSOL.Nhibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using HotelSOL.Nhibernate;
using HotelSOL.Models;
using HotelSOL.DAO;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Hql.Ast;
using System.Text.RegularExpressions;


namespace HotelSOL
{
    public partial class RoomsForm : Form
    {
        private IDAO<Room> _roomDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;

        public RoomsForm()
        {
            InitializeComponent();

            myConfiguration = new Configuration()
                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Rooms.hbn.xml");
            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _roomDAO = new DAOimpl<Room>(mySessionFactory.OpenSession());

            // textBoxRoomId.Leave += textBoxRoomId_Leave;


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            showDataRooms();
        }

        private void showDataRooms()
        {
            try
            {
                // Obtener todos las habitaciones utilizando el DAO 
                IList<Room> rooms = _roomDAO.GetAll();

                // Mostrar los clientes en el DataGridView
                dataGridViewAllRooms.DataSource = rooms;
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            bool idSearchSelected = radioButtonIdentity.Checked;
            bool typeSearchSelected = radioButtonType.Checked;
            bool availabilitySearchSelected = radioButtonAvailability.Checked;
            string textToSearch = textBoxSearch.Text;

            try
            {
                using (ISession mySession = mySessionFactory.OpenSession())
                {
                    if (idSearchSelected)
                    {
                        MessageBox.Show("Id search selected");

                        // Crear una consulta HQL para buscar habitaciones por ID
                        string hqlQuery = "FROM Room WHERE room_id = :roomId";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetInt32("roomId", int.Parse(textToSearch));

                        // Obtener los resultados de la consulta
                        IList<Room> rooms = query.List<Room>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewSeaarchResult.DataSource = rooms;
                    }
                    else if (typeSearchSelected)
                    {
                        MessageBox.Show("Type search selected");

                        // Crear una consulta HQL para buscar habitaciones por tipo
                        string hqlQuery = "FROM Room WHERE type LIKE :roomType";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetString("roomType", "%" + textToSearch + "%");

                        // Obtener los resultados de la consulta
                        IList<Room> rooms = query.List<Room>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewSeaarchResult.DataSource = rooms;
                    }
                    else if (availabilitySearchSelected)
                    {
                        MessageBox.Show("Availability search selected");

                        // Crear una consulta HQL para buscar habitaciones por disponibilidad
                        string hqlQuery = "FROM Room WHERE booked = :booked";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetBoolean("booked", bool.Parse(textToSearch));

                        // Obtener los resultados de la consulta
                        IList<Room> rooms = query.List<Room>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewSeaarchResult.DataSource = rooms;
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonInsertRoom_Click(object sender, EventArgs e)
        {
            int roomNo;
            string roomType = textBoxRoomType.Text;
            decimal price;
            bool booked;
            int roomCapacity;
            string roomSeason = textBoxRoomSeason.Text;
            string roomDescription = textBoxRoomDescription.Text;

            if (!int.TryParse(textBoxRommNo.Text, out roomNo))
            {
                // Si el valor ingresado no es un número válido, salta mensaje de error
                MessageBox.Show("La capacidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir el valor de price a double
            if (!decimal.TryParse(textBoxRoomPrice.Text, out price))
            {
                // Si el valor ingresado no es un número válido, salta mensaje de error
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxRoomCapacity.Text, out roomCapacity))
            {
                // Si el valor ingresado no es un número válido, salta mensaje de error
                MessageBox.Show("La capacidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Convertir el valor de booked a bool
            if (!bool.TryParse(textBoxRoomBooked.Text, out booked))
            {
                // Si el valor ingresado no es "true" o "false",salta mensaje error
                MessageBox.Show("El valor de 'booked' debe ser 'true' o 'false'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(roomType) || String.IsNullOrEmpty(roomSeason))
            {
                MessageBox.Show("No empty fields allowed except Room Description");
                return;
            }

            try
            {
                // Crear un nuevo objeto Room con los datos del formulario
                Room newRoom = new Room
                {
                    roomNumber = roomNo,
                    type = roomType,
                    roomCapacity = roomCapacity,
                    roomSeason = roomSeason,
                    price = price,
                    roomDescription = roomDescription,
                    booked = booked

                };


                // Guardar la nueva habitación en la base de datos utilizando el DAO genérico
                _roomDAO.Insert(newRoom);

                showDataRooms();

                MessageBox.Show("Room added successfully");

            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonUpdateRoom_Click(object sender, EventArgs e)
        {
            string room_id = textBoxRoomId.Text;

            // Intentar convertir el ID del cliente a entero
            if (int.TryParse(room_id, out int roomId))
            {

                // Utilizar el método GetById para obtener la habitacion por su ID
                Room roomToUpdate = _roomDAO.GetById(roomId);

                try
                {
                    if (roomToUpdate != null)
                    {
                        // Actualizar los datos del cliente con los nuevos valores del formulario
                        if (int.TryParse(textBoxRommNo.Text, out int roomNo))
                        {
                            roomToUpdate.roomNumber = roomNo;
                        }

                        roomToUpdate.type = textBoxRoomType.Text;

                        if (int.TryParse(textBoxRoomCapacity.Text, out int capacity))
                        {
                            roomToUpdate.roomNumber = capacity;
                        }

                        roomToUpdate.roomSeason = textBoxRoomSeason.Text;

                        if (!decimal.TryParse(textBoxRoomPrice.Text, out decimal roomPrice))
                        {
                            roomToUpdate.price = roomPrice;
                        }

                        roomToUpdate.roomDescription = textBoxRoomDescription.Text;

                        if (!bool.TryParse(textBoxRoomBooked.Text, out bool roomBooked))
                        {
                            roomToUpdate.booked = roomBooked;
                        }

                        // Utilizar el método Update del DAO para guardar los cambios
                        _roomDAO.Update(roomToUpdate);

                        MessageBox.Show("Room updated successfully!");

                        // Actualizar la visualización de los clientes en el formulario
                        showDataRooms();
                    }
                    else
                    {
                        MessageBox.Show($"No room found with ID: {roomId}");
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            string room_identityNo = textBoxRoomId.Text.Trim();

            try
            {
                // Intentar convertir el ID de la habitación a entero
                if (int.TryParse(room_identityNo, out int roomId))
                {
                    // Utilizar el método GetById para obtener la habitacion por su ID
                    Room roomToDelete = _roomDAO.GetById(roomId);

                    if (roomToDelete != null)
                    {
                        // Eliminar el cliente utilizando el método Delete del DAO
                        _roomDAO.Delete(roomToDelete);

                        MessageBox.Show("Room deleted successfully!");

                        // Actualizar la visualización de los clientes en el formulario
                        showDataRooms();
                    }
                    else
                    {
                        MessageBox.Show($"No room found with ID: {roomId}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid room ID");
                }

            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textRoomSeason_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            CargaDatos cargaDatos = new CargaDatos();
            cargaDatos.ExportarDatosAXml("rooms", "data_rooms");
        }
    }


}
