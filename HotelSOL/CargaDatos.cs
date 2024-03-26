using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
