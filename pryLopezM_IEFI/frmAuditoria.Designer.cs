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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.panelAuditoria = new System.Windows.Forms.Panel();
            this.btnLimpiarAuditoria = new System.Windows.Forms.Button();
            this.imgAuditoria = new System.Windows.Forms.PictureBox();
            this.lblMostrarDatosFiltro = new System.Windows.Forms.Label();
            this.cmbOpcionesAuditoría = new System.Windows.Forms.ComboBox();
            this.lblMostrarDatosUsuarioFecha = new System.Windows.Forms.Label();
            this.dtpAuditoría = new System.Windows.Forms.DateTimePicker();
            this.optAccionesRealizadas = new System.Windows.Forms.RadioButton();
            this.optSesionUsuario = new System.Windows.Forms.RadioButton();
            this.btnBuscarUsuarioAuditoria = new System.Windows.Forms.Button();
            this.lblMostrarDatoPorID = new System.Windows.Forms.Label();
            this.lblAuditoriaInstrucciones = new System.Windows.Forms.Label();
            this.txtIdAuditoría = new System.Windows.Forms.TextBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTituloAuditoria = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.panelAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAuditoria)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AllowUserToAddRows = false;
            this.dgvAuditoria.AllowUserToDeleteRows = false;
            this.dgvAuditoria.AllowUserToResizeColumns = false;
            this.dgvAuditoria.AllowUserToResizeRows = false;
            this.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAuditoria.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuditoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuditoria.Location = new System.Drawing.Point(137, 490);
            this.dgvAuditoria.MultiSelect = false;
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuditoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuditoria.RowHeadersVisible = false;
            this.dgvAuditoria.Size = new System.Drawing.Size(756, 266);
            this.dgvAuditoria.TabIndex = 0;
            // 
            // panelAuditoria
            // 
            this.panelAuditoria.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelAuditoria.Controls.Add(this.btnLimpiarAuditoria);
            this.panelAuditoria.Controls.Add(this.imgAuditoria);
            this.panelAuditoria.Controls.Add(this.lblMostrarDatosFiltro);
            this.panelAuditoria.Controls.Add(this.cmbOpcionesAuditoría);
            this.panelAuditoria.Controls.Add(this.lblMostrarDatosUsuarioFecha);
            this.panelAuditoria.Controls.Add(this.dtpAuditoría);
            this.panelAuditoria.Controls.Add(this.optAccionesRealizadas);
            this.panelAuditoria.Controls.Add(this.optSesionUsuario);
            this.panelAuditoria.Controls.Add(this.btnBuscarUsuarioAuditoria);
            this.panelAuditoria.Controls.Add(this.lblMostrarDatoPorID);
            this.panelAuditoria.Controls.Add(this.lblAuditoriaInstrucciones);
            this.panelAuditoria.Controls.Add(this.txtIdAuditoría);
            this.panelAuditoria.Location = new System.Drawing.Point(49, 83);
            this.panelAuditoria.Name = "panelAuditoria";
            this.panelAuditoria.Size = new System.Drawing.Size(933, 388);
            this.panelAuditoria.TabIndex = 3;
            // 
            // btnLimpiarAuditoria
            // 
            this.btnLimpiarAuditoria.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarAuditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarAuditoria.FlatAppearance.BorderSize = 3;
            this.btnLimpiarAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarAuditoria.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAuditoria.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarAuditoria.Image")));
            this.btnLimpiarAuditoria.Location = new System.Drawing.Point(296, 327);
            this.btnLimpiarAuditoria.Name = "btnLimpiarAuditoria";
            this.btnLimpiarAuditoria.Size = new System.Drawing.Size(135, 50);
            this.btnLimpiarAuditoria.TabIndex = 20;
            this.btnLimpiarAuditoria.Text = "Limpiar";
            this.btnLimpiarAuditoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarAuditoria.UseVisualStyleBackColor = false;
            this.btnLimpiarAuditoria.Click += new System.EventHandler(this.btnLimpiarAuditoria_Click);
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
            // lblMostrarDatosFiltro
            // 
            this.lblMostrarDatosFiltro.AutoSize = true;
            this.lblMostrarDatosFiltro.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDatosFiltro.Location = new System.Drawing.Point(230, 210);
            this.lblMostrarDatosFiltro.Name = "lblMostrarDatosFiltro";
            this.lblMostrarDatosFiltro.Size = new System.Drawing.Size(198, 25);
            this.lblMostrarDatosFiltro.TabIndex = 18;
            this.lblMostrarDatosFiltro.Text = "Seleccione una opción";
            // 
            // cmbOpcionesAuditoría
            // 
            this.cmbOpcionesAuditoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesAuditoría.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOpcionesAuditoría.FormattingEnabled = true;
            this.cmbOpcionesAuditoría.Items.AddRange(new object[] {
            "Buscar por ID",
            "Buscar por fecha",
            "Buscar por ID y fecha"});
            this.cmbOpcionesAuditoría.Location = new System.Drawing.Point(428, 208);
            this.cmbOpcionesAuditoría.Name = "cmbOpcionesAuditoría";
            this.cmbOpcionesAuditoría.Size = new System.Drawing.Size(262, 33);
            this.cmbOpcionesAuditoría.TabIndex = 17;
            this.cmbOpcionesAuditoría.SelectedIndexChanged += new System.EventHandler(this.cmbOpcionesAuditoría_SelectedIndexChanged);
            // 
            // lblMostrarDatosUsuarioFecha
            // 
            this.lblMostrarDatosUsuarioFecha.AutoSize = true;
            this.lblMostrarDatosUsuarioFecha.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDatosUsuarioFecha.Location = new System.Drawing.Point(397, 254);
            this.lblMostrarDatosUsuarioFecha.Name = "lblMostrarDatosUsuarioFecha";
            this.lblMostrarDatosUsuarioFecha.Size = new System.Drawing.Size(61, 25);
            this.lblMostrarDatosUsuarioFecha.TabIndex = 16;
            this.lblMostrarDatosUsuarioFecha.Text = "Fecha";
            // 
            // dtpAuditoría
            // 
            this.dtpAuditoría.Enabled = false;
            this.dtpAuditoría.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAuditoría.Location = new System.Drawing.Point(402, 282);
            this.dtpAuditoría.Name = "dtpAuditoría";
            this.dtpAuditoría.Size = new System.Drawing.Size(329, 33);
            this.dtpAuditoría.TabIndex = 15;
            // 
            // optAccionesRealizadas
            // 
            this.optAccionesRealizadas.AutoSize = true;
            this.optAccionesRealizadas.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAccionesRealizadas.Image = ((System.Drawing.Image)(resources.GetObject("optAccionesRealizadas.Image")));
            this.optAccionesRealizadas.Location = new System.Drawing.Point(495, 160);
            this.optAccionesRealizadas.Name = "optAccionesRealizadas";
            this.optAccionesRealizadas.Size = new System.Drawing.Size(325, 42);
            this.optAccionesRealizadas.TabIndex = 14;
            this.optAccionesRealizadas.Text = "Acciones realizadas";
            this.optAccionesRealizadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.optAccionesRealizadas.UseVisualStyleBackColor = true;
            this.optAccionesRealizadas.CheckedChanged += new System.EventHandler(this.optAccionesRealizadas_CheckedChanged);
            // 
            // optSesionUsuario
            // 
            this.optSesionUsuario.AutoSize = true;
            this.optSesionUsuario.Checked = true;
            this.optSesionUsuario.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSesionUsuario.Image = ((System.Drawing.Image)(resources.GetObject("optSesionUsuario.Image")));
            this.optSesionUsuario.Location = new System.Drawing.Point(160, 160);
            this.optSesionUsuario.Name = "optSesionUsuario";
            this.optSesionUsuario.Size = new System.Drawing.Size(318, 42);
            this.optSesionUsuario.TabIndex = 13;
            this.optSesionUsuario.TabStop = true;
            this.optSesionUsuario.Text = "Sesiones de usuario";
            this.optSesionUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.optSesionUsuario.UseVisualStyleBackColor = true;
            this.optSesionUsuario.CheckedChanged += new System.EventHandler(this.optSesionUsuario_CheckedChanged);
            // 
            // btnBuscarUsuarioAuditoria
            // 
            this.btnBuscarUsuarioAuditoria.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarUsuarioAuditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarUsuarioAuditoria.FlatAppearance.BorderSize = 3;
            this.btnBuscarUsuarioAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuarioAuditoria.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuarioAuditoria.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuarioAuditoria.Image")));
            this.btnBuscarUsuarioAuditoria.Location = new System.Drawing.Point(458, 327);
            this.btnBuscarUsuarioAuditoria.Name = "btnBuscarUsuarioAuditoria";
            this.btnBuscarUsuarioAuditoria.Size = new System.Drawing.Size(212, 50);
            this.btnBuscarUsuarioAuditoria.TabIndex = 12;
            this.btnBuscarUsuarioAuditoria.Text = "Filtrar";
            this.btnBuscarUsuarioAuditoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUsuarioAuditoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarUsuarioAuditoria.UseVisualStyleBackColor = false;
            this.btnBuscarUsuarioAuditoria.Click += new System.EventHandler(this.btnBuscarUsuarioAuditoria_Click);
            // 
            // lblMostrarDatoPorID
            // 
            this.lblMostrarDatoPorID.AutoSize = true;
            this.lblMostrarDatoPorID.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDatoPorID.Location = new System.Drawing.Point(235, 254);
            this.lblMostrarDatoPorID.Name = "lblMostrarDatoPorID";
            this.lblMostrarDatoPorID.Size = new System.Drawing.Size(150, 25);
            this.lblMostrarDatoPorID.TabIndex = 11;
            this.lblMostrarDatoPorID.Text = "N° Identificador";
            // 
            // lblAuditoriaInstrucciones
            // 
            this.lblAuditoriaInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAuditoriaInstrucciones.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoriaInstrucciones.Location = new System.Drawing.Point(125, 13);
            this.lblAuditoriaInstrucciones.Name = "lblAuditoriaInstrucciones";
            this.lblAuditoriaInstrucciones.Size = new System.Drawing.Size(795, 139);
            this.lblAuditoriaInstrucciones.TabIndex = 3;
            this.lblAuditoriaInstrucciones.Text = resources.GetString("lblAuditoriaInstrucciones.Text");
            // 
            // txtIdAuditoría
            // 
            this.txtIdAuditoría.Enabled = false;
            this.txtIdAuditoría.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAuditoría.Location = new System.Drawing.Point(266, 283);
            this.txtIdAuditoría.Name = "txtIdAuditoría";
            this.txtIdAuditoría.Size = new System.Drawing.Size(80, 33);
            this.txtIdAuditoría.TabIndex = 8;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitulo.Controls.Add(this.lblTituloAuditoria);
            this.panelTitulo.Controls.Add(this.btnHome);
            this.panelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitulo.Location = new System.Drawing.Point(48, 17);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(254, 60);
            this.panelTitulo.TabIndex = 36;
            // 
            // lblTituloAuditoria
            // 
            this.lblTituloAuditoria.AutoSize = true;
            this.lblTituloAuditoria.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTituloAuditoria.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAuditoria.Location = new System.Drawing.Point(71, 4);
            this.lblTituloAuditoria.Name = "lblTituloAuditoria";
            this.lblTituloAuditoria.Size = new System.Drawing.Size(187, 47);
            this.lblTituloAuditoria.TabIndex = 35;
            this.lblTituloAuditoria.Text = "Auditorías";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Green;
            this.btnHome.FlatAppearance.BorderSize = 3;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(6, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 43);
            this.btnHome.TabIndex = 34;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 781);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelAuditoria);
            this.Controls.Add(this.dgvAuditoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.panelAuditoria.ResumeLayout(false);
            this.panelAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAuditoria)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Panel panelAuditoria;
        private System.Windows.Forms.TextBox txtIdAuditoría;
        private System.Windows.Forms.Label lblAuditoriaInstrucciones;
        private System.Windows.Forms.Button btnBuscarUsuarioAuditoria;
        private System.Windows.Forms.Label lblMostrarDatoPorID;
        private System.Windows.Forms.RadioButton optAccionesRealizadas;
        private System.Windows.Forms.RadioButton optSesionUsuario;
        private System.Windows.Forms.ComboBox cmbOpcionesAuditoría;
        private System.Windows.Forms.Label lblMostrarDatosUsuarioFecha;
        private System.Windows.Forms.DateTimePicker dtpAuditoría;
        private System.Windows.Forms.Label lblMostrarDatosFiltro;
        private System.Windows.Forms.PictureBox imgAuditoria;
        private System.Windows.Forms.Button btnLimpiarAuditoria;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloAuditoria;
        private System.Windows.Forms.Button btnHome;
    }
}