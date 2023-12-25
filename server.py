import socket
import pyodbc
import datetime
# Datos de conexión a SQL Server
server = 'GENESIS'  # Nombre del servidor
database = 'Proyec1'  # Nombre de la base de datos
# Configurar la conexión a SQL Server
def conectar_db():
    try:
        connection = pyodbc.connect(
            f'DRIVER={{SQL Server}};SERVER={server};DATABASE={database};Trusted_Connection=yes'
        )
        return connection
    except pyodbc.Error as ex:
        print('Error al conectarse a la base de datos:', ex)
        return None
# Función para manejar una solicitud de cliente
def handle_client(client_socket):
    try:
        data = client_socket.recv(1024)
        if data:
            message = data.decode("utf-8")
            print(f"Received from client: {message}")
            # Dividir los datos en partes
            datos = message.split(",")
            response = None  # Inicialización con un valor predeterminado
            if datos[0] == "CONSULTAR_CITAS" and len(datos) == 2:
                cedula = datos[1].strip()  # Asignar la cédula
                # Realizar la consulta en la base de datos para obtener registros específicos de la tabla Citas
                citas = consultar_citas(cedula)
                if isinstance(citas, list):
                    # Convierte los datos de las citas en una cadena separada por comas
                    response = "\n".join([",".join(map(str, fila)) for fila in citas])
                else:
                    response = citas
            elif datos[0] == "REGISTRAR_CITA" and len(datos) == 7:
                    cedula, establecimiento, servicio, especialidad, fecha, hora = datos[1:]
                    cedula = cedula.strip()
                    establecimiento = establecimiento.strip()
                    servicio = servicio.strip()
                    especialidad = especialidad.strip()
                    fecha = fecha.strip()
                    hora = hora.strip()
                    # Aquí puedes realizar la inserción en la tabla "Citas" de la base de datos
                    if registrar_cita(cedula, establecimiento, servicio, especialidad, fecha, hora):
                        response = "Cita registrada con éxito"
                    else:
                        response = "Error al registrar la cita"
            elif len(datos) == 7:
                cedula, nombre, apellido1, apellido2, telefono, email, contraseña = datos
                # Modificar los datos en la base de datos "Usuarios"
                if modificar_registro(cedula, nombre, apellido1, apellido2, telefono, email, contraseña):
                    response = "Datos modificados exitosamente"
                else:
                    response = "Error al modificar los datos del usuario"
            elif datos[0] == "ELIMINAR" and len(datos) == 2:
                cedula = datos[1].strip()
                # Eliminar el usuario en la base de datos "Usuarios"
                if eliminar_usuario(cedula):
                    response = "Eliminación exitosa"
                else:
                    response = "Error al eliminar el usuario"
            elif len(datos) == 2:
                cedula, contraseña = datos
                cedula = cedula.strip()
                contraseña = contraseña.strip()
                # Validar credenciales en la base de datos "Login"
                if validar_credenciales(cedula, contraseña):
                    response = "Inicio de sesión exitoso"
                    # Registra la marca de tiempo en la tabla "Inicio"
                    registrar_accion(cedula)
                else:
                    response = "Credenciales incorrectas"
            elif datos[0] == "INSERTAR" and len(datos) == 8:
                cedula, nombre, apellido1, apellido2, telefono, email, contraseña = datos[1:]
                cedula = cedula.strip()
                contraseña = contraseña.strip()
                # Insertar el nuevo usuario en la base de datos "Usuarios"
                if insertar_datos_en_db(cedula, nombre, apellido1, apellido2, telefono, email, contraseña):
                    response = "Inserción exitosa"
                else:
                    response = "Error al insertar el usuario"
            elif datos[0] == "CONSULTAR" and len(datos) == 1:
                # Realiza la consulta en la tabla "Inicio" para obtener los datos
                datos_consulta = consultar_datos_inicio_sesion()
                if isinstance(datos_consulta, str):
                    # Si los datos de consulta son una cadena (string), simplemente asigna esa cadena a response
                    response = datos_consulta
                elif isinstance(datos_consulta, list):
                    # Si los datos de consulta son una lista, conviértelos a una cadena separada por comas
                    response = "\n".join([",".join(map(str, fila)) for fila in datos_consulta])
                else:
                    # En caso de otro tipo de datos o error, devuelve un mensaje adecuado
                    response = "Error en la consulta de datos de inicio de sesión"
            else:
                response = "Solicitud no válida"  # Agrega una respuesta para solicitudes no válidas
            
            client_socket.send(response.encode("utf-8"))
        else:
            print("No se recibieron datos del cliente")
    except Exception as e:
        print('Error al procesar los datos:', e)
    finally:
        client_socket.close()
# Verificar las credenciales en la base de datos
def validar_credenciales(cedula, contraseña):
    connection = conectar_db()
    if connection:
        try:
            cursor = connection.cursor()
            cursor.execute(
                'SELECT * FROM Login WHERE Cedula = ? AND Contraseña = ?',
                cedula, contraseña
            )
            row = cursor.fetchone()
            if row:
                # Las credenciales son válidas, registra la marca de tiempo y la relaciona con el usuario
                registrar_accion(cedula)
                return True
            else:
                return False  # Las credenciales son incorrectas
        except pyodbc.Error as ex:
            print('Error al interactuar con la base de datos:', ex)
            return False  # Error en la consulta
        finally:
            connection.close()
    else:
        return False
# Función para insertar datos en la tabla "Usuarios"
def insertar_datos_en_db(cedula, nombre, apellido1, apellido2, telefono, email, contraseña):
    connection = conectar_db()
    if connection:
        try:
            cursor = connection.cursor()
            # Consulta SQL para insertar datos en la tabla "Usuarios"
            query = 'INSERT INTO Usuarios (Cedula, Nombre, Apellido1, Apellido2, Telefono, Email, Contraseña) VALUES (?, ?, ?, ?, ?, ?, ?)'
            cursor.execute(query,cedula, nombre, apellido1, apellido2, telefono, email, contraseña)
            connection.commit()
            print('Datos insertados correctamente en la tabla Usuarios.')
            return True
        except pyodbc.Error as ex:
            print('Error al interactuar con la base de datos:', ex)
            return False
        finally:
            connection.close()
    else:
        return False
# Función para modificar los datos de un usuario en la tabla "Usuarios"
def modificar_registro(cedula, nombre, apellido1, apellido2, telefono, email, contraseña):
    connection = conectar_db()
    if connection:
        try:
            cursor = connection.cursor()
            # Actualizar los datos en la tabla "Usuarios"
            cursor.execute(
                'UPDATE Usuarios SET Nombre = ?, Apellido1 = ?, Apellido2 = ?, Telefono = ?, Email = ?, Contraseña = ? WHERE Cedula = ?',
                nombre, apellido1, apellido2, telefono, email, contraseña, cedula
            )
            connection.commit()  # Confirmar la transacción
            print('Datos modificados correctamente en la tabla Usuarios.')
            return True  # Modificación exitosa
        except pyodbc.Error as ex:
            print('Error al interactuar con la base de datos:', ex)
            return False  # Error en la consulta
        finally:
            connection.close()
    else:
        return False  # Error en la conexión a la base de datos
# Función para eliminar un usuario en la base de datos "Usuarios"
def eliminar_usuario(cedula):
    connection = conectar_db()
    if connection:
        try:
            cursor = connection.cursor()
            # Eliminar el usuario de la tabla "Usuarios" usando la cédula
            cursor.execute('DELETE FROM Usuarios WHERE Cedula = ?', cedula)
            connection.commit()  # Confirmar la transacción
            print('Usuario eliminado correctamente en la tabla Usuarios.')
            return True  # Eliminación exitosa
        except pyodbc.Error as ex:
            print('Error al interactuar con la base de datos:', ex)
            return False  # Error en la consulta
        finally:
            connection.close()
    else:
        return False  # Error en la conexión a la base de datos
def registrar_accion(cedula):
    connection = conectar_db()
    if connection:
        try:
            cursor = connection.cursor()
            # Verificar si ya existe una entrada para el usuario en la tabla "Inicio"
            cursor.execute('SELECT Cedula FROM Inicio WHERE Cedula = ?', cedula)
            row = cursor.fetchone()
            if row:
                # Si existe, actualizar la marca de tiempo existente
                fecha_hora_actual = datetime.datetime.now()
                cursor.execute('UPDATE Inicio SET [Ultima Conexion] = ? WHERE Cedula = ?', fecha_hora_actual, cedula)
            else:
                # Si no existe, insertar una nueva fila con la marca de tiempo
                fecha_hora_actual = datetime.datetime.now()
                cursor.execute('INSERT INTO Inicio (Cedula, [Ultima Conexion]) VALUES (?, ?)', cedula, fecha_hora_actual)
            connection.commit()
            print('Marca de tiempo registrada/actualizada en la tabla Inicio.')
        except pyodbc.Error as ex:
            print('Error al interactuar con la base de datos:', ex)
        finally:
            connection.close()
def consultar_datos_inicio_sesion():
    try:
        # Conectar a la base de datos y realizar la consulta
        connection = conectar_db()
        if connection:
            cursor = connection.cursor()
            cursor.execute('SELECT Cedula, [Ultima Conexion] FROM Inicio')
            rows = cursor.fetchall()
            return rows  # Devuelve una lista de listas (filas de datos)
        else:
            return "Error en la conexión a la base de datos"
    except pyodbc.Error as ex:
        return f"Error en la consulta de datos de inicio de sesión: {str(ex)}"
# Función para registrar una cita en la tabla "Citas"
def registrar_cita(cedula, establecimiento, servicio, especialidad, fecha, hora):
    try:
        connection = conectar_db()
        if connection:
            cursor = connection.cursor()
            query = "INSERT INTO Citas (Cedula, [Establecimineto de Salud], Servicio, Especialidad, Fecha, Hora) VALUES (?, ?, ?, ?, ?, ?)"
            cursor.execute(query, cedula, establecimiento, servicio, especialidad, fecha, hora)
            connection.commit()
            connection.close()
            return True
        else:
            return False
    except pyodbc.Error as ex:
        print('Error al interactuar con la base de datos:', ex)
        return False
# Función para consultar las citas en la base de datos
def consultar_citas(cedula):
    try:
        # Conectar a la base de datos
        conn = conectar_db()  # Utiliza la función conectar_db() para obtener la conexión
        cursor = conn.cursor()
        
        # Realizar la consulta de citas para la cédula especificada
        cursor.execute("SELECT * FROM Citas WHERE Cedula = ?", str(cedula))
        citas = cursor.fetchall()
        
        # Cerrar la conexión a la base de datos
        conn.close()
        
        return citas
    except pyodbc.Error as ex:
        print(f"Error en la consulta de citas: {str(ex)}")
        return None
# Función principal para iniciar el servidor
def main():
    host = "127.0.0.1"
    port = 12346
    server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server.bind((host, port))
    server.listen(5)
    print(f"Server listening on {host}:{port}")
    while True:
        client_socket, addr = server.accept()
        print(f"Accepted connection from {addr[0]}:{addr[1]}")
        handle_client(client_socket)
if __name__ == "__main__":
    main()