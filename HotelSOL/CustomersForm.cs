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

namespace HotelSOL
{
    public partial class CustomersForm : Form
    {
        private string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();


        public CustomersForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
}