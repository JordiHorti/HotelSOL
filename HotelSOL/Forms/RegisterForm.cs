using HotelSOL.Nhibernate;
using HotelSOL.Models;
using HotelSOL.DAO;
using NHibernate;
using NHibernate.Cfg;

namespace HotelSOL.Forms
{
    public partial class RegisterForm : Form
    {

        private IDAO<Customer> _customerDAO;
        private IDAO<User> _userDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;
        public RegisterForm()
        {
            InitializeComponent();

            myConfiguration = new Configuration()
                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Customers.hbn.xml");
            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _customerDAO = new DAOimpl<Customer>(mySessionFactory.OpenSession());

            _userDAO = new DAOimpl<User>(mySessionFactory.OpenSession());
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInsertCust_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string customer_name = textBoxCustomerName.Text;
            string customerEmail = textCustomerEmail.Text;
            string customerPhoneNo = textCustomerPhone.Text;
            string customerPassword = textCustomerPassword.Text;

            if (String.IsNullOrEmpty(customer_name) || String.IsNullOrEmpty(customerPhoneNo) || String.IsNullOrEmpty(customerEmail) || String.IsNullOrEmpty(customerPassword))
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
                    customerPhone = customerPhoneNo,
                    customerPassword = customerPassword
                };

                // Guardar el nuevo cliente en la base de datos utilizando el DAO genérico
                _customerDAO.Insert(newCustomer);

                MessageBox.Show("Customer added successfully!");
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}