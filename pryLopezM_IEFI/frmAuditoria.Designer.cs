namespace pryLopezM_IEFI
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.dgvBBDDTablas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAuditoriaInstrucciones = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMostrarDatoPorID = new System.Windows.Forms.Label();
            this.btnBuscarUsuarioAuditoria = new System.Windows.Forms.Button();
            this.optSesionUsuario = new System.Windows.Forms.RadioButton();
            this.optAccionesRealizadas = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblMostrarDatosUsuarioFecha = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMostrarDatosFiltro = new System.Windows.Forms.Label();
            this.imgAuditoria = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDDTablas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBBDDTablas
            // 
            this.dgvBBDDTablas.AllowUserToAddRows = false;
            this.dgvBBDDTablas.AllowUserToDeleteRows = false;
            this.dgvBBDDTablas.AllowUserToResizeColumns = false;
            this.dgvBBDDTablas.AllowUserToResizeRows = false;
            this.dgvBBDDTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBBDDTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBBDDTablas.Location = new System.Drawing.Point(42, 423);
            this.dgvBBDDTablas.MultiSelect = false;
            this.dgvBBDDTablas.Name = "dgvBBDDTablas";
            this.dgvBBDDTablas.ReadOnly = true;
            this.dgvBBDDTablas.RowHeadersVisible = false;
            this.dgvBBDDTablas.Size = new System.Drawing.Size(933, 346);
            this.dgvBBDDTablas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.imgAuditoria);
            this.panel1.Controls.Add(this.lblMostrarDatosFiltro);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblMostrarDatosUsuarioFecha);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.optAccionesRealizadas);
            this.panel1.Controls.Add(this.optSesionUsuario);
            this.panel1.Controls.Add(this.btnBuscarUsuarioAuditoria);
            this.panel1.Controls.Add(this.lblMostrarDatoPorID);
            this.panel1.Controls.Add(this.lblAuditoriaInstrucciones);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(42, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 368);
            this.panel1.TabIndex = 3;
            // 
            // lblAuditoriaInstrucciones
            // 
            this.lblAuditoriaInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAuditoriaInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoriaInstrucciones.Location = new System.Drawing.Point(125, 13);
            this.lblAuditoriaInstrucciones.Name = "lblAuditoriaInstrucciones";
            this.lblAuditoriaInstrucciones.Size = new System.Drawing.Size(795, 104);
            this.lblAuditoriaInstrucciones.TabIndex = 3;
            this.lblAuditoriaInstrucciones.Text = resources.GetString("lblAuditoriaInstrucciones.Text");
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(291, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 29);
            this.textBox1.TabIndex = 8;
            // 
            // lblMostrarDatoPorID
            // 
            this.lblMostrarDatoPorID.AutoSize = true;
            this.lblMostrarDatoPorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDatoPorID.Location = new System.Drawing.Point(262, 232);
            this.lblMostrarDatoPorID.Name = "lblMostrarDatoPorID";
            this.lblMostrarDatoPorID.Size = new System.Drawing.Size(136, 24);
            this.lblMostrarDatoPorID.TabIndex = 11;
            this.lblMostrarDatoPorID.Text = "N° Identificador";
            // 
            // btnBuscarUsuarioAuditoria
            // 
            this.btnBuscarUsuarioAuditoria.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarUsuarioAuditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarUsuarioAuditoria.FlatAppearance.BorderSize = 3;
            this.btnBuscarUsuarioAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuarioAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuarioAuditoria.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuarioAuditoria.Image")));
            this.btnBuscarUsuarioAuditoria.Location = new System.Drawing.Point(395, 304);
            this.btnBuscarUsuarioAuditoria.Name = "btnBuscarUsuarioAuditoria";
            this.btnBuscarUsuarioAuditoria.Size = new System.Drawing.Size(120, 50);
            this.btnBuscarUsuarioAuditoria.TabIndex = 12;
            this.btnBuscarUsuarioAuditoria.Text = "Buscar";
            this.btnBuscarUsuarioAuditoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarUsuarioAuditoria.UseVisualStyleBackColor = false;
            // 
            // optSesionUsuario
            // 
            this.optSesionUsuario.AutoSize = true;
            this.optSesionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSesionUsuario.Image = ((System.Drawing.Image)(resources.GetObject("optSesionUsuario.Image")));
            this.optSesionUsuario.Location = new System.Drawing.Point(125, 132);
            this.optSesionUsuario.Name = "optSesionUsuario";
            this.optSesionUsuario.Size = new System.Drawing.Size(329, 37);
            this.optSesionUsuario.TabIndex = 13;
            this.optSesionUsuario.TabStop = true;
            this.optSesionUsuario.Text = "Sesiones de usuario";
            this.optSesionUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.optSesionUsuario.UseVisualStyleBackColor = true;
            // 
            // optAccionesRealizadas
            // 
            this.optAccionesRealizadas.AutoSize = true;
            this.optAccionesRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAccionesRealizadas.Image = ((System.Drawing.Image)(resources.GetObject("optAccionesRealizadas.Image")));
            this.optAccionesRealizadas.Location = new System.Drawing.Point(460, 132);
            this.optAccionesRealizadas.Name = "optAccionesRealizadas";
            this.optAccionesRealizadas.Size = new System.Drawing.Size(326, 37);
            this.optAccionesRealizadas.TabIndex = 14;
            this.optAccionesRealizadas.TabStop = true;
            this.optAccionesRealizadas.Text = "Acciones realizadas";
            this.optAccionesRealizadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.optAccionesRealizadas.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 29);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // lblMostrarDatosUsuarioFecha
            // 
            this.lblMostrarDatosUsuarioFecha.AutoSize = true;
            this.lblMostrarDatosUsuarioFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDatosUsuarioFecha.Location = new System.Drawing.Point(404, 232);
            this.lblMostrarDatosUsuarioFecha.Name = "lblMostrarDatosUsuarioFecha";
            this.lblMostrarDatosUsuarioFecha.Size = new System.Drawing.Size(64, 24);
            this.lblMostrarDatosUsuarioFecha.TabIndex = 16;
            this.lblMostrarDatosUsuarioFecha.Text = "Fecha";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buscar por ID",
            "Buscar por fecha",
            "Buscar por ID y fecha"});
            this.comboBox1.Location = new System.Drawing.Point(433, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 32);
            this.comboBox1.TabIndex = 17;
            // 
            // lblMostrarDatosFiltro
            // 
            this.lblMostrarDatosFiltro.AutoSize = true;
            this.lblMostrarDatosFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDatosFiltro.Location = new System.Drawing.Point(222, 188);
            this.lblMostrarDatosFiltro.Name = "lblMostrarDatosFiltro";
            this.lblMostrarDatosFiltro.Size = new System.Drawing.Size(205, 24);
            this.lblMostrarDatosFiltro.TabIndex = 18;
            this.lblMostrarDatosFiltro.Text = "Seleccione una opción";
            // 
            // imgAuditoria
            // 
            this.imgAuditoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgAuditoria.BackgroundImage")));
            this.imgAuditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAuditoria.Location = new System.Drawing.Point(12, 13);
            this.imgAuditoria.Name = "imgAuditoria";
            this.imgAuditoria.Size = new System.Drawing.Size(107, 104);
            this.imgAuditoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAuditoria.TabIndex = 19;
            this.imgAuditoria.TabStop = false;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 781);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBBDDTablas);
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDDTablas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAuditoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBBDDTablas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAuditoriaInstrucciones;
        private System.Windows.Forms.Button btnBuscarUsuarioAuditoria;
        private System.Windows.Forms.Label lblMostrarDatoPorID;
        private System.Windows.Forms.RadioButton optAccionesRealizadas;
        private System.Windows.Forms.RadioButton optSesionUsuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMostrarDatosUsuarioFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblMostrarDatosFiltro;
        private System.Windows.Forms.PictureBox imgAuditoria;
    }
}