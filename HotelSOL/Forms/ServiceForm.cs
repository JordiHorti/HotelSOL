using HotelSOL.DAO;
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
using HotelSOL.DAO;
using NHibernate;
using NHibernate.Cfg;
using HotelSOL.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelSOL.Forms
{
    public partial class ServiceForm : Form
    {
        private IDAO<Service> _serviceDAO;

        private Configuration myConfiguration;

        private ISessionFactory mySessionFactory;

        public ServiceForm()
        {
            InitializeComponent();
            myConfiguration = new Configuration()
               .AddFile("C:\\Users\\jordi\\source\\repos\\HotelSOL\\HotelSOL\\Mapping\\Service.hbn.xml");
            mySessionFactory = myConfiguration.BuildSessionFactory();

            // Inicializar DAO con la sesión obtenida del sessionFactory
            _serviceDAO = new DAOimpl<Service>(mySessionFactory.OpenSession());
        }


        private void showDataService()
        {
            try
            {
                // Obtener todos los servicios utilizando el DAO 
                IList<Service> services = _serviceDAO.GetAll();

                if (services.Count > 0)
                {
                    // Mostrar los servicios en el DataGridView
                    dataGridViewAllServices.DataSource = services;
                }
                else
                {
                    MessageBox.Show("No se encontraron servicios para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string textToSearch = textBoxServiceId.Text;
            bool idServiceId = radioButtonIdentity.Checked;

            if (idServiceId)
            {
                MessageBox.Show("Identity search selected");
                // Intentar convertir el valor de textToSearch a int
                if (int.TryParse(textToSearch, out int serviceId))
                {

                    // Utilizar el método GetById con el ID convertido a int
                    Service service = _serviceDAO.GetById(serviceId);


                    // Verificar si se encontró el usuario
                    if (service != null)
                    {
                        dataGridViewSeaarchResult.Columns.Clear();
                        // Agregar las columnas necesarias si aún no están presentes
                        if (dataGridViewSeaarchResult.Columns.Count == 0)
                        {
                            dataGridViewSeaarchResult.Columns.Add("Column1", "Service ID");
                            dataGridViewSeaarchResult.Columns.Add("Column2", "Service");
                            dataGridViewSeaarchResult.Columns.Add("Column3", "Service Price");

                        }
                        dataGridViewSeaarchResult.Rows.Add(service.services_id, service.service, service.servicePrice);
                    }
                    else
                    {
                        MessageBox.Show($"No customer found with ID: {serviceId}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid customer ID");
                }

            }
        }

        private void dataGridViewAllServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDataService();
        }

        private void ServiceForm_Load_1(object sender, EventArgs e)
        {
            showDataService();
        }

        private void buttonInsertUser_Click(object sender, EventArgs e)
        {
            string serviceName = textBoxService.Text;
            string price = textBoxPrice.Text;

            if (String.IsNullOrEmpty(serviceName) || String.IsNullOrEmpty(price))
            {
                MessageBox.Show("No empty fields allowed");
                return;
            }

            try
            {
                // Crear un nuevo objeto servicio con los datos del formulario
                Service newService = new Service
                {

                    service = serviceName,
                    servicePrice = decimal.Parse(price)

                };

                // Guardar el nuevo servicios en la base de datos utilizando el DAO genérico
                _serviceDAO.Insert(newService);

                showDataService(); // Actualizar la visualización de los servicios en el formulario
                MessageBox.Show("Service added successfully!");

            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            string serviceId = textBoxServerId.Text;

            try
            {
                // Intentar convertir el ID del servicio a entero
                if (int.TryParse(serviceId, out int serviceID))
                {
                    // Utilizar el método GetById para obtener el servicio por su ID
                    Service serviceToDelete = _serviceDAO.GetById(serviceID);

                    if (serviceToDelete != null)
                    {
                        // Eliminar el servicio utilizando el método Delete del DAO
                        _serviceDAO.Delete(serviceToDelete);

                        MessageBox.Show("Service deleted successfully!");

                        // Actualizar la visualización de los servicios en el formulario
                        showDataService();
                    }
                    else
                    {
                        MessageBox.Show($"No service found with ID: {serviceID}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid service ID");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            CargaDatos cargaDatos = new CargaDatos();
            cargaDatos.ExportarDatosAXml("services", "data_services");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string serviceId = textBoxServerId.Text;
            string serviceName = textBoxService.Text;
            string price = textBoxPrice.Text;
            MessageBox.Show($"Service ID: {serviceId}");
            try
            {
                // Intentar convertir el ID del servicio a entero
                if (int.TryParse(serviceId, out int serviceID))
                {
                    // Utilizar el método GetById para obtener el servicio por su ID
                    Service serviceToUpdate = _serviceDAO.GetById(serviceID);

                    if (serviceToUpdate != null)
                    {
                        // Actualizar los datos del servicio con los nuevos valores del formulario
                        serviceToUpdate.service = textBoxService.Text;
                        serviceToUpdate.servicePrice = decimal.Parse(textBoxPrice.Text);

                        // Utilizar el método servicio del DAO para guardar los cambios
                        _serviceDAO.Update(serviceToUpdate);

                        MessageBox.Show("Servicio updated successfully!");

                        // Actualizar la visualización de los servicio en el formulario
                        showDataService();
                    }
                    else
                    {
                        MessageBox.Show($"No servicio found with ID: {serviceID}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid servicio ID");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {
            CargaDatos cargaDatos = new CargaDatos();
            cargaDatos.importDataServicesToDatabase();
        }
    }
}
