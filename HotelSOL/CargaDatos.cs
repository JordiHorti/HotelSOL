using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Xml;

namespace HotelSOL
{
    public class CargaDatos
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        XmlReader xmlFile;
        string sql = "";


        public CargaDatos()
        {
            connection = new SqlConnection(connectionString);
        }
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

        public void importDataCustomerToDataBase()
        {
            try
            {
                // Load XML data
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\jordi\OneDrive\Escritorio\data_customer.xml");

                // Verificar si los datos ya existen
                if (doc.DocumentElement.HasChildNodes)
                {
                    connection.Open();

                    // Recorremos cada fila del XML
                    foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                    {
                        // Extraemos la información del XML
                        string customerName = node["customerName"].InnerText;
                        string customerEmail = node["customerEmail"].InnerText;
                        string customerPhone = node["customerPhone"].InnerText;
                        string customerPassword = node["customerPassword"].InnerText;

                        // Checkeamos si el cliente ya existe en la base de datos
                        string checkQuery = $"SELECT COUNT(*) FROM customers WHERE customerEmail = '{customerEmail}'";
                        command = new SqlCommand(checkQuery, connection);
                        int existingCount = (int)command.ExecuteScalar();

                        // Si no existe, lo insertamos
                        if (existingCount == 0)
                        {
                            string insertQuery = $"INSERT INTO customers (customerName, customerEmail, customerPhone, customerPassword) " +
                                                 $"VALUES ('{customerName}', '{customerEmail}', '{customerPhone}', '{customerPassword}')";

                            command = new SqlCommand(insertQuery, connection);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show($"Customer with email {customerEmail} already exists. Skipping insertion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Cerramos la conexión
                    connection.Close();

                    Console.WriteLine("Customers data imported successfully.");
                }
                else
                {
                    Console.WriteLine("No data found in the XML file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error importing customers data: {ex.Message}");
            }
        }

        public void importDataRoomsToDatabase()
        {
            try
            {
                // Load XML data
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\jordi\OneDrive\Escritorio\data_rooms.xml");

                // Verificar si los datos ya existen
                if (doc.DocumentElement.HasChildNodes)
                {
                    connection.Open();

                    // Recorrer cada fila del XML
                    foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                    {
                        // Extraer la información del XML
                        int roomNumber = int.Parse(node["roomNumber"].InnerText);
                        string roomType = node["roomType"].InnerText;
                        decimal price = decimal.Parse(node["price"].InnerText);
                        bool booked = bool.Parse(node["booked"].InnerText);
                        int roomCapacity = int.Parse(node["roomCapacity"].InnerText);
                        string roomSeason = node["roomSeason"].InnerText;
                        string roomDescription = node["roomDescription"].InnerText;

                        // Checkear si la habitación ya existe en la base de datos
                        string checkQuery = $"SELECT COUNT(*) FROM rooms WHERE roomNumber = {roomNumber}";
                        command = new SqlCommand(checkQuery, connection);
                        int existingCount = (int)command.ExecuteScalar();

                        // Si no existe, insertarla
                        if (existingCount == 0)
                        {
                            string insertQuery = $"INSERT INTO rooms (roomNumber, roomType, price, booked, roomCapacity, roomSeason, roomDescription) " +
                                $"VALUES ({roomNumber}, '{roomType}', {price}, '{booked}', {roomCapacity}, '{roomSeason}', '{roomDescription}')";

                            command = new SqlCommand(insertQuery, connection);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show($"Room with number {roomNumber} already exists. Skipping insertion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Cerrar la conexión
                    connection.Close();

                    MessageBox.Show("Rooms data imported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data found in the XML file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing rooms data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void importDataServicesToDatabase()
        {
            try
            {
                // Load XML data
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\jordi\OneDrive\Escritorio\data_services.xml");

                // Verificar si los datos ya existen
                if (doc.DocumentElement.HasChildNodes)
                {
                    connection.Open();

                    // Recorrer cada fila del XML
                    foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                    {
                        // Extraer la información del XML
                        string service = node["service"].InnerText;
                        decimal servicePrice;
                        if (!decimal.TryParse(node["servicePrice"].InnerText, out servicePrice))
                        {
                            MessageBox.Show($"Could not convert '{node["servicePrice"].InnerText}' to a decimal number for servicePrice. Skipping this row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue; // Saltar a la siguiente iteración del bucle
                        }

                        // Checkear si el servicio ya existe en la base de datos
                        string checkQuery = $"SELECT COUNT(*) FROM services WHERE service = '{service}'";
                        command = new SqlCommand(checkQuery, connection);
                        int existingCount = (int)command.ExecuteScalar();

                        // Si no existe, insertarlo
                        if (existingCount == 0)
                        {
                            string insertQuery = $"INSERT INTO services (service, servicePrice) VALUES ('{service}', {servicePrice})";
                            command = new SqlCommand(insertQuery, connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Services data imported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show($"Service '{service}' already exists. Skipping insertion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Cerrar la conexión
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("No data found in the XML file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing services data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void importDataInvoicesToDatabase()
        {
            try
            {
                // Load XML data
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\jordi\OneDrive\Escritorio\data_invoices.xml");

                // Verificar si los datos ya existen
                if (doc.DocumentElement.HasChildNodes)
                {
                    connection.Open();

                    // Recorrer cada factura en el XML
                    foreach (XmlNode invoiceNode in doc.DocumentElement.ChildNodes)
                    {
                        // Extraer la información del XML
                        int invoiceId = int.Parse(invoiceNode["invoices_id"].InnerText);
                        int bookingId = int.Parse(invoiceNode["bookings_id"].InnerText);
                        int customerId = int.Parse(invoiceNode["customer_id"].InnerText);
                        string customerName = invoiceNode["customerName"].InnerText;
                        string customerEmail = invoiceNode["customerEmail"].InnerText;
                        string customerPhone = invoiceNode["customerPhone"].InnerText;
                        int roomNumber = int.Parse(invoiceNode["roomNumber"].InnerText);
                        string roomType = invoiceNode["roomType"].InnerText;
                        int roomCapacity = int.Parse(invoiceNode["roomCapacity"].InnerText);
                        decimal roomPrice = decimal.Parse(invoiceNode["roomPrice"].InnerText);
                        string service = invoiceNode["service"].InnerText;
                        decimal servicePrice = decimal.Parse(invoiceNode["servicePrice"].InnerText);
                        DateTime checkIn = DateTime.Parse(invoiceNode["checkIn"].InnerText);
                        DateTime checkOut = DateTime.Parse(invoiceNode["checkOut"].InnerText);
                        int days = int.Parse(invoiceNode["days"].InnerText);
                        decimal totalPrice = decimal.Parse(invoiceNode["totalPrice"].InnerText);

                        // Comprobar si la factura ya existe en la base de datos
                        string checkQuery = $"SELECT COUNT(*) FROM invoices WHERE invoices_id = {invoiceId}";
                        command = new SqlCommand(checkQuery, connection);
                        int existingCount = (int)command.ExecuteScalar();

                        // Si no existe, insertarlo
                        if (existingCount == 0)
                        {
                            string insertQuery = $"INSERT INTO invoices ( bookings_id, customer_id, customerName, customerEmail, customerPhone, roomNumber, roomType, roomCapacity, roomPrice, service, servicePrice, checkIn, checkOut, days, totalPrice) " +
                                                 $"VALUES ({bookingId}, {customerId}, '{customerName}', '{customerEmail}', '{customerPhone}', {roomNumber}, '{roomType}', {roomCapacity}, {roomPrice}, '{service}', {servicePrice}, '{checkIn.ToString("yyyy-MM-dd HH:mm:ss")}', '{checkOut.ToString("yyyy-MM-dd HH:mm:ss")}', {days}, {totalPrice})";

                            command = new SqlCommand(insertQuery, connection);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show($"Invoice with ID {invoiceId} already exists. Skipping insertion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    MessageBox.Show("Invoices data imported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar la conexión
                    connection.Close();

                    
                }
                else
                {
                    MessageBox.Show("No data found in the XML file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing invoices data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void importDataUsersToDatabase()
        {
            try
            {
                // Load XML data
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\jordi\OneDrive\Escritorio\data_users.xml");

                // Verificar si los datos ya existen
                if (doc.DocumentElement.HasChildNodes)
                {
                    connection.Open();

                    // Recorrer cada fila
                    foreach (XmlNode userNode in doc.DocumentElement.ChildNodes)
                    {
                        // Extraer la información del XML
                        int userId = int.Parse(userNode["users_id"].InnerText);
                        int customerId = int.Parse(userNode["customer_id"].InnerText);
                        string userName = userNode["userName"].InnerText;
                        string userEmail = userNode["userEmail"].InnerText;
                        string userPassword = userNode["userPassword"].InnerText;
                        int userRole = int.Parse(userNode["user_role"].InnerText);

                        // Comprobar si el usuario ya existe en la base de datos
                        string checkQuery = $"SELECT COUNT(*) FROM users WHERE users_id = {userId}";
                        command = new SqlCommand(checkQuery, connection);
                        int existingCount = (int)command.ExecuteScalar();

                        // Si no existe, insertarlo
                        if (existingCount == 0)
                        {
                            string insertQuery = $"INSERT INTO users (users_id, customer_id, userName, userEmail, userPassword, user_role) " +
                                                 $"VALUES ({userId}, {customerId}, '{userName}', '{userEmail}', '{userPassword}', {userRole})";

                            command = new SqlCommand(insertQuery, connection);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show($"User with ID {userId} already exists. Skipping insertion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Cerrar la conexión
                    connection.Close();

                    MessageBox.Show("Users data imported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data found in the XML file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing users data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void importDataBookingsToDatabase()
        {
            try
            {
                // Load XML data
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\jordi\OneDrive\Escritorio\data_bookings.xml");

                // Verificar si los datos ya existen
                if (doc.DocumentElement.HasChildNodes)
                {
                    connection.Open();

                    // Recorrer cada fila
                    foreach (XmlNode bookingNode in doc.DocumentElement.ChildNodes)
                    {
                        // Extraer la información del XML
                        int bookingId = int.Parse(bookingNode["bookings_id"].InnerText);
                        int customerId = int.Parse(bookingNode["customer_id"].InnerText);
                        int serviceId = int.Parse(bookingNode["services_id"].InnerText);
                        string customerName = bookingNode["customerName"].InnerText;
                        string customerEmail = bookingNode["customerEmail"].InnerText;
                        int roomNumber = int.Parse(bookingNode["roomNumber"].InnerText);
                        string service = bookingNode["service"].InnerText;
                        DateTime checkIn = DateTime.Parse(bookingNode["checkIn"].InnerText);
                        DateTime checkOut = DateTime.Parse(bookingNode["checkOut"].InnerText);
                        int days = int.Parse(bookingNode["days"].InnerText);
                        decimal totalPrice = decimal.Parse(bookingNode["totalPrice"].InnerText);

                        // Comprobar si la reserva ya existe en la base de datos
                        string checkQuery = $"SELECT COUNT(*) FROM bookings WHERE bookings_id = {bookingId}";
                        command = new SqlCommand(checkQuery, connection);
                        int existingCount = (int)command.ExecuteScalar();

                        // Si no existe, insertarlo
                        if (existingCount == 0)
                        {
                            string insertQuery = $"INSERT INTO bookings ( customer_id, services_id, customerName, customerEmail, roomNumber, service, checkIn, checkOut, days, totalPrice) " +
                                                 $"VALUES ({customerId}, {serviceId}, '{customerName}', '{customerEmail}', {roomNumber}, '{service}', '{checkIn.ToString("yyyy-MM-dd HH:mm:ss")}', '{checkOut.ToString("yyyy-MM-dd HH:mm:ss")}', {days}, {totalPrice})";

                            command = new SqlCommand(insertQuery, connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Bookings data imported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Booking with ID {bookingId} already exists. Skipping insertion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Cerrar la conexión
                    connection.Close();

                   
                }
                else
                {
                    MessageBox.Show("No data found in the XML file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing bookings data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void uploadUsers()
        {
            try
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO users(customer_id, userName, userEmail, userPassword)
                        SELECT DISTINCT c.customer_id, c.customerName, c.customerEmail, c.customerPassword
                        FROM customers c
                        WHERE NOT EXISTS (
                            SELECT DISTINCT customer_id
                            FROM users u
                            WHERE u.customer_id = c.customer_id
                        );


                        UPDATE users
                        SET user_role = 
                            CASE 
                                WHEN userName = 'admin' THEN 1
                                WHEN userName = 'recep' THEN 3
                                ELSE 2 
                            END;";

                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Se actualizaron {rowsAffected} filas en la tabla 'users'.");

                    connection.Close(); // Cierra la conexión
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la query de carga en la tabla users: {ex.Message}");
            }
        }
        public void uploadBookingsBooked()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Abre la conexión

                    string query = @"
                                  UPDATE rooms
                                    SET booked = 
                                        CASE 
                                            WHEN roomNumber IN (
                                                SELECT DISTINCT roomNumber
                                                FROM bookings
                                                WHERE checkIn > GETDATE() 
                                            ) THEN 1
                                            ELSE 0
                                        END;";

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
        public void initialData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Abre la conexión

                    string query = @"          
                USE HotelSOL;

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'customers')
                BEGIN
                    CREATE TABLE customers (
                        customer_id INT IDENTITY(1,1) PRIMARY KEY,
                        customerName VARCHAR(100) NOT NULL,
                        customerEmail VARCHAR(100) NOT NULL,
                        customerPhone VARCHAR(20) NOT NULL,
                        customerPassword VARCHAR(100) NOT NULL
                    );
                END

                INSERT INTO customers (customerName, customerEmail, customerPhone, customerPassword)
                SELECT 'admin', 'admin@HotelSOL.com', '123-456-7890', '1234' WHERE NOT EXISTS (
                    SELECT 1 FROM customers WHERE customerEmail = 'admin@HotelSOL.com'
                )
                UNION ALL
                SELECT 'recep', 'recep@HotelSOL.com', '123-456-7890', '12' WHERE NOT EXISTS (
                    SELECT 1 FROM customers WHERE customerEmail = 'recep@HotelSOL.com'
                )
                UNION ALL
                SELECT 'pepito', 'rpepito@ejemplo', '123-456-7890', '1' WHERE NOT EXISTS (
                    SELECT 1 FROM customers WHERE customerEmail = 'rpepito@ejemplo'
                )
                UNION ALL
                SELECT 'Juan Pérez', 'juan@example.com', '123-456-7890', '1' WHERE NOT EXISTS (
                    SELECT 1 FROM customers WHERE customerEmail = 'juan@example.com'
                )
                UNION ALL
                SELECT 'Carlos Martínez', 'carlos@example.com', '987-654-3210', '1' WHERE NOT EXISTS (
                    SELECT 1 FROM customers WHERE customerEmail = 'carlos@example.com'
                )
                UNION ALL
                SELECT 'Ana López', 'ana@example.com', '987-654-3210', '1' WHERE NOT EXISTS (
                    SELECT 1 FROM customers WHERE customerEmail = 'ana@example.com'
                )
                UNION ALL
                SELECT 'Pedro Rodríguez', 'pedro@example.com', '987-654-3210', '1' WHERE NOT EXISTS (
                    SELECT 1 FROM customers WHERE customerEmail = 'pedro@example.com'
                )
                UNION ALL
                SELECT 'Laura Sánchez', 'laura@example.com', '987-654-3210', '1' WHERE NOT EXISTS (
                    SELECT 1 FROM customers WHERE customerEmail = 'laura@example.com'
                );


                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users')
                BEGIN
                CREATE TABLE users (
                    users_id INT IDENTITY(1,1) PRIMARY KEY,
                    customer_id INT,
                    userName NVARCHAR(100) NOT NULL,
                    userEmail NVARCHAR (100),
                    userPassword NVARCHAR(100) NOT NULL,
                    user_role INT CHECK (user_role IN (1,2,3))
                );
                END


                INSERT INTO users(customer_id, userName, userEmail, userPassword)
                SELECT DISTINCT c.customer_id, c.customerName, c.customerEmail, c.customerPassword
                FROM customers c
                WHERE NOT EXISTS (
                    SELECT DISTINCT customer_id
                    FROM users u
                    WHERE u.customer_id = c.customer_id
                );


                UPDATE users
                SET user_role = 
                    CASE 
                        WHEN userName = 'admin' THEN 1
                        WHEN userName = 'recep' THEN 3
                        ELSE 2 
                    END;


                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'rooms')
                BEGIN
                CREATE TABLE rooms (
                    rooms_id INT IDENTITY(1,1) PRIMARY KEY,
                    roomNumber INT UNIQUE NOT NULL,
                    roomType VARCHAR(20) NOT NULL CHECK (roomType IN ('Individual', 'Doble', 'Familiar', 'Suite')),
                    price DECIMAL(10, 2) NOT NULL,
                    booked BIT NOT NULL,
                    roomCapacity INT NOT NULL,
                    roomSeason VARCHAR(10) NOT NULL CHECK (roomSeason IN ('Alta', 'Media', 'Baja')),
                    roomDescription NVARCHAR(250)
                );
                END


                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'services')
                BEGIN
                CREATE TABLE services (
                    services_id INT IDENTITY(1,1) PRIMARY KEY,
                    service VARCHAR(100) NOT NULL,
                    servicePrice DECIMAL(10, 2) NOT NULL
                );
                END

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'bookings')
                BEGIN
                CREATE TABLE bookings (
                    bookings_id INT IDENTITY(1,1) PRIMARY KEY,
                    customer_id INT,
                    services_id INT NOT NULL,
                    customerName VARCHAR(100) NOT NULL,
                    customerEmail VARCHAR(100) NOT NULL,
                    roomNumber INT NOT NULL,
                    service VARCHAR(100),
                    checkIn DATE NOT NULL,
                    checkOut DATE NOT NULL,
                    days INT,
                    totalPrice DECIMAL(10, 2),
                );
                END

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'invoices')
                BEGIN
                CREATE TABLE invoices (
                    invoices_id INT IDENTITY(1,1) PRIMARY KEY,
                    bookings_id INT NOT NULL,
                    customer_id INT,
                    customerName VARCHAR(100),
                    customerEmail VARCHAR(100),
                    customerPhone VARCHAR(20),
                    roomNumber INT,
                    roomType VARCHAR(20),
                    roomCapacity INT,
                    roomPrice DECIMAL(10,2),
                    service VARCHAR(100),
                    servicePrice DECIMAL(10,2),
                    checkIn DATE,
                    checkOut DATE,
                    days INT,
                    totalPrice DECIMAL(10, 2),
                );
                END

                /*
                ---------------------------------------------
	                        INSERCION DE DATOS
                ---------------------------------------------
                INSERCION HABITACIONES
                */


                INSERT INTO rooms (roomNumber, roomType, price, booked, roomCapacity, roomSeason, roomDescription)
                SELECT 101, 'Individual', 100.00, 0, 1, 'Alta', N'Habitación individual con baño privado.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 101
                )
                UNION ALL
                SELECT 102, 'Doble', 150.00, 1, 2, 'Media', N'Habitación doble con vistas al mar.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 102
                )
                UNION ALL
                SELECT 103, 'Familiar', 250.00, 0, 4, 'Alta', N'Suite familiar con sala de estar.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 103
                )
                UNION ALL
                SELECT 104, 'Suite', 180.00, 1, 2, 'Baja', N'Suite de lujo con jacuzzi.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 104
                )
                UNION ALL
                SELECT 105, 'Individual', 120.00, 0, 1, 'Media', N'Habitación individual con balcón.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 105
                )
                UNION ALL
                SELECT 106, 'Doble', 90.00, 1, 2, 'Baja', N'Habitación doble estándar.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 106
                )
                UNION ALL
                SELECT 107, 'Familiar', 200.00, 0, 4, 'Media', N'Suite familiar con cocina americana.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 107
                )
                UNION ALL
                SELECT 108, 'Suite', 300.00, 1, 2, 'Alta', N'Suite de lujo con vistas panorámicas.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 108
                )
                UNION ALL
                SELECT 109, 'Individual', 80.00, 0, 1, 'Baja', N'Habitación individual económica.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 109
                )
                UNION ALL
                SELECT 110, 'Doble', 200.00, 1, 2, 'Alta', N'Habitación doble con terraza privada.' WHERE NOT EXISTS (
                    SELECT 1 FROM rooms WHERE roomNumber = 110
                );

                /* 
                INSERCION SERVICIOS
                */

                INSERT INTO services (service, servicePrice)
                SELECT 'Limpieza de habitación', 50.00 WHERE NOT EXISTS (
                    SELECT 1 FROM services WHERE service = 'Limpieza de habitación'
                )
                UNION ALL
                SELECT 'Desayuno buffet', 20.00 WHERE NOT EXISTS (
                    SELECT 1 FROM services WHERE service = 'Desayuno buffet'
                )
                UNION ALL
                SELECT 'Servicio de lavandería', 30.00 WHERE NOT EXISTS (
                    SELECT 1 FROM services WHERE service = 'Servicio de lavandería'
                )
                UNION ALL
                SELECT 'Transporte al aeropuerto', 50.00 WHERE NOT EXISTS (
                    SELECT 1 FROM services WHERE service = 'Transporte al aeropuerto'
                )
                UNION ALL
                SELECT 'Masaje relajante', 80.00 WHERE NOT EXISTS (
                    SELECT 1 FROM services WHERE service = 'Masaje relajante'
                )
                UNION ALL
                SELECT 'Alquiler de bicicletas', 15.00 WHERE NOT EXISTS (
                    SELECT 1 FROM services WHERE service = 'Alquiler de bicicletas'
                )
                UNION ALL
                SELECT 'Tour guiado por la ciudad', 70.00 WHERE NOT EXISTS (
                    SELECT 1 FROM services WHERE service = 'Tour guiado por la ciudad'
                )
                UNION ALL
                SELECT 'Acceso al spa', 60.00 WHERE NOT EXISTS (
                    SELECT 1 FROM services WHERE service = 'Acceso al spa'
                );

                /*
                    INSERCION RESERVAS
                */

                INSERT INTO bookings (services_id, customerName, customerEmail, roomNumber, checkIn, checkOut)
                SELECT 1, 'Juan Pérez', 'juan@example.com', 101, '2023-04-01', '2023-04-03' WHERE NOT EXISTS (
                    SELECT 1 FROM bookings WHERE customerEmail = 'juan@example.com' AND roomNumber = 101
                )
                UNION ALL
                SELECT 2, 'Carlos Martínez', 'carlos@example.com', 103, '2022-04-10', '2022-04-15' WHERE NOT EXISTS (
                    SELECT 1 FROM bookings WHERE customerEmail = 'carlos@example.com' AND roomNumber = 103
                )
                UNION ALL
                SELECT 3, 'Ana López', 'ana@example.com', 104, '2023-04-20', '2023-04-22' WHERE NOT EXISTS (
                    SELECT 1 FROM bookings WHERE customerEmail = 'ana@example.com' AND roomNumber = 104
                )
                UNION ALL
                SELECT 4, 'Pedro Rodríguez', 'pedro@example.com', 105, '2024-04-25', '2024-04-30' WHERE NOT EXISTS (
                    SELECT 1 FROM bookings WHERE customerEmail = 'pedro@example.com' AND roomNumber = 105
                )
                UNION ALL
                SELECT 5, 'Laura Sánchez', 'laura@example.com', 106, '2024-05-01', '2024-05-03' WHERE NOT EXISTS (
                    SELECT 1 FROM bookings WHERE customerEmail = 'laura@example.com' AND roomNumber = 106
                );


                /*
                ------------------------------------
                    ACTUALIZACION TABLA RESERVAS
                ------------------------------------
                */

                UPDATE b
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
                JOIN customers c ON b.customerName = c.customerName AND b.customerEmail = c.customerEmail;


                /*
                ------------------------------------
                    ACTUALIZACION TABLA HABITACIONES
                ------------------------------------
                */
                UPDATE rooms
                SET booked = 
                    CASE 
                        WHEN roomNumber IN (
                            SELECT DISTINCT roomNumber
                            FROM bookings
                            WHERE checkIn > GETDATE() 
                        ) THEN 1
                        ELSE 0
                    END;

                /*
                ------------------------------------
                    ACTUALIZACION TABLA FACTURAS
                ------------------------------------
                */
                TRUNCATE TABLE invoices;  -- Con este truncate evitamos duplicados

                INSERT INTO INVOICES (bookings_id)
                SELECT DISTINCT bookings_id FROM bookings

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
                INNER JOIN services s ON b.services_id = s.services_id
                ";

                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Se cargaron todos los datos de la bbdd.");

                    connection.Close(); // Cierra la conexión
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la query de carga de datos iniciales {ex.Message}");
            }

        }
    }
   
}