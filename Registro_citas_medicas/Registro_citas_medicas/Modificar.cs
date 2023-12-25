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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtUsuario.Text;
                string nombre = txtNombre.Text;
                string apellido1 = txtApellido.Text;
                string apellido2 = txtApellido2.Text;
                string telefono = txtTelefono.Text;
                string email = txtCorreo.Text;
                string nuevaContraseña = txtContraseña.Text;

                // Crear un cliente TCP para conectarse al servidor
                using (TcpClient client = new TcpClient("127.0.0.1", 12346)) // Ajusta la dirección IP y el puerto según tu servidor
                {
                    // Obtener el flujo de red para enviar datos al servidor
                    NetworkStream stream = client.GetStream();

                    // Crear una cadena que contiene los datos de modificación separados por comas
                    string dataToSend = $"{cedula},{nombre},{apellido1},{apellido2},{telefono},{email},{nuevaContraseña}";

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
                    if (response == "Modificación exitosa")
                    {
                        MessageBox.Show("Registro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Realizar acciones adicionales después de la modificación exitosa si es necesario
                    }
                    else
                    {
                        // Mostrar un mensaje de error si la respuesta no es "Modificación exitosa"
                        MessageBox.Show("Registro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Error: " + response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
