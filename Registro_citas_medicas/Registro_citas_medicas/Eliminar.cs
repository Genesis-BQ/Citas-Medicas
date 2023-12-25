using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_citas_medicas
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtUsuario.Text;

                // Crear un cliente TCP para conectarse al servidor
                using (TcpClient client = new TcpClient("127.0.0.1", 12346)) // Ajusta la dirección IP y el puerto según tu servidor
                {
                    // Obtener el flujo de red para enviar datos al servidor
                    NetworkStream stream = client.GetStream();

                    // Crear un mensaje que indique la acción de eliminación y la cédula del usuario
                    string dataToSend = $"ELIMINAR,{cedula}";

                    // Convertir la cadena en bytes
                    byte[] dataBytes = Encoding.UTF8.GetBytes(dataToSend);

                    // Enviar los datos al servidor
                    stream.Write(dataBytes, 0, dataBytes.Length);

                    // Crear un búfer para recibir la respuesta del servidor
                    byte[] responseBytes = new byte[1024];
                    int bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);

                    // Convertir la respuesta del servidor a una cadena
                    string response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                    // Cerrar la conexión con el servidor
                    client.Close();

                    // Verificar la respuesta del servidor y mostrar un mensaje
                    if (response == "Eliminación exitosa")
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Realizar acciones adicionales después de la eliminación exitosa si es necesario
                        // Sale de la aplicación
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario de inicio de sesión
            this.Hide();

            // Crear una instancia del formulario de registro
            Menuprincipal menuForm = new Menuprincipal();

            // Mostrar el formulario de registro
            menuForm.Show();
        }
    }
}
