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

        public CustomersForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string customer_name, customer_identityNo, customerPhoneNo, customerEmail;
            customer_name = textBoxCustName.Text;
            customer_identityNo = textBoxCustId.Text;
            customerPhoneNo = textCustConNO.Text;
            customerEmail = textCustEmail.Text;

            if (String.IsNullOrEmpty(customer_name) || String.IsNullOrEmpty(customer_identityNo) || String.IsNullOrEmpty(customerPhoneNo))
            {
                MessageBox.Show("No empty fields allowed except email address of the customer");
                return; // Salir del método si hay campos vacíos
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
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

                    MessageBox.Show("Customer added successfully!");
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
