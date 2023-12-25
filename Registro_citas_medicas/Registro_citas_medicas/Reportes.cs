using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_citas_medicas
{
    public partial class Reportes : Form
    {
        public Reportes()
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Obtener la cédula ingresada en el textbox
            string cedula = txtUsuario.Text.Trim();

            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 12346)) // Ajusta la dirección IP y el puerto según tu servidor
                {
                    // Obtener el flujo de red para enviar datos al servidor
                    NetworkStream stream = client.GetStream();

                    // Enviar la solicitud de consulta al servidor junto con la cédula
                    string dataToSend = $"CONSULTAR_CITAS,{cedula}"; // Comando para consulta y cédula
                    byte[] dataBytes = Encoding.UTF8.GetBytes(dataToSend);
                    stream.Write(dataBytes, 0, dataBytes.Length);

                    // Crear un búfer para recibir la respuesta del servidor
                    byte[] responseBytes = new byte[1024];
                    int bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);

                    string response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                    // Verificar si la respuesta no está vacía
                    if (!string.IsNullOrEmpty(response))
                    {
                        // Limpia el DataGridView antes de agregar nuevos datos
                        gdvConsultar.Rows.Clear();

                        // Divide la respuesta en filas
                        string[] rows = response.Split('\n');

                        foreach (string row in rows)
                        {
                            // Divide cada fila en columnas
                            string[] columns = row.Split(',');

                            // Verificar si la fila contiene suficientes columnas
                            if (columns.Length >= 6) // Asegura que haya al menos 6 columnas en los datos recibidos
                            {
                                // Agrega la fila al DataGridView
                                gdvConsultar.Rows.Add(columns);
                            }
                            else
                            {
                                // Si la fila no tiene suficientes columnas, muestra una advertencia
                                MessageBox.Show("Los datos recibidos tienen un formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La respuesta del servidor está vacía o en un formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Error de conexión al servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
