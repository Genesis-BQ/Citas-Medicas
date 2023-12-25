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
    public partial class MedicinaGeneral : Form
    {
        public MedicinaGeneral()
        {
            InitializeComponent();
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
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos de la cita desde los controles de la interfaz de usuario
                string cedula = txtCedula.Text;
                string establecimiento = cbEstablecimientoS.SelectedItem.ToString();
                string servicio = cbServicio.SelectedItem.ToString();
                string especialidad = cbEspecialidad.SelectedItem.ToString();
                string fecha = cbFecha.SelectedItem.ToString();
                string hora = cbHora.SelectedItem.ToString();
                // Formatear los datos para asegurarse de que cumplan con el formato esperado
                cedula = cedula.Trim();
                establecimiento = establecimiento.Trim();
                servicio = servicio.Trim();
                especialidad = especialidad.Trim();
                fecha = fecha.Trim();
                hora = hora.Trim();
                // Componer el mensaje para enviar al servidor
                string mensaje = $"REGISTRAR_CITA,{cedula},{establecimiento},{servicio},{especialidad},{fecha},{hora}";

                // Crear un cliente TCP para conectarse al servidor
                using (TcpClient client = new TcpClient("127.0.0.1", 12346)) // Ajusta la dirección IP y el puerto según tu servidor
                {
                    // Obtener el flujo de red para enviar datos al servidor
                    NetworkStream stream = client.GetStream();

                    // Convertir el mensaje en bytes
                    byte[] dataBytes = Encoding.UTF8.GetBytes(mensaje);

                    // Enviar los datos al servidor
                    stream.Write(dataBytes, 0, dataBytes.Length);

                    // Crear un búfer para recibir la respuesta del servidor
                    byte[] responseBytes = new byte[1024];
                    int bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);

                    // Convertir la respuesta del servidor a una cadena
                    string response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                    // Cerrar la conexión con el servidor
                    client.Close();

                    // Mostrar la respuesta del servidor
                    MessageBox.Show(response, "Respuesta del servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
