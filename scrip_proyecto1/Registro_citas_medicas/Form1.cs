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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string cedula = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            // Crear un cliente TCP para conectarse al servidor
            using (TcpClient client = new TcpClient("127.0.0.1", 12346)) // Ajusta la dirección IP y el puerto según tu servidor
            {
                // Obtener el flujo de red para enviar datos al servidor
                NetworkStream stream = client.GetStream();
                
                // Crear una cadena que contiene la cédula y la contraseña separadas por una coma
                string dataToSend = cedula + "," + contraseña;

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
                if (response == "Inicio de sesión exitoso")
                {
                    MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Aquí puedes realizar acciones adicionales después del inicio de sesión exitoso
                    //Oculta el formulario de inicio de sesión
                    this.Hide();

                    ////Guarda el tiempo de inicio de sesión
                    //tiempoInicioSesion = DateTime.Now;

                    //Crear una instancia del formulario de registro
                    Menuprincipal menuForm = new Menuprincipal();

                    //Mostrar el formulario de registro
                    menuForm.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Por favor, verifica tu cédula y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Oculta el formulario de inicio de sesión
            this.Hide();

            // Crear una instancia del formulario de registro
            Registro registroForm = new Registro();

            // Mostrar el formulario de registro
            registroForm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}