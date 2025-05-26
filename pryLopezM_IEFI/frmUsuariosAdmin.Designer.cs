namespace pryLopezM_IEFI
{
    partial class frmUsuariosAdmin
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panelCrear = new System.Windows.Forms.Panel();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.cmbBuscarFiltro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbPermisosBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñaBuscar = new System.Windows.Forms.TextBox();
            this.txtUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarUs = new System.Windows.Forms.Button();
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCrearUs = new System.Windows.Forms.Button();
            this.panelActualizar = new System.Windows.Forms.Panel();
            this.btnLimpiarAct = new System.Windows.Forms.Button();
            this.btnBuscarActualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActualizar = new System.Windows.Forms.TextBox();
            this.cmbPermisosActualizar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContraActualizar = new System.Windows.Forms.TextBox();
            this.txtUsuarioActualizar = new System.Windows.Forms.TextBox();
            this.btnActualizarUs = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLimpiarBuscar = new System.Windows.Forms.Button();
            this.chkMensaje = new System.Windows.Forms.CheckBox();
            this.btnEliminarUs = new System.Windows.Forms.Button();
            this.panelAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.panelCrear.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panelActualizar.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(186, 223);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(514, 317);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelOpciones.Controls.Add(this.btnActualizar);
            this.panelOpciones.Controls.Add(this.btnBuscar);
            this.panelOpciones.Controls.Add(this.btnCrear);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(180, 546);
            this.panelOpciones.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizar.Location = new System.Drawing.Point(0, 104);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 52);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar/Eliminar usuario";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.Location = new System.Drawing.Point(0, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 52);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar usuario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrear.Location = new System.Drawing.Point(0, 0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(180, 52);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panelCrear
            // 
            this.panelCrear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelCrear.Controls.Add(this.label13);
            this.panelCrear.Controls.Add(this.txtId);
            this.panelCrear.Controls.Add(this.cmbPermisos);
            this.panelCrear.Controls.Add(this.lblPermisos);
            this.panelCrear.Controls.Add(this.lblContraseña);
            this.panelCrear.Controls.Add(this.lblUsuario);
            this.panelCrear.Controls.Add(this.txtContra);
            this.panelCrear.Controls.Add(this.txtUsuario);
            this.panelCrear.Controls.Add(this.btnCrearUs);
            this.panelCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrear.Location = new System.Drawing.Point(0, 0);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Size = new System.Drawing.Size(528, 217);
            this.panelCrear.TabIndex = 4;
            this.panelCrear.Visible = false;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelBuscar.Controls.Add(this.btnLimpiarBuscar);
            this.panelBuscar.Controls.Add(this.cmbBuscarFiltro);
            this.panelBuscar.Controls.Add(this.label4);
            this.panelBuscar.Controls.Add(this.lblIdBuscar);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.cmbPermisosBuscar);
            this.panelBuscar.Controls.Add(this.label1);
            this.panelBuscar.Controls.Add(this.label2);
            this.panelBuscar.Controls.Add(this.label3);
            this.panelBuscar.Controls.Add(this.txtContraseñaBuscar);
            this.panelBuscar.Controls.Add(this.txtUsuarioBuscar);
            this.panelBuscar.Controls.Add(this.btnBuscarUs);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscar.Location = new System.Drawing.Point(0, 0);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(528, 217);
            this.panelBuscar.TabIndex = 8;
            // 
            // cmbBuscarFiltro
            // 
            this.cmbBuscarFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarFiltro.FormattingEnabled = true;
            this.cmbBuscarFiltro.Location = new System.Drawing.Point(82, 31);
            this.cmbBuscarFiltro.Name = "cmbBuscarFiltro";
            this.cmbBuscarFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarFiltro.TabIndex = 11;
            this.cmbBuscarFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarFiltro_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Buscar por:";
            // 
            // lblIdBuscar
            // 
            this.lblIdBuscar.AutoSize = true;
            this.lblIdBuscar.Location = new System.Drawing.Point(15, 71);
            this.lblIdBuscar.Name = "lblIdBuscar";
            this.lblIdBuscar.Size = new System.Drawing.Size(83, 13);
            this.lblIdBuscar.TabIndex = 9;
            this.lblIdBuscar.Text = "N° Identificador:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Location = new System.Drawing.Point(18, 87);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbPermisosBuscar
            // 
            this.cmbPermisosBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermisosBuscar.Enabled = false;
            this.cmbPermisosBuscar.FormattingEnabled = true;
            this.cmbPermisosBuscar.Location = new System.Drawing.Point(135, 86);
            this.cmbPermisosBuscar.Name = "cmbPermisosBuscar";
            this.cmbPermisosBuscar.Size = new System.Drawing.Size(121, 21);
            this.cmbPermisosBuscar.TabIndex = 7;
            this.cmbPermisosBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbPermisosBuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // txtContraseñaBuscar
            // 
            this.txtContraseñaBuscar.Enabled = false;
            this.txtContraseñaBuscar.Location = new System.Drawing.Point(136, 136);
            this.txtContraseñaBuscar.Name = "txtContraseñaBuscar";
            this.txtContraseñaBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaBuscar.TabIndex = 3;
            // 
            // txtUsuarioBuscar
            // 
            this.txtUsuarioBuscar.Enabled = false;
            this.txtUsuarioBuscar.Location = new System.Drawing.Point(18, 136);
            this.txtUsuarioBuscar.Name = "txtUsuarioBuscar";
            this.txtUsuarioBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioBuscar.TabIndex = 1;
            this.txtUsuarioBuscar.TextChanged += new System.EventHandler(this.txtUsuarioBuscar_TextChanged);
            // 
            // btnBuscarUs
            // 
            this.btnBuscarUs.Enabled = false;
            this.btnBuscarUs.Location = new System.Drawing.Point(124, 159);
            this.btnBuscarUs.Name = "btnBuscarUs";
            this.btnBuscarUs.Size = new System.Drawing.Size(139, 38);
            this.btnBuscarUs.TabIndex = 0;
            this.btnBuscarUs.Text = "Buscar usuario";
            this.btnBuscarUs.UseVisualStyleBackColor = true;
            this.btnBuscarUs.Click += new System.EventHandler(this.btnBuscarUs_Click);
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(130, 35);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(121, 21);
            this.cmbPermisos.TabIndex = 7;
            this.cmbPermisos.SelectedIndexChanged += new System.EventHandler(this.cmbPermisos_SelectedIndexChanged);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(127, 20);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(49, 13);
            this.lblPermisos.TabIndex = 6;
            this.lblPermisos.Text = "Permisos";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(128, 59);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(7, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(131, 75);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 3;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(10, 76);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnCrearUs
            // 
            this.btnCrearUs.Enabled = false;
            this.btnCrearUs.Location = new System.Drawing.Point(53, 110);
            this.btnCrearUs.Name = "btnCrearUs";
            this.btnCrearUs.Size = new System.Drawing.Size(139, 38);
            this.btnCrearUs.TabIndex = 0;
            this.btnCrearUs.Text = "Crear usuario";
            this.btnCrearUs.UseVisualStyleBackColor = true;
            this.btnCrearUs.Click += new System.EventHandler(this.btnCrearUs_Click);
            // 
            // panelActualizar
            // 
            this.panelActualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelActualizar.Controls.Add(this.chkMensaje);
            this.panelActualizar.Controls.Add(this.btnEliminarUs);
            this.panelActualizar.Controls.Add(this.btnLimpiarAct);
            this.panelActualizar.Controls.Add(this.btnBuscarActualizar);
            this.panelActualizar.Controls.Add(this.label5);
            this.panelActualizar.Controls.Add(this.txtActualizar);
            this.panelActualizar.Controls.Add(this.cmbPermisosActualizar);
            this.panelActualizar.Controls.Add(this.label10);
            this.panelActualizar.Controls.Add(this.label11);
            this.panelActualizar.Controls.Add(this.label12);
            this.panelActualizar.Controls.Add(this.txtContraActualizar);
            this.panelActualizar.Controls.Add(this.txtUsuarioActualizar);
            this.panelActualizar.Controls.Add(this.btnActualizarUs);
            this.panelActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActualizar.Location = new System.Drawing.Point(0, 0);
            this.panelActualizar.Name = "panelActualizar";
            this.panelActualizar.Size = new System.Drawing.Size(528, 217);
            this.panelActualizar.TabIndex = 15;
            this.panelActualizar.Visible = false;
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.Location = new System.Drawing.Point(158, 110);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(139, 23);
            this.btnLimpiarAct.TabIndex = 13;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = true;
            this.btnLimpiarAct.Click += new System.EventHandler(this.btnLimpiarAct_Click);
            // 
            // btnBuscarActualizar
            // 
            this.btnBuscarActualizar.Location = new System.Drawing.Point(13, 108);
            this.btnBuscarActualizar.Name = "btnBuscarActualizar";
            this.btnBuscarActualizar.Size = new System.Drawing.Size(139, 25);
            this.btnBuscarActualizar.TabIndex = 12;
            this.btnBuscarActualizar.Text = "Buscar usuario";
            this.btnBuscarActualizar.UseVisualStyleBackColor = true;
            this.btnBuscarActualizar.Click += new System.EventHandler(this.btnBuscarActualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "N° Identificador:";
            // 
            // txtActualizar
            // 
            this.txtActualizar.Enabled = false;
            this.txtActualizar.Location = new System.Drawing.Point(41, 32);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtActualizar.TabIndex = 8;
            // 
            // cmbPermisosActualizar
            // 
            this.cmbPermisosActualizar.Enabled = false;
            this.cmbPermisosActualizar.FormattingEnabled = true;
            this.cmbPermisosActualizar.Location = new System.Drawing.Point(158, 31);
            this.cmbPermisosActualizar.Name = "cmbPermisosActualizar";
            this.cmbPermisosActualizar.Size = new System.Drawing.Size(121, 21);
            this.cmbPermisosActualizar.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Permisos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Usuario:";
            // 
            // txtContraActualizar
            // 
            this.txtContraActualizar.Enabled = false;
            this.txtContraActualizar.Location = new System.Drawing.Point(159, 81);
            this.txtContraActualizar.Name = "txtContraActualizar";
            this.txtContraActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtContraActualizar.TabIndex = 3;
            this.txtContraActualizar.TextChanged += new System.EventHandler(this.txtContraActualizar_TextChanged);
            // 
            // txtUsuarioActualizar
            // 
            this.txtUsuarioActualizar.Location = new System.Drawing.Point(41, 81);
            this.txtUsuarioActualizar.Name = "txtUsuarioActualizar";
            this.txtUsuarioActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioActualizar.TabIndex = 1;
            this.txtUsuarioActualizar.TextChanged += new System.EventHandler(this.txtUsuarioActualizar_TextChanged);
            // 
            // btnActualizarUs
            // 
            this.btnActualizarUs.Enabled = false;
            this.btnActualizarUs.Location = new System.Drawing.Point(13, 139);
            this.btnActualizarUs.Name = "btnActualizarUs";
            this.btnActualizarUs.Size = new System.Drawing.Size(139, 38);
            this.btnActualizarUs.TabIndex = 0;
            this.btnActualizarUs.Text = "Actualizar usuario";
            this.btnActualizarUs.UseVisualStyleBackColor = true;
            this.btnActualizarUs.Click += new System.EventHandler(this.btnActualizarUs_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "N° Identificador:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(10, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(18, 160);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(100, 37);
            this.btnLimpiarBuscar.TabIndex = 14;
            this.btnLimpiarBuscar.Text = "Limpiar";
            this.btnLimpiarBuscar.UseVisualStyleBackColor = true;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // chkMensaje
            // 
            this.chkMensaje.AutoSize = true;
            this.chkMensaje.Checked = true;
            this.chkMensaje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMensaje.Location = new System.Drawing.Point(160, 183);
            this.chkMensaje.Name = "chkMensaje";
            this.chkMensaje.Size = new System.Drawing.Size(144, 17);
            this.chkMensaje.TabIndex = 16;
            this.chkMensaje.Text = "Mensaje de confirmación";
            this.chkMensaje.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUs
            // 
            this.btnEliminarUs.Enabled = false;
            this.btnEliminarUs.Location = new System.Drawing.Point(158, 139);
            this.btnEliminarUs.Name = "btnEliminarUs";
            this.btnEliminarUs.Size = new System.Drawing.Size(139, 38);
            this.btnEliminarUs.TabIndex = 15;
            this.btnEliminarUs.Text = "Eliminar usuario";
            this.btnEliminarUs.UseVisualStyleBackColor = true;
            this.btnEliminarUs.Click += new System.EventHandler(this.btnEliminarUs_Click);
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelAcciones.Controls.Add(this.panelBuscar);
            this.panelAcciones.Controls.Add(this.panelCrear);
            this.panelAcciones.Controls.Add(this.panelActualizar);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcciones.Location = new System.Drawing.Point(180, 0);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(528, 217);
            this.panelAcciones.TabIndex = 16;
            // 
            // frmUsuariosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 546);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "frmUsuariosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.clsUsuariosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panelActualizar.ResumeLayout(false);
            this.panelActualizar.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel panelCrear;
        private System.Windows.Forms.ComboBox cmbPermisos;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCrearUs;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.ComboBox cmbPermisosBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseñaBuscar;
        private System.Windows.Forms.TextBox txtUsuarioBuscar;
        private System.Windows.Forms.Button btnBuscarUs;
        private System.Windows.Forms.Label lblIdBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelActualizar;
        private System.Windows.Forms.Button btnLimpiarAct;
        private System.Windows.Forms.Button btnBuscarActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActualizar;
        private System.Windows.Forms.ComboBox cmbPermisosActualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContraActualizar;
        private System.Windows.Forms.TextBox txtUsuarioActualizar;
        private System.Windows.Forms.Button btnActualizarUs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnLimpiarBuscar;
        private System.Windows.Forms.CheckBox chkMensaje;
        private System.Windows.Forms.Button btnEliminarUs;
        private System.Windows.Forms.Panel panelAcciones;
    }
}