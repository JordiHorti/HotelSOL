import xml.etree.ElementTree as et
import xmlrpc.client

db = "HotelSOL"
port = "5432"
username = "alberto-1993@hotmail.es"
password = "Cataroloko01"
registros = []

def import_customers():
    global registros
    ruta_archivo = "C:/Users/alber/OneDrive/Escritorio/aHotelSOL/HotelSOL/Mapping/data_customer.xml"
    
    try:
        tree = et.parse(ruta_archivo)
    except FileNotFoundError:
        print("El archivo XML especificado no se encuentra.")
        return registros
    except et.ParseError:
        print("Error al parsear el archivo XML.")
        return registros
        
    root = tree.getroot()

    for customer in root.findall('customers')[:3]:
        registro = {}

        customer_id = int(customer.find("customer_id").text)
        name = customer.find("customerName").text
        correo = customer.find("customerEmail").text
        phone = customer.find("customerPhone").text
        password = customer.find("customerPassword").text

        # Verificar si el elemento <userEmail> existe antes de acceder a su texto
        correo_element = customer.find("customerEmail")
        correo = correo_element.text if correo_element is not None else ""

        # Almacenar los datos en un diccionario
        registro['customer_id'] = customer_id
        registro['name'] = name
        registro['correo'] = correo
        registro['phone'] = phone

        # Agregar el diccionario de datos al array registros
        registros.append(registro)
    
        print("Registro:")
        print(registro)

def conexion_odoo(db, username, password, registros):
    url = "http://localhost:8069"  # URL del servidor de Odoo
    
    # Crear los objetos para el servidor común y el servidor de objetos
    common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
    
    try:
        uid = common.authenticate(db, username, password, {})
    except xmlrpc.client.Fault as err:
        print("Error de conexi�nn:", err)
        return False

    # Verificar si la autenticación fue exitosa
    if uid:
        print("Conexión exitosa, UID:", uid)
        models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))
        
        # Iterar sobre los registros y agregarlos a la tabla 'users' en Odoo
        for registro in registros:
            vals = {
                'id': registro['customer_id'],
                'name': registro['name'],
                'email': registro['correo'], 
                'phone': registro['phone'],
            }
            try:
                models.execute_kw(db, uid, password, 'res.partner', 'create', [vals])
                print("Registro agregado exitosamente:", registro)
            except xmlrpc.client.Fault as err:
                print("Error al agregar el registro:", err)
        
        return True
    else:
        print("Fallo en la autenticación")
        return False

import_customers()
conexion_odoo(db, username, password, registros)
