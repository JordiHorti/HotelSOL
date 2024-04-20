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
using static System.Collections.Specialized.BitVector32;


namespace HotelSOL.Forms
{
    public partial class ReservasCliente : Form
    {

        private IDAO<Customer> _customerDAO;

        private IDAO<Invoice> _invoiceDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;
        public ReservasCliente()
        {
            InitializeComponent();
            myConfiguration = new Configuration()
                 .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Customers.hbn.xml")
                        .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Invoice.hbn.xml")
                                  .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Booking.hbn.xml");

            mySessionFactory = myConfiguration.BuildSessionFactory();

            using (ISession session = mySessionFactory.OpenSession())
            {
                // Inicializar DAO con la sesión obtenida del sessionFactory
                _customerDAO = new DAOimpl<Customer>(session);
                _invoiceDAO = new DAOimpl<Invoice>(session);
            }
        }

        private void buttonSearchCust_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustName.Text;
            string customerEmail = textCustEmail.Text;

            using (ISession session = mySessionFactory.OpenSession())
            {
                var invoiceDAO = new InvoiceDAO(session);
                var dataTable = invoiceDAO.GetInvoicesForCustomer(customerName, customerEmail);

                // Enlazar el DataTable al DataGridView
                dataGridViewSeaarchResult.DataSource = dataTable;
            }

        }
        private void dataGridViewSeaarchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                // Obtener el nombre y el correo electrónico del cliente de los cuadros de texto
                string customerName = textBoxCustName.Text;
                string customerEmail = textCustEmail.Text;

                using (ISession mySession = mySessionFactory.OpenSession())
                {
                    dataGridViewSeaarchResult.Columns.Clear();


                    // Crear una consulta HQL para buscar clientes por nombre y email
                    string hqlQuery = "FROM Booking WHERE customerEmail LIKE :customerEmail AND customerName LIKE :customerName ";

                    // Ejecutar la consulta utilizando NHibernate
                    IQuery query = mySession.CreateQuery(hqlQuery);
                    query.SetString("customerEmail", "%" + customerEmail + "%" + "customerName" + "%" + customerName + "%");

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

        private IList<Invoice> GetInvoicesByCustomerNameAndEmail(string customerName, string customerEmail)
        {

            IList<Invoice> allInvoices = _invoiceDAO.GetAll();

            // Verificar si hay algún cliente con el nombre y correo electrónico dados
            IList<Invoice> filteredInvoices = allInvoices.Where(invoice => invoice.customerName == customerName && invoice.customerEmail == customerEmail).ToList();

            return filteredInvoices;

        }

        private void ShowCustomerInvoices(IList<Invoice> invoices)
        {
            try
            {
               
                // Mostrar los clientes en el DataGridView
                dataGridViewSeaarchResult.DataSource = invoices;
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }

}
