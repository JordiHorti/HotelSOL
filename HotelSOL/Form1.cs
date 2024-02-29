using System.Data;
using System.Data.SqlClient;
namespace HotelSOL

{
    public partial class Form1 : Form
    {
        private string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToString();
            string password = textBoxPassword.Text.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("No empty fields allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user_table WHERE username ='"+username+"'AND password ='"+password+"'";
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        FormHome formHome = new FormHome();
                        formHome.Show();
                        this.Hide();
                    //  MessageBox.Show("User found for id: " + reader.GetInt32(0).ToString());
                        MessageBox.Show("Connection Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("User or Password are incorrect");
                }
                conn.Close();

            }
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
