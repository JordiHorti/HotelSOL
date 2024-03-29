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

namespace HotelSOL.Forms
{
    public partial class InvoiceForm : Form
    {

        private IDAO<Invoice> _invoiceDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;
        public InvoiceForm()
        {
            InitializeComponent();

            myConfiguration = new Configuration()
            .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Invoice.hbn.xml");
            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _invoiceDAO = new DAOimpl<Invoice>(mySessionFactory.OpenSession());
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            CargaDatos cargadatos = new CargaDatos();
            cargadatos.uploadInvoices();
            showDataInvoices();
        }

        private void showDataInvoices()
        {
            try
            {
                // Obtener todos los clientes utilizando el DAO 
                IList<Invoice> invoices = _invoiceDAO.GetAll();

                // Mostrar los clientes en el DataGridView
                dataGridViewAllInvoices.DataSource = invoices;
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonExport_Click_1(object sender, EventArgs e)
        {
            CargaDatos cargaDatos = new CargaDatos();
            cargaDatos.ExportarDatosAXml("invoices", "data_invoices");

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string textToSearch = textBoxSearch.Text;
            bool invoiceId = radioButtonIdentity.Checked;
            bool customer_Name = radioButtonCustomerName.Checked;
            bool customer_Email = radioButtonCustomerEmail.Checked;

            CargaDatos cargaDatos = new CargaDatos();

            cargaDatos.uploadBookings();

            if (invoiceId)
            {
                MessageBox.Show("Email search selected");



                try
                {
                    using (ISession mySession = mySessionFactory.OpenSession())
                    {
                        dataGridViewAllInvoices.Columns.Clear();

                        // Crear una consulta HQL para buscar clientes por nombre
                        string hqlQuery = "FROM Invoice WHERE invoices_id LIKE :id";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetString("id", "%" + textToSearch + "%");

                        // Obtener los resultados de la consulta
                        IList<Invoice> invoices = query.List<Invoice>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewAllInvoices.DataSource = invoices;

                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (customer_Name)
            {

                try
                {
                    using (ISession mySession = mySessionFactory.OpenSession())
                    {
                        dataGridViewAllInvoices.Columns.Clear();


                        // Crear una consulta HQL para buscar clientes por nombre
                        string hqlQuery = "FROM Invoice WHERE customerName LIKE :name";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetString("name", "%" + textToSearch + "%");

                        // Obtener los resultados de la consulta
                        IList<Invoice> invoices = query.List<Invoice>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewAllInvoices.DataSource = invoices;

                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (customer_Email)
            {
                try
                {

                    using (ISession mySession = mySessionFactory.OpenSession())
                    {
                        // Crear una consulta HQL para buscar clientes por teléfono
                        string hqlQuery = "FROM Invoicegit  WHERE customerEmail LIKE :email";

                        // Ejecutar la consulta utilizando NHibernate
                        IQuery query = mySession.CreateQuery(hqlQuery);
                        query.SetString("email", "%" + textToSearch + "%");

                        // Obtener los resultados de la consulta
                        IList<Invoice> invoices = query.List<Invoice>();

                        // Llenar el DataGridView con los resultados
                        dataGridViewAllInvoices.DataSource = invoices;
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Connection Error: {ex.Message}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void dataGridViewAllInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {
            CargaDatos cargaDatos = new CargaDatos();
            cargaDatos.importDataInvoicesToDatabase();
        }
    }
}
