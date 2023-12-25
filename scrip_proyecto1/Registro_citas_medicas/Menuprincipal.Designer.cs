namespace Registro_citas_medicas
{
    partial class Menuprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuprincipal));
            this.menuprin = new System.Windows.Forms.MenuStrip();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeResportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendacionDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicinaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortodonciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuprin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuprin
            // 
            this.menuprin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuprin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuprin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuprin.Location = new System.Drawing.Point(0, 0);
            this.menuprin.Name = "menuprin";
            this.menuprin.Size = new System.Drawing.Size(800, 30);
            this.menuprin.TabIndex = 3;
            this.menuprin.Text = "menuprincipal";
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificacionToolStripMenuItem,
            this.eliminacionToolStripMenuItem});
            this.datosPersonalesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosPersonalesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.modificacionToolStripMenuItem.Text = "Modificación";
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionToolStripMenuItem_Click);
            // 
            // eliminacionToolStripMenuItem
            // 
            this.eliminacionToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.eliminacionToolStripMenuItem.Name = "eliminacionToolStripMenuItem";
            this.eliminacionToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.eliminacionToolStripMenuItem.Text = "Eliminación";
            this.eliminacionToolStripMenuItem.Click += new System.EventHandler(this.eliminacionToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.agendacionDeCitasToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeConexionToolStripMenuItem,
            this.consultaDeResportesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeConexionToolStripMenuItem
            // 
            this.consultaDeConexionToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.consultaDeConexionToolStripMenuItem.Name = "consultaDeConexionToolStripMenuItem";
            this.consultaDeConexionToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.consultaDeConexionToolStripMenuItem.Text = "Consulta de Conexion";
            this.consultaDeConexionToolStripMenuItem.Click += new System.EventHandler(this.consultaDeConexionToolStripMenuItem_Click);
            // 
            // consultaDeResportesToolStripMenuItem
            // 
            this.consultaDeResportesToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.consultaDeResportesToolStripMenuItem.Name = "consultaDeResportesToolStripMenuItem";
            this.consultaDeResportesToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.consultaDeResportesToolStripMenuItem.Text = "Consulta de Resportes";
            this.consultaDeResportesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeResportesToolStripMenuItem_Click);
            // 
            // agendacionDeCitasToolStripMenuItem
            // 
            this.agendacionDeCitasToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.agendacionDeCitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicinaGeneralToolStripMenuItem,
            this.ortodonciaToolStripMenuItem});
            this.agendacionDeCitasToolStripMenuItem.Name = "agendacionDeCitasToolStripMenuItem";
            this.agendacionDeCitasToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.agendacionDeCitasToolStripMenuItem.Text = "Agendacion de Citas";
            // 
            // medicinaGeneralToolStripMenuItem
            // 
            this.medicinaGeneralToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.medicinaGeneralToolStripMenuItem.Name = "medicinaGeneralToolStripMenuItem";
            this.medicinaGeneralToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.medicinaGeneralToolStripMenuItem.Text = "Medicina General";
            this.medicinaGeneralToolStripMenuItem.Click += new System.EventHandler(this.medicinaGeneralToolStripMenuItem_Click);
            // 
            // ortodonciaToolStripMenuItem
            // 
            this.ortodonciaToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.ortodonciaToolStripMenuItem.Name = "ortodonciaToolStripMenuItem";
            this.ortodonciaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.ortodonciaToolStripMenuItem.Text = "Ortodoncia";
            this.ortodonciaToolStripMenuItem.Click += new System.EventHandler(this.ortodonciaToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuprin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menuprincipal";
            this.Text = "Menuprincipal";
            this.menuprin.ResumeLayout(false);
            this.menuprin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuprin;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendacionDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeConexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeResportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicinaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortodonciaToolStripMenuItem;
    }
}