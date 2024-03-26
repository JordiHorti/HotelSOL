using HotelSOL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSOL.DAO;
using NHibernate;
using NHibernate.Cfg;

namespace HotelSOL
{
    public partial class UsersForm : Form
    {


        private IDAO<User> _userDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;


        public UsersForm()
        {
            InitializeComponent();
            myConfiguration = new Configuration()
               .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Users.hbn.xml");
            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _userDAO = new DAOimpl<User>(mySessionFactory.OpenSession());
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            showDataUsers();
        }

        private void showDataUsers()
        {
            try
            {
                // Obtener todos los usuaios utilizando el DAO 
                IList<User> users = _userDAO.GetAll();

                // Mostrar los clientes en el DataGridView
                dataGridViewAllUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewAllCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonIdentity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonUserName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRole_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool idSearchSlected = radioButtonIdentity.Checked;
            bool userNameSearchSelected = radioButtonUserName.Checked;
            bool roleSearchSelected = radioButtonRole.Checked;
            string textToSearch = textBoxSearch.Text;


            if (idSearchSlected)
            {
                MessageBox.Show("Identity search selected");
                // Intentar convertir el valor de textToSearch a int
                if (int.TryParse(textToSearch, out int userId))
                {

                    // Utilizar el método GetById con el ID convertido a int
                    User user = _userDAO.GetById(userId);


                    // Verificar si se encontró el usuario
                    if (user != null)
                    {
                        dataGridViewSeaarchResult.Columns.Clear();
                        // Agregar las columnas necesarias si aún no están presentes
                        if (dataGridViewSeaarchResult.Columns.Count == 0)
                        {
                            dataGridViewSeaarchResult.Columns.Add("Column1", "User ID");
                            dataGridViewSeaarchResult.Columns.Add("Column2", "User Name");
                            dataGridViewSeaarchResult.Columns.Add("Column3", "User Password");
                            dataGridViewSeaarchResult.Columns.Add("Column4", "User Role");
                            dataGridViewSeaarchResult.Columns.Add("Column5", "Customer Email");
                        }
                        dataGridViewSeaarchResult.Rows.Add(user.user_id, user.userName, user.password, user.user_role);
                    }
                    else
                    {
                        MessageBox.Show($"No customer found with ID: {userId}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid customer ID");
                }

            }
            else if (userNameSearchSelected)
            {

                try
                {
                    using (ISession mySession = mySessionFactory.OpenSession())
                    {
                        dataGridViewSeaarchResult.Columns.Clear();


                        // Crear una consulta HQL para buscar clientes por nombre
                        string hqlQuery = "FROM User WHERE userName LIKE :userName";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetString("userName", "%" + textToSearch + "%");

                        // Obtener los resultados de la consulta
                        IList<User> users = query.List<User>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewSeaarchResult.DataSource = users;

                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (roleSearchSelected)
            {
                try
                {

                    using (ISession mySession = mySessionFactory.OpenSession())
                    {
                        // Crear una consulta HQL para buscar clientes por teléfono
                        string hqlQuery = "FROM User WHERE user_role =:role";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetInt32("role", int.Parse(textToSearch));

                        // Obtener los resultados de la consulta
                        IList<User> users = query.List<User>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewSeaarchResult.DataSource = users;
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonInsertUser_Click(object sender, EventArgs e)
        {

            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string role = textBoxRole.Text;

            
            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(role))
            {
                MessageBox.Show("No empty fields allowed");
                return;
            }

            try
            {
                // Crear un nuevo objeto Customer con los datos del formulario
                User newUser = new User
                {

                    userName = userName,
                    password = password,
                    user_role = int.Parse(role)

                };

                // Guardar el nuevo usuarios en la base de datos utilizando el DAO genérico
                _userDAO.Insert(newUser);

                showDataUsers(); // Actualizar la visualización de los usuarios en el formulario
                MessageBox.Show("Usuario added successfully!");

            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            string user_id = textBoxUserId.Text;

            try
            {
                // Intentar convertir el ID del usuario a entero
                if (int.TryParse(user_id, out int userId))
                {
                    // Utilizar el método GetById para obtener el usuario por su ID
                    User userToDelete = _userDAO.GetById(userId);

                    if (userToDelete != null)
                    {
                        // Eliminar el cliente utilizando el método Delete del DAO
                        _userDAO.Delete(userToDelete);

                        MessageBox.Show("User deleted successfully!");

                        // Actualizar la visualización de los clientes en el formulario
                        showDataUsers();
                    }
                    else
                    {
                        MessageBox.Show($"No user found with ID: {userId}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user ID");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            string user_id = textBoxUserId.Text;
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string role = textBoxRole.Text;

            try
            {
                // Intentar convertir el ID del usuario a entero
                if (int.TryParse(user_id, out int userId))
                {
                    // Utilizar el método GetById para obtener el usuario por su ID
                    User userToUpdate = _userDAO.GetById(userId);

                    if (userToUpdate != null)
                    {
                        // Actualizar los datos del usuario con los nuevos valores del formulario
                        userToUpdate.userName = textBoxUserName.Text;
                        userToUpdate.password = textBoxPassword.Text;
                        userToUpdate.user_role = int.Parse(textBoxRole.Text);

                        // Utilizar el método Update del DAO para guardar los cambios
                        _userDAO.Update(userToUpdate);

                        MessageBox.Show("User updated successfully!");

                        // Actualizar la visualización de los usuario en el formulario
                        showDataUsers();
                    }
                    else
                    {
                        MessageBox.Show($"No user found with ID: {userId}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user ID");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
