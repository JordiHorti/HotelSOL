using HotelSOL.Cliente;
using HotelSOL.DAO;
using HotelSOL.Forms;
using HotelSOL.Models;
using System.Data;
using System.Data.SqlClient;

namespace HotelSOL
{
    public partial class Form1 : Form
    {
        private string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        private DAOimpl<Booking> _bookingsDAO;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToString();
            string password = textBoxPassword.Text.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("No empty fields allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT users_id, user_role FROM users WHERE username = @userName AND userPassword = @password";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int userRole = reader.GetInt32(1);

                    Form nextForm;

                    switch (userRole)
                    {
                        case 1:
                            nextForm = new FormHome();
                            break;
                        case 2:
                            nextForm = new RoomsCliente();
                            break;
                        case 3:
                            nextForm = new FormHome();
                            break;
                        default:
                            MessageBox.Show("Rol de usuario no encontrado");
                            nextForm = null;
                            break;
                    }

                    if (nextForm != null)
                    {
                        nextForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User or Password are incorrect");
                }

                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}