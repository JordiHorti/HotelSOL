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

namespace HotelSOL
{
    public partial class UsersForm : Form
    {

        private string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();

        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            showDataUsers();
        }

        private void showDataUsers()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM user_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllCustomers.DataSource = dt;
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
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM user_table WHERE user_id = @user_id", conn);
                    cmd.Parameters.AddWithValue("@user_id", textToSearch);
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
            else if (userNameSearchSelected)
            {
                MessageBox.Show("User search selected");
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM user_table WHERE username = @username", conn);
                    cmd.Parameters.AddWithValue("@username", textToSearch);
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
            else if (roleSearchSelected)
            {
                MessageBox.Show("Identity search selected");
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM user_table WHERE user_role = @user_role", conn);
                    cmd.Parameters.AddWithValue("@user_role", textToSearch);
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
            // FALLA AQUI ESTA OPCION DE INSERTAR -----------------------------

            /*
            string userId = textBoxUserId.Text;
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string role = textBoxRole.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();


                    // Verificar si la tabla user_table existe, y si no existe, crearla
                    //SqlCommand createTableCmd = new SqlCommand("IF OBJECT_ID('dbo.user_table', 'U') IS NULL CREATE TABLE user_table (user_id VARCHAR(20), username INT, type VARCHAR(100), price DECIMAL,booked bit)", conn);
                    //createTableCmd.ExecuteNonQuery();

                    // Insertar usuario en la tabla user_table
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO user_table (user_id, username, password, user_role) VALUES (@user_id, @username, @password, @user_role)", conn);
                    insertCmd.Parameters.AddWithValue("@user_id", userId);
                    insertCmd.Parameters.AddWithValue("@username", userName);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.Parameters.AddWithValue("@user_role", role);

                    insertCmd.ExecuteNonQuery();

                    showDataUsers();
                    MessageBox.Show("User added successfully");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

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
    }
}
