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

                // Validar que se hayan proporcionado el nombre y el correo electrónico del cliente
                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerEmail))
                {
                    MessageBox.Show("Please enter customer name and email.");
                    return;
                }

                // Realizar la consulta a la base de datos para obtener las facturas del cliente
                using (ISession session = mySessionFactory.OpenSession())
                {
                    var query = session.QueryOver<Invoice>()
                                       .Where(x => x.customerName == customerName && x.customerEmail == customerEmail)
                                       .List();

                    // Mostrar las facturas en un nuevo formulario o en cualquier otro lugar de tu aplicación
                    ShowCustomerInvoices(query);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
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
