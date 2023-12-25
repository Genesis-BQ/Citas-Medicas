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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un cliente TCP para conectarse al servidor
                using (TcpClient client = new TcpClient("127.0.0.1", 12346)) // Ajusta la dirección IP y el puerto según tu servidor
                {
                    // Obtener el flujo de red para enviar datos al servidor
                    NetworkStream stream = client.GetStream();

                    // Enviar la solicitud de consulta al servidor
                    string dataToSend = "CONSULTAR"; // Comando para consulta
                    byte[] dataBytes = Encoding.UTF8.GetBytes(dataToSend);
                    stream.Write(dataBytes, 0, dataBytes.Length);

                    // Crear un búfer para recibir la respuesta del servidor
                    byte[] responseBytes = new byte[1024];
                    int bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);

                    string response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                    // Verificar si la respuesta no está vacía
                    if (!string.IsNullOrEmpty(response))
                    {
                        // Divide la respuesta en filas
                        string[] rows = response.Split('\n');

                        // Limpiar el DataGridView antes de agregar nuevos datos
                        dgvConsultar.Rows.Clear();

                        foreach (string row in rows)
                        {
                            // Divide cada fila en columnas
                            string[] columns = row.Split(',');

                            // Verificar si la fila contiene suficientes columnas
                            if (columns.Length >= 2)
                            {
                                // Agregar la fila al DataGridView
                                dgvConsultar.Rows.Add(columns[0], columns[1]); // Asumiendo que las dos primeras columnas son las que deseas mostrar
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La respuesta del servidor está vacía o en un formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Cerrar la conexión con el servidor
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
