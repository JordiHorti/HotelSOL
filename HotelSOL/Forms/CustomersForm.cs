using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using HotelSOL.Nhibernate;
using HotelSOL.Models;
using HotelSOL.DAO;
using NHibernate;
using NHibernate.Cfg;

namespace HotelSOL
{
    public partial class CustomersForm : Form
    {

        private IDAO<Customer> _customerDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;

        public CustomersForm()
        {
            InitializeComponent();

            myConfiguration = new Configuration()
                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Customers.hbn.xml");
            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _customerDAO = new DAOimpl<Customer>(mySessionFactory.OpenSession());

          
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            showDataCustomers();

        }
        private void buttonInsertCust_Click(object sender, EventArgs e)
        {


            // Obtener datos del formulario
            string customer_name = textBoxCustName.Text;
            string customerPhoneNo = textCustConNO.Text;
            string customerEmail = textCustEmail.Text;

            if (String.IsNullOrEmpty(customer_name) || String.IsNullOrEmpty(customerPhoneNo))
            {
                MessageBox.Show("No empty fields allowed except email address of the customer");
                return;
            }

            try
            {
                // Crear un nuevo objeto Customer con los datos del formulario
                Customer newCustomer = new Customer
                {
                    customerName = customer_name,
                    customerEmail = customerEmail,
                    customerPhone = customerPhoneNo
                };
                Console.WriteLine("Estamos aquí");

                // Guardar el nuevo cliente en la base de datos utilizando el DAO genérico
                _customerDAO.Insert(newCustomer);

                showDataCustomers(); // Actualizar la visualización de los clientes en el formulario
                MessageBox.Show("Customer added successfully!");
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void showDataCustomers()
        {
            try
            {
                // Obtener todos los clientes utilizando el DAO 
                IList<Customer> customers = _customerDAO.GetAll();

                // Mostrar los clientes en el DataGridView
                dataGridViewAllCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSearchCust_Click(object sender, EventArgs e)
        {
            bool idSearchSlected = radioButtonIdentity.Checked;
            bool nameSearchSelected = radioButtonName.Checked;
            bool phoneSearchSelected = radioButtonPhone.Checked;
            string textToSearch = textBoxSearch.Text;

            if (idSearchSlected)
            {
                MessageBox.Show("Identity search selected");
                // Intentar convertir el valor de textToSearch a int
                if (int.TryParse(textToSearch, out int customerId))
                {
                    
                    // Utilizar el método GetById con el ID convertido a int
                    Customer customer = _customerDAO.GetById(customerId);


                    // Verificar si se encontró el cliente
                    if (customer != null)
                    {
                        dataGridViewSeaarchResult.Columns.Clear();
                        // Agregar las columnas necesarias si aún no están presentes
                        if (dataGridViewSeaarchResult.Columns.Count == 0)
                        {
                            dataGridViewSeaarchResult.Columns.Add("Column1", "Customer ID");
                            dataGridViewSeaarchResult.Columns.Add("Column2", "Customer Name");
                            dataGridViewSeaarchResult.Columns.Add("Column3", "Customer Phone");
                            dataGridViewSeaarchResult.Columns.Add("Column4", "Customer Email");
                        }
                        dataGridViewSeaarchResult.Rows.Add(customer.customer_id, customer.customerName, customer.customerPhone, customer.customerEmail);
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
            else if (nameSearchSelected)
            {

                using (ISession mySession = mySessionFactory.OpenSession())
                {
                    dataGridViewSeaarchResult.Columns.Clear();
                    // Crear una consulta HQL para buscar clientes por teléfono
                    string hqlQuery = "FROM Customer WHERE CustomerName LIKE :name";

                    // Ejecutar la consulta utilizando NHibernate
                    IQuery query = mySession.CreateQuery(hqlQuery);
                    query.SetString("name", "%" + textToSearch + "%");

                    // Obtener los resultados de la consulta
                    IList<Customer> customers = query.List<Customer>();

                    // Llenar el DataGridView con los resultados
                    dataGridViewSeaarchResult.DataSource = customers;
                }

               
            }
            else if (phoneSearchSelected)
            {
                using (ISession mySession = mySessionFactory.OpenSession())
                {
                    // Crear una consulta HQL para buscar clientes por teléfono
                    string hqlQuery = "FROM Customer WHERE CustomerPhone LIKE :phone";

                    // Ejecutar la consulta utilizando NHibernate
                    IQuery query = mySession.CreateQuery(hqlQuery);
                    query.SetString("phone", "%" + textToSearch + "%");

                    // Obtener los resultados de la consulta
                    IList<Customer> customers = query.List<Customer>();

                    // Llenar el DataGridView con los resultados
                    dataGridViewSeaarchResult.DataSource = customers;
                }
           
            }

        }

        private void buttonUpdateCust_Click(object sender, EventArgs e)
        {
            string customer_identityNo = textBoxCustId.Text;

            try
            {
                // Intentar convertir el ID del cliente a entero
                if (int.TryParse(customer_identityNo, out int customerId))
                {
                    // Utilizar el método GetById para obtener el cliente por su ID
                    Customer customerToUpdate = _customerDAO.GetById(customerId);

                    if (customerToUpdate != null)
                    {
                        // Actualizar los datos del cliente con los nuevos valores del formulario
                        customerToUpdate.customerName = textBoxCustName.Text;
                        customerToUpdate.customerPhone = textCustConNO.Text;
                        customerToUpdate.customerEmail = textCustEmail.Text;

                        // Utilizar el método Update del DAO para guardar los cambios
                        _customerDAO.Update(customerToUpdate);

                        MessageBox.Show("Customer updated successfully!");

                        // Actualizar la visualización de los clientes en el formulario
                        showDataCustomers();
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
        private void buttonDeleteCust_Click(object sender, EventArgs e)
        {
            string customer_identityNo = textBoxCustId.Text;

            try
            {
                // Intentar convertir el ID del cliente a entero
                if (int.TryParse(customer_identityNo, out int customerId))
                {
                    // Utilizar el método GetById para obtener el cliente por su ID
                    Customer customerToDelete = _customerDAO.GetById(customerId);

                    if (customerToDelete != null)
                    {
                        // Eliminar el cliente utilizando el método Delete del DAO
                        _customerDAO.Delete(customerToDelete);

                        MessageBox.Show("Customer deleted successfully!");

                        // Actualizar la visualización de los clientes en el formulario
                        showDataCustomers();
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

        /*
        private string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();


        public CustomersForm()
        {
            InitializeComponent();
        }


        private void buttonInsertCust_Click(object sender, EventArgs e)
        {

            string customer_name = textBoxCustName.Text;
            string customer_identityNo = textBoxCustId.Text;
            string customerPhoneNo = textCustConNO.Text;
            string customerEmail = textCustEmail.Text;

            if (String.IsNullOrEmpty(customer_name) || String.IsNullOrEmpty(customer_identityNo) || String.IsNullOrEmpty(customerPhoneNo))
            {
                MessageBox.Show("No empty fields allowed except email address of the customer");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.ConnectionString = CONNECTION_STRING;
                    conn.Open();

                    // Verificar si la tabla customers existe, y si no existe, crearla
                    SqlCommand createTableCmd = new SqlCommand("IF OBJECT_ID('dbo.customers', 'U') IS NULL CREATE TABLE customers (customerName VARCHAR(100), customerEmail VARCHAR(100), customerPhone VARCHAR(20), IdentityNo VARCHAR(20))", conn);
                    createTableCmd.ExecuteNonQuery();

                    // Insertar el cliente en la tabla customers
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO customers (customerName, customerEmail, customerPhone, IdentityNo) VALUES (@customer_name, @customerEmail, @customerPhoneNo, @customer_identityNo)", conn);
                    insertCmd.Parameters.AddWithValue("@customer_name", customer_name);
                    insertCmd.Parameters.AddWithValue("@customerEmail", customerEmail);
                    insertCmd.Parameters.AddWithValue("@customerPhoneNo", customerPhoneNo);
                    insertCmd.Parameters.AddWithValue("@customer_identityNo", customer_identityNo);
                    insertCmd.ExecuteNonQuery();

                    showDataCustomers();
                    MessageBox.Show("Customer added successfully!");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            showDataCustomers();

        }

        private void showDataCustomers()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM customers", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllCustomers.DataSource = dt;
        }

        private void buttonSearchCust_Click(object sender, EventArgs e)
        {
            bool idSearchSlected = radioButtonIdentity.Checked;
            bool nameSearchSelected = radioButtonName.Checked;
            bool phoneSearchSelected = radioButtonPhone.Checked;
            string textToSearch = textBoxSearch.Text;

            if (idSearchSlected)
            {
                MessageBox.Show("Identity search selected");
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM customers WHERE IdentityNo = @IdentityNo", conn);
                    cmd.Parameters.AddWithValue("@IdentityNo", textToSearch);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        adpt.Fill(dt);
                        dataGridViewSeaarchResult.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = $"Connection Error: {ex.Message}";
                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (nameSearchSelected)
            {
                MessageBox.Show("Name search selected");
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM customers WHERE customerName = @customerName", conn);
                    cmd.Parameters.AddWithValue("@customerName", textToSearch);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        adpt.Fill(dt);
                        dataGridViewSeaarchResult.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = $"Connection Error: {ex.Message}";
                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (phoneSearchSelected)
            {
                MessageBox.Show("Phone search selected");
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM customers WHERE customerPhone = @customerPhone", conn);
                    cmd.Parameters.AddWithValue("@customerPhone", textToSearch);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        adpt.Fill(dt);
                        dataGridViewSeaarchResult.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = $"Connection Error: {ex.Message}";
                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateCust_Click(object sender, EventArgs e)
        {
            string customer_name = textBoxCustName.Text;
            string customer_identityNo = textBoxCustId.Text;
            string customerPhoneNo = textCustConNO.Text;
            string customerEmail = textCustEmail.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    SqlCommand updateCmd = new SqlCommand("UPDATE customers SET customerName = @customer_name, customerEmail = @customerEmail, customerPhone = @customerPhoneNo WHERE IdentityNo = @customer_identityNo", conn);
                    updateCmd.Parameters.AddWithValue("@customer_name", customer_name);
                    updateCmd.Parameters.AddWithValue("@customerEmail", customerEmail);
                    updateCmd.Parameters.AddWithValue("@customerPhoneNo", customerPhoneNo);
                    updateCmd.Parameters.AddWithValue("@customer_identityNo", customer_identityNo);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Customer updated successfully!");

                    showDataCustomers();

                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteCust_Click(object sender, EventArgs e)
        {
            string customer_identityNo = textBoxCustId.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM customers WHERE IdentityNo = @customer_identityNo", conn);

                    deleteCmd.Parameters.AddWithValue("@customer_identityNo", customer_identityNo);
                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Customer deleted successfully!");

                    showDataCustomers();

                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
        */
    }
}