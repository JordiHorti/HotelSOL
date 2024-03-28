using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace HotelSOL
{
    public class CargaDatos
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public void ExportarDatosAXml(string nombreTabla, string nombreArchivo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM {nombreTabla}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, nombreTabla);

                    // Guardar los datos en un archivo XML en la ruta especificada
                    string rutaArchivo = @"C:\Users\jordi\OneDrive\Escritorio\" + $"{nombreArchivo}.xml";
                    dataSet.WriteXml(rutaArchivo);

                    Console.WriteLine($"Los datos de la tabla '{nombreTabla}' han sido exportados correctamente a '{rutaArchivo}'.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al exportar datos a XML: {ex.Message}");
            }
        }

        public void uploadBookings()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Abre la conexión

                    string query = @"
                                   UPDATE bookings
                                    SET 
                                        customer_id = c.customer_id,
                                        service = tmp.service,
                                        totalPrice = tmp.totalPrice,
                                        days = DATEDIFF(day, b.checkIn, b.checkOut)
                                    FROM bookings b
                                    JOIN (
                                        SELECT 
                                            b.bookings_id,
                                            s.service as service, 
                                            ((r.Price + s.servicePrice) * DATEDIFF(day, b.checkIn, b.checkOut)) as totalPrice
                                        FROM bookings b
                                        JOIN services s ON b.services_id = s.services_id
                                        JOIN rooms r ON b.roomNumber = r.roomNumber
                                    ) AS tmp ON b.bookings_id = tmp.bookings_id
                                    JOIN customers c ON b.customerName = c.customerName AND b.customerEmail = c.customerEmail;";

                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Se actualizaron {rowsAffected} filas en la tabla 'bookings'.");

                    connection.Close(); // Cierra la conexión
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la query en la tabla bookings: {ex.Message}");
            }
        }
        public void uploadInvoices()
        {
            try
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE invoices
                SET
                   customer_id = b.customer_id,
                   customerName = c.customerName,
                   customerEmail = c.customerEmail,
                   customerPhone = c.customerPhone,
                   roomNumber = r.roomNumber,
                   roomType = r.roomType,
                   roomCapacity = r.roomCapacity,
                   roomPrice = r.price,
                   service = s.service,
                   servicePrice = s.servicePrice,
                   checkIn = b.checkIn,
                   checkOut = b.checkOut,
                   days = b.days,
                   totalPrice = ((r.price + s.servicePrice) * b.days)
                FROM
                   invoices i
                INNER JOIN bookings b ON i.bookings_id = b.bookings_id
                INNER JOIN customers c ON b.customer_id = c.customer_id
                INNER JOIN rooms r ON b.roomNumber = r.roomNumber
                INNER JOIN services s ON b.services_id = s.services_id";

                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Se actualizaron {rowsAffected} filas en la tabla 'invoices'.");

                    connection.Close(); // Cierra la conexión
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la query en la tabla invoices: {ex.Message}");
            }
        }

    }
}
