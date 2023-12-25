using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Registro_citas_medicas
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }
        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario de inicio de sesión
            this.Hide();

            // Crear una instancia del formulario de registro
            Modificar loginForm = new Modificar();

            // Mostrar el formulario de registro
            loginForm.Show();
        }
        private void eliminacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario de inicio de sesión
            this.Hide();

            // Crear una instancia del formulario de registro
            Eliminar loginForm = new Eliminar();

            // Mostrar el formulario de registro
            loginForm.Show();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sale de la aplicación
            Application.Exit();
        }
        private void consultaDeConexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario de inicio de sesión
            this.Hide();

            // Crear una instancia del formulario de registro
            Consultar loginForm = new Consultar();

            // Mostrar el formulario de registro
            loginForm.Show();
        }

        private void medicinaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario de inicio de sesión
            this.Hide();

            // Crear una instancia del formulario de registro
            MedicinaGeneral loginForm = new MedicinaGeneral();

            // Mostrar el formulario de registro
            loginForm.Show();
        }

        private void ortodonciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Oculta el formulario de inicio de sesión
            this.Hide();

            // Crear una instancia del formulario de registro
            Ortodolongía loginForm = new Ortodolongía();

            // Mostrar el formulario de registro
            loginForm.Show();
        }

        private void consultaDeResportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario de inicio de sesión
            this.Hide();

            // Crear una instancia del formulario de registro
            Reportes loginForm = new Reportes();

            // Mostrar el formulario de registro
            loginForm.Show();
        }
    }
}
