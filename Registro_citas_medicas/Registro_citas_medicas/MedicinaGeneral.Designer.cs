namespace Registro_citas_medicas
{
    partial class MedicinaGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicinaGeneral));
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.cbFecha = new System.Windows.Forms.ComboBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.menuprin = new System.Windows.Forms.MenuStrip();
            this.medicinaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbEstablecimientoS = new System.Windows.Forms.ComboBox();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuprin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHora
            // 
            this.cbHora.AutoCompleteCustomSource.AddRange(new string[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "No disponible"});
            this.cbHora.BackColor = System.Drawing.Color.LightBlue;
            this.cbHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "8:00:00",
            "8:30:00",
            "9:00:00",
            "9:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00"});
            this.cbHora.Location = new System.Drawing.Point(487, 277);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(248, 27);
            this.cbHora.TabIndex = 35;
            // 
            // cbFecha
            // 
            this.cbFecha.AutoCompleteCustomSource.AddRange(new string[] {
            "20 de septiembre 2023",
            "21 de septiembre 2023",
            "22 de septiembre 2023",
            "23 de septiembre 2023"});
            this.cbFecha.BackColor = System.Drawing.Color.LightBlue;
            this.cbFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFecha.FormattingEnabled = true;
            this.cbFecha.Items.AddRange(new object[] {
            "20-09-2023",
            "21-09-2023",
            "22-09-2023",
            "23-09-2023"});
            this.cbFecha.Location = new System.Drawing.Point(487, 244);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(248, 27);
            this.cbFecha.TabIndex = 34;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.BackColor = System.Drawing.Color.LightBlue;
            this.cbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEspecialidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "MedicinaGeneral"});
            this.cbEspecialidad.Location = new System.Drawing.Point(487, 211);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(248, 27);
            this.cbEspecialidad.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(296, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(544, 351);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(160, 33);
            this.BtnRegistrar.TabIndex = 31;
            this.BtnRegistrar.Text = "Registrar Cita";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.LightBlue;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(487, 118);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(249, 21);
            this.txtCedula.TabIndex = 30;
            this.txtCedula.Text = "Cedula";
            // 
            // menuprin
            // 
            this.menuprin.BackColor = System.Drawing.Color.LightBlue;
            this.menuprin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuprin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicinaGeneralToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuprin.Location = new System.Drawing.Point(0, 0);
            this.menuprin.Name = "menuprin";
            this.menuprin.Size = new System.Drawing.Size(777, 30);
            this.menuprin.TabIndex = 29;
            this.menuprin.Text = "menuprincipal";
            // 
            // medicinaGeneralToolStripMenuItem
            // 
            this.medicinaGeneralToolStripMenuItem.Name = "medicinaGeneralToolStripMenuItem";
            this.medicinaGeneralToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.medicinaGeneralToolStripMenuItem.Text = "Medicina General";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // cbEstablecimientoS
            // 
            this.cbEstablecimientoS.BackColor = System.Drawing.Color.LightBlue;
            this.cbEstablecimientoS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstablecimientoS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstablecimientoS.FormattingEnabled = true;
            this.cbEstablecimientoS.Items.AddRange(new object[] {
            "Ebais1",
            "Ebais2",
            "Ebais3",
            "HospitalMaxPeralta"});
            this.cbEstablecimientoS.Location = new System.Drawing.Point(487, 145);
            this.cbEstablecimientoS.Name = "cbEstablecimientoS";
            this.cbEstablecimientoS.Size = new System.Drawing.Size(248, 27);
            this.cbEstablecimientoS.TabIndex = 37;
            // 
            // cbServicio
            // 
            this.cbServicio.BackColor = System.Drawing.Color.LightBlue;
            this.cbServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Items.AddRange(new object[] {
            "Medicina"});
            this.cbServicio.Location = new System.Drawing.Point(487, 178);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(248, 27);
            this.cbServicio.TabIndex = 38;
            // 
            // MedicinaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 420);
            this.Controls.Add(this.cbServicio);
            this.Controls.Add(this.cbEstablecimientoS);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.menuprin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MedicinaGeneral";
            this.Text = "MedicinaGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuprin.ResumeLayout(false);
            this.menuprin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.ComboBox cbFecha;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.MenuStrip menuprin;
        private System.Windows.Forms.ToolStripMenuItem medicinaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbEstablecimientoS;
        private System.Windows.Forms.ComboBox cbServicio;
    }
}