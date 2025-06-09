namespace pryLopezM_IEFI
{
    partial class frmRegistrarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarTarea));
            this.lblFechaTarea = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblLugarTarea = new System.Windows.Forms.Label();
            this.dtpFechaTarea = new System.Windows.Forms.DateTimePicker();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.cmbLugarTarea = new System.Windows.Forms.ComboBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.lblUniformeTarea = new System.Windows.Forms.Label();
            this.mrcDetalleTarea = new System.Windows.Forms.GroupBox();
            this.chkSalarioTarea = new System.Windows.Forms.CheckBox();
            this.chkReciboTarea = new System.Windows.Forms.CheckBox();
            this.lblReclamoTarea = new System.Windows.Forms.Label();
            this.chkEstudioTarea = new System.Windows.Forms.CheckBox();
            this.chkVacacionTarea = new System.Windows.Forms.CheckBox();
            this.lblLicenciaTarea = new System.Windows.Forms.Label();
            this.chkInsumo = new System.Windows.Forms.CheckBox();
            this.btnGrabarTarea = new System.Windows.Forms.Button();
            this.txtComentarioTarea = new System.Windows.Forms.TextBox();
            this.lblComentarioTarea = new System.Windows.Forms.Label();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAuditoriaInstrucciones = new System.Windows.Forms.Label();
            this.imgRegistrarTarea = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTituloRegistrarTarea = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.mrcDetalleTarea.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRegistrarTarea)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaTarea
            // 
            this.lblFechaTarea.AutoSize = true;
            this.lblFechaTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTarea.Location = new System.Drawing.Point(23, 16);
            this.lblFechaTarea.Name = "lblFechaTarea";
            this.lblFechaTarea.Size = new System.Drawing.Size(82, 21);
            this.lblFechaTarea.TabIndex = 0;
            this.lblFechaTarea.Text = "Fecha:";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(335, 9);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(80, 21);
            this.lblTarea.TabIndex = 1;
            this.lblTarea.Text = "Tarea:";
            // 
            // lblLugarTarea
            // 
            this.lblLugarTarea.AutoSize = true;
            this.lblLugarTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarTarea.Location = new System.Drawing.Point(478, 9);
            this.lblLugarTarea.Name = "lblLugarTarea";
            this.lblLugarTarea.Size = new System.Drawing.Size(82, 21);
            this.lblLugarTarea.TabIndex = 2;
            this.lblLugarTarea.Text = "Lugar:";
            // 
            // dtpFechaTarea
            // 
            this.dtpFechaTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaTarea.Location = new System.Drawing.Point(26, 40);
            this.dtpFechaTarea.MinDate = new System.DateTime(1769, 1, 1, 0, 0, 0, 0);
            this.dtpFechaTarea.Name = "dtpFechaTarea";
            this.dtpFechaTarea.Size = new System.Drawing.Size(288, 22);
            this.dtpFechaTarea.TabIndex = 3;
            // 
            // cmbTarea
            // 
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Items.AddRange(new object[] {
            "Auditoría",
            "Consultas",
            "Inspección",
            "Reclamos",
            "Visita"});
            this.cmbTarea.Location = new System.Drawing.Point(339, 33);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(121, 29);
            this.cmbTarea.TabIndex = 4;
            this.cmbTarea.SelectedIndexChanged += new System.EventHandler(this.cmbTarea_SelectedIndexChanged);
            // 
            // cmbLugarTarea
            // 
            this.cmbLugarTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugarTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLugarTarea.FormattingEnabled = true;
            this.cmbLugarTarea.Items.AddRange(new object[] {
            "Empresa",
            "Servicio",
            "Oficina"});
            this.cmbLugarTarea.Location = new System.Drawing.Point(482, 33);
            this.cmbLugarTarea.Name = "cmbLugarTarea";
            this.cmbLugarTarea.Size = new System.Drawing.Size(121, 29);
            this.cmbLugarTarea.TabIndex = 5;
            this.cmbLugarTarea.SelectedIndexChanged += new System.EventHandler(this.cmbLugarTarea_SelectedIndexChanged);
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeColumns = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTareas.GridColor = System.Drawing.Color.White;
            this.dgvTareas.Location = new System.Drawing.Point(12, 494);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(1179, 216);
            this.dgvTareas.TabIndex = 6;
            // 
            // lblUniformeTarea
            // 
            this.lblUniformeTarea.AutoSize = true;
            this.lblUniformeTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniformeTarea.Location = new System.Drawing.Point(6, 24);
            this.lblUniformeTarea.Name = "lblUniformeTarea";
            this.lblUniformeTarea.Size = new System.Drawing.Size(77, 15);
            this.lblUniformeTarea.TabIndex = 7;
            this.lblUniformeTarea.Text = "Uniforme";
            // 
            // mrcDetalleTarea
            // 
            this.mrcDetalleTarea.Controls.Add(this.chkSalarioTarea);
            this.mrcDetalleTarea.Controls.Add(this.chkReciboTarea);
            this.mrcDetalleTarea.Controls.Add(this.lblReclamoTarea);
            this.mrcDetalleTarea.Controls.Add(this.chkEstudioTarea);
            this.mrcDetalleTarea.Controls.Add(this.chkVacacionTarea);
            this.mrcDetalleTarea.Controls.Add(this.lblLicenciaTarea);
            this.mrcDetalleTarea.Controls.Add(this.chkInsumo);
            this.mrcDetalleTarea.Controls.Add(this.lblUniformeTarea);
            this.mrcDetalleTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDetalleTarea.Location = new System.Drawing.Point(26, 68);
            this.mrcDetalleTarea.Name = "mrcDetalleTarea";
            this.mrcDetalleTarea.Size = new System.Drawing.Size(286, 88);
            this.mrcDetalleTarea.TabIndex = 8;
            this.mrcDetalleTarea.TabStop = false;
            this.mrcDetalleTarea.Text = "Detalle";
            // 
            // chkSalarioTarea
            // 
            this.chkSalarioTarea.AutoSize = true;
            this.chkSalarioTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalarioTarea.Location = new System.Drawing.Point(196, 42);
            this.chkSalarioTarea.Name = "chkSalarioTarea";
            this.chkSalarioTarea.Size = new System.Drawing.Size(82, 19);
            this.chkSalarioTarea.TabIndex = 14;
            this.chkSalarioTarea.Text = "Salario";
            this.chkSalarioTarea.UseVisualStyleBackColor = true;
            this.chkSalarioTarea.CheckedChanged += new System.EventHandler(this.chkSalarioTarea_CheckedChanged);
            // 
            // chkReciboTarea
            // 
            this.chkReciboTarea.AutoSize = true;
            this.chkReciboTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReciboTarea.Location = new System.Drawing.Point(196, 63);
            this.chkReciboTarea.Name = "chkReciboTarea";
            this.chkReciboTarea.Size = new System.Drawing.Size(76, 19);
            this.chkReciboTarea.TabIndex = 13;
            this.chkReciboTarea.Text = "Recibo";
            this.chkReciboTarea.UseVisualStyleBackColor = true;
            this.chkReciboTarea.CheckedChanged += new System.EventHandler(this.chkReciboTarea_CheckedChanged);
            // 
            // lblReclamoTarea
            // 
            this.lblReclamoTarea.AutoSize = true;
            this.lblReclamoTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReclamoTarea.Location = new System.Drawing.Point(193, 24);
            this.lblReclamoTarea.Name = "lblReclamoTarea";
            this.lblReclamoTarea.Size = new System.Drawing.Size(71, 15);
            this.lblReclamoTarea.TabIndex = 12;
            this.lblReclamoTarea.Text = "Reclamo";
            // 
            // chkEstudioTarea
            // 
            this.chkEstudioTarea.AutoSize = true;
            this.chkEstudioTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstudioTarea.Location = new System.Drawing.Point(89, 41);
            this.chkEstudioTarea.Name = "chkEstudioTarea";
            this.chkEstudioTarea.Size = new System.Drawing.Size(82, 19);
            this.chkEstudioTarea.TabIndex = 11;
            this.chkEstudioTarea.Text = "Estudio";
            this.chkEstudioTarea.UseVisualStyleBackColor = true;
            this.chkEstudioTarea.CheckedChanged += new System.EventHandler(this.chkEstudioTarea_CheckedChanged);
            // 
            // chkVacacionTarea
            // 
            this.chkVacacionTarea.AutoSize = true;
            this.chkVacacionTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVacacionTarea.Location = new System.Drawing.Point(89, 62);
            this.chkVacacionTarea.Name = "chkVacacionTarea";
            this.chkVacacionTarea.Size = new System.Drawing.Size(95, 19);
            this.chkVacacionTarea.TabIndex = 10;
            this.chkVacacionTarea.Text = "Vacación";
            this.chkVacacionTarea.UseVisualStyleBackColor = true;
            this.chkVacacionTarea.CheckedChanged += new System.EventHandler(this.chkVacacionTarea_CheckedChanged);
            // 
            // lblLicenciaTarea
            // 
            this.lblLicenciaTarea.AutoSize = true;
            this.lblLicenciaTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenciaTarea.Location = new System.Drawing.Point(89, 24);
            this.lblLicenciaTarea.Name = "lblLicenciaTarea";
            this.lblLicenciaTarea.Size = new System.Drawing.Size(69, 15);
            this.lblLicenciaTarea.TabIndex = 9;
            this.lblLicenciaTarea.Text = "Licencia";
            // 
            // chkInsumo
            // 
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsumo.Location = new System.Drawing.Point(6, 41);
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.Size = new System.Drawing.Size(77, 19);
            this.chkInsumo.TabIndex = 8;
            this.chkInsumo.Text = "Insumo";
            this.chkInsumo.UseVisualStyleBackColor = true;
            this.chkInsumo.CheckedChanged += new System.EventHandler(this.chkInsumo_CheckedChanged);
            // 
            // btnGrabarTarea
            // 
            this.btnGrabarTarea.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGrabarTarea.Enabled = false;
            this.btnGrabarTarea.FlatAppearance.BorderSize = 3;
            this.btnGrabarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarTarea.Location = new System.Drawing.Point(267, 171);
            this.btnGrabarTarea.Name = "btnGrabarTarea";
            this.btnGrabarTarea.Size = new System.Drawing.Size(134, 36);
            this.btnGrabarTarea.TabIndex = 16;
            this.btnGrabarTarea.Text = "Grabar";
            this.btnGrabarTarea.UseVisualStyleBackColor = false;
            this.btnGrabarTarea.Click += new System.EventHandler(this.btnGrabarTarea_Click);
            // 
            // txtComentarioTarea
            // 
            this.txtComentarioTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioTarea.Location = new System.Drawing.Point(339, 89);
            this.txtComentarioTarea.Multiline = true;
            this.txtComentarioTarea.Name = "txtComentarioTarea";
            this.txtComentarioTarea.Size = new System.Drawing.Size(286, 64);
            this.txtComentarioTarea.TabIndex = 17;
            this.txtComentarioTarea.TextChanged += new System.EventHandler(this.txtComentarioTarea_TextChanged);
            // 
            // lblComentarioTarea
            // 
            this.lblComentarioTarea.AutoSize = true;
            this.lblComentarioTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarioTarea.Location = new System.Drawing.Point(335, 65);
            this.lblComentarioTarea.Name = "lblComentarioTarea";
            this.lblComentarioTarea.Size = new System.Drawing.Size(145, 21);
            this.lblComentarioTarea.TabIndex = 15;
            this.lblComentarioTarea.Text = "Comentario:";
            // 
            // panelRegistro
            // 
            this.panelRegistro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelRegistro.Controls.Add(this.lblFechaTarea);
            this.panelRegistro.Controls.Add(this.lblComentarioTarea);
            this.panelRegistro.Controls.Add(this.lblTarea);
            this.panelRegistro.Controls.Add(this.txtComentarioTarea);
            this.panelRegistro.Controls.Add(this.lblLugarTarea);
            this.panelRegistro.Controls.Add(this.btnGrabarTarea);
            this.panelRegistro.Controls.Add(this.dtpFechaTarea);
            this.panelRegistro.Controls.Add(this.cmbTarea);
            this.panelRegistro.Controls.Add(this.mrcDetalleTarea);
            this.panelRegistro.Controls.Add(this.cmbLugarTarea);
            this.panelRegistro.Location = new System.Drawing.Point(326, 258);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(656, 218);
            this.panelRegistro.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblAuditoriaInstrucciones);
            this.panel1.Controls.Add(this.imgRegistrarTarea);
            this.panel1.Location = new System.Drawing.Point(164, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 174);
            this.panel1.TabIndex = 18;
            // 
            // lblAuditoriaInstrucciones
            // 
            this.lblAuditoriaInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAuditoriaInstrucciones.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoriaInstrucciones.Location = new System.Drawing.Point(139, 13);
            this.lblAuditoriaInstrucciones.Name = "lblAuditoriaInstrucciones";
            this.lblAuditoriaInstrucciones.Size = new System.Drawing.Size(795, 139);
            this.lblAuditoriaInstrucciones.TabIndex = 4;
            this.lblAuditoriaInstrucciones.Text = "Para registrar una tarea, complete y seleccione todos los datos, sino el botón no" +
    " se habilitará.\r\nEn caso de querer filtrar o buscar una tarea en específico vaya" +
    " a la opción de \"Historial tarea\".";
            // 
            // imgRegistrarTarea
            // 
            this.imgRegistrarTarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgRegistrarTarea.BackgroundImage")));
            this.imgRegistrarTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgRegistrarTarea.Location = new System.Drawing.Point(13, 13);
            this.imgRegistrarTarea.Name = "imgRegistrarTarea";
            this.imgRegistrarTarea.Size = new System.Drawing.Size(120, 108);
            this.imgRegistrarTarea.TabIndex = 0;
            this.imgRegistrarTarea.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitulo.Controls.Add(this.lblTituloRegistrarTarea);
            this.panelTitulo.Controls.Add(this.btnHome);
            this.panelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitulo.Location = new System.Drawing.Point(164, 12);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(477, 60);
            this.panelTitulo.TabIndex = 37;
            // 
            // lblTituloRegistrarTarea
            // 
            this.lblTituloRegistrarTarea.AutoSize = true;
            this.lblTituloRegistrarTarea.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTituloRegistrarTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistrarTarea.Location = new System.Drawing.Point(62, 11);
            this.lblTituloRegistrarTarea.Name = "lblTituloRegistrarTarea";
            this.lblTituloRegistrarTarea.Size = new System.Drawing.Size(339, 39);
            this.lblTituloRegistrarTarea.TabIndex = 35;
            this.lblTituloRegistrarTarea.Text = "Registrar tarea";
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 718);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.dgvTareas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar tarea";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.mrcDetalleTarea.ResumeLayout(false);
            this.mrcDetalleTarea.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRegistrarTarea)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFechaTarea;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblLugarTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaTarea;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.ComboBox cmbLugarTarea;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label lblUniformeTarea;
        private System.Windows.Forms.GroupBox mrcDetalleTarea;
        private System.Windows.Forms.CheckBox chkSalarioTarea;
        private System.Windows.Forms.CheckBox chkReciboTarea;
        private System.Windows.Forms.Label lblReclamoTarea;
        private System.Windows.Forms.CheckBox chkEstudioTarea;
        private System.Windows.Forms.CheckBox chkVacacionTarea;
        private System.Windows.Forms.Label lblLicenciaTarea;
        private System.Windows.Forms.CheckBox chkInsumo;
        private System.Windows.Forms.Button btnGrabarTarea;
        private System.Windows.Forms.TextBox txtComentarioTarea;
        private System.Windows.Forms.Label lblComentarioTarea;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgRegistrarTarea;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloRegistrarTarea;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblAuditoriaInstrucciones;
    }
}