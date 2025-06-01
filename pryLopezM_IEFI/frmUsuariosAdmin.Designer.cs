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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosAdmin));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panelCrear = new System.Windows.Forms.Panel();
            this.lblFechaNaciminetoCrear = new System.Windows.Forms.Label();
            this.txtNombreCrear = new System.Windows.Forms.TextBox();
            this.lblNombreCrear = new System.Windows.Forms.Label();
            this.txtApellidoCrear = new System.Windows.Forms.TextBox();
            this.lblApellidoCrear = new System.Windows.Forms.Label();
            this.txtEdadCrear = new System.Windows.Forms.TextBox();
            this.lblEdadCrear = new System.Windows.Forms.Label();
            this.txtDireccionCrear = new System.Windows.Forms.TextBox();
            this.lblDireccionCrear = new System.Windows.Forms.Label();
            this.txtEmailCrear = new System.Windows.Forms.TextBox();
            this.lblEmailCrear = new System.Windows.Forms.Label();
            this.txtTelefonoCrear = new System.Windows.Forms.TextBox();
            this.lblTelefonoCrear = new System.Windows.Forms.Label();
            this.txtDNICrear = new System.Windows.Forms.TextBox();
            this.lblDNICrear = new System.Windows.Forms.Label();
            this.dtpNacimientoCrear = new System.Windows.Forms.DateTimePicker();
            this.imgCrearUsuario = new System.Windows.Forms.PictureBox();
            this.lblCrearUsuarioInstrucciones = new System.Windows.Forms.Label();
            this.lblIdCrear = new System.Windows.Forms.Label();
            this.txtContraseñaCrear = new System.Windows.Forms.TextBox();
            this.txtUsuarioCrear = new System.Windows.Forms.TextBox();
            this.txtIdCrear = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.lblUsuarioCrear = new System.Windows.Forms.Label();
            this.cmbPermisosCrear = new System.Windows.Forms.ComboBox();
            this.lblContraseñaCrear = new System.Windows.Forms.Label();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.cmbBuscarTipoDeDato = new System.Windows.Forms.ComboBox();
            this.lblBuscarPorCampo = new System.Windows.Forms.Label();
            this.btnLimpiarBuscar = new System.Windows.Forms.Button();
            this.lblBuscarPorFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDatoDeBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusquedaSeleccionada = new System.Windows.Forms.Label();
            this.dtpBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.cmbBuscarPermisos = new System.Windows.Forms.ComboBox();
            this.panelActualizar = new System.Windows.Forms.Panel();
            this.imgActualizarEliminarUsuario = new System.Windows.Forms.PictureBox();
            this.chkMensaje = new System.Windows.Forms.CheckBox();
            this.lblActualizarEliminarUsuarioInstrucciones = new System.Windows.Forms.Label();
            this.btnEliminarUs = new System.Windows.Forms.Button();
            this.btnLimpiarAct = new System.Windows.Forms.Button();
            this.lblIdEliminar = new System.Windows.Forms.Label();
            this.txtActualizar = new System.Windows.Forms.TextBox();
            this.cmbPermisosActualizar = new System.Windows.Forms.ComboBox();
            this.lblPermisosEliminar = new System.Windows.Forms.Label();
            this.lblContraseñaEliminar = new System.Windows.Forms.Label();
            this.lblUusarioEliminar = new System.Windows.Forms.Label();
            this.txtContraActualizar = new System.Windows.Forms.TextBox();
            this.txtUsuarioActualizar = new System.Windows.Forms.TextBox();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.panelAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.panelCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrearUsuario)).BeginInit();
            this.panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActualizarEliminarUsuario)).BeginInit();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(36, 445);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.ShowCellToolTips = false;
            this.dgvUsuarios.ShowEditingIcon = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(1168, 514);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelOpciones.Controls.Add(this.btnEliminar);
            this.panelOpciones.Controls.Add(this.btnActualizar);
            this.panelOpciones.Controls.Add(this.btnBuscar);
            this.panelOpciones.Controls.Add(this.btnCrear);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(243, 417);
            this.panelOpciones.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(0, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(243, 104);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(0, 208);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(243, 104);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar usuario";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(0, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(243, 104);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar usuario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(0, 0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(243, 104);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // panelCrear
            // 
            this.panelCrear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelCrear.Controls.Add(this.lblFechaNaciminetoCrear);
            this.panelCrear.Controls.Add(this.txtNombreCrear);
            this.panelCrear.Controls.Add(this.lblNombreCrear);
            this.panelCrear.Controls.Add(this.txtApellidoCrear);
            this.panelCrear.Controls.Add(this.lblApellidoCrear);
            this.panelCrear.Controls.Add(this.txtEdadCrear);
            this.panelCrear.Controls.Add(this.lblEdadCrear);
            this.panelCrear.Controls.Add(this.txtDireccionCrear);
            this.panelCrear.Controls.Add(this.lblDireccionCrear);
            this.panelCrear.Controls.Add(this.txtEmailCrear);
            this.panelCrear.Controls.Add(this.lblEmailCrear);
            this.panelCrear.Controls.Add(this.txtTelefonoCrear);
            this.panelCrear.Controls.Add(this.lblTelefonoCrear);
            this.panelCrear.Controls.Add(this.txtDNICrear);
            this.panelCrear.Controls.Add(this.lblDNICrear);
            this.panelCrear.Controls.Add(this.dtpNacimientoCrear);
            this.panelCrear.Controls.Add(this.imgCrearUsuario);
            this.panelCrear.Controls.Add(this.lblCrearUsuarioInstrucciones);
            this.panelCrear.Controls.Add(this.lblIdCrear);
            this.panelCrear.Controls.Add(this.txtContraseñaCrear);
            this.panelCrear.Controls.Add(this.txtUsuarioCrear);
            this.panelCrear.Controls.Add(this.txtIdCrear);
            this.panelCrear.Controls.Add(this.btnCrearUsuario);
            this.panelCrear.Controls.Add(this.lblUsuarioCrear);
            this.panelCrear.Controls.Add(this.cmbPermisosCrear);
            this.panelCrear.Controls.Add(this.lblContraseñaCrear);
            this.panelCrear.Controls.Add(this.lblPermisos);
            this.panelCrear.Location = new System.Drawing.Point(242, 4);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Size = new System.Drawing.Size(1003, 413);
            this.panelCrear.TabIndex = 4;
            this.panelCrear.Visible = false;
            // 
            // lblFechaNaciminetoCrear
            // 
            this.lblFechaNaciminetoCrear.AutoSize = true;
            this.lblFechaNaciminetoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNaciminetoCrear.Location = new System.Drawing.Point(11, 281);
            this.lblFechaNaciminetoCrear.Name = "lblFechaNaciminetoCrear";
            this.lblFechaNaciminetoCrear.Size = new System.Drawing.Size(193, 24);
            this.lblFechaNaciminetoCrear.TabIndex = 27;
            this.lblFechaNaciminetoCrear.Text = "Fecha de nacimineto:";
            // 
            // txtNombreCrear
            // 
            this.txtNombreCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCrear.Location = new System.Drawing.Point(515, 186);
            this.txtNombreCrear.Name = "txtNombreCrear";
            this.txtNombreCrear.Size = new System.Drawing.Size(166, 29);
            this.txtNombreCrear.TabIndex = 3;
            this.txtNombreCrear.TextChanged += new System.EventHandler(this.txtNombreCrear_TextChanged);
            // 
            // lblNombreCrear
            // 
            this.lblNombreCrear.AutoSize = true;
            this.lblNombreCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCrear.Location = new System.Drawing.Point(511, 163);
            this.lblNombreCrear.Name = "lblNombreCrear";
            this.lblNombreCrear.Size = new System.Drawing.Size(84, 24);
            this.lblNombreCrear.TabIndex = 26;
            this.lblNombreCrear.Text = "Nombre:";
            // 
            // txtApellidoCrear
            // 
            this.txtApellidoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCrear.Location = new System.Drawing.Point(700, 186);
            this.txtApellidoCrear.Name = "txtApellidoCrear";
            this.txtApellidoCrear.Size = new System.Drawing.Size(142, 29);
            this.txtApellidoCrear.TabIndex = 4;
            this.txtApellidoCrear.TextChanged += new System.EventHandler(this.txtApellidoCrear_TextChanged);
            // 
            // lblApellidoCrear
            // 
            this.lblApellidoCrear.AutoSize = true;
            this.lblApellidoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCrear.Location = new System.Drawing.Point(696, 163);
            this.lblApellidoCrear.Name = "lblApellidoCrear";
            this.lblApellidoCrear.Size = new System.Drawing.Size(84, 24);
            this.lblApellidoCrear.TabIndex = 24;
            this.lblApellidoCrear.Text = "Apellido:";
            // 
            // txtEdadCrear
            // 
            this.txtEdadCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadCrear.Location = new System.Drawing.Point(859, 186);
            this.txtEdadCrear.Name = "txtEdadCrear";
            this.txtEdadCrear.Size = new System.Drawing.Size(79, 29);
            this.txtEdadCrear.TabIndex = 5;
            this.txtEdadCrear.TextChanged += new System.EventHandler(this.txtEdadCrear_TextChanged);
            this.txtEdadCrear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCrear_KeyPress);
            // 
            // lblEdadCrear
            // 
            this.lblEdadCrear.AutoSize = true;
            this.lblEdadCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadCrear.Location = new System.Drawing.Point(855, 163);
            this.lblEdadCrear.Name = "lblEdadCrear";
            this.lblEdadCrear.Size = new System.Drawing.Size(60, 24);
            this.lblEdadCrear.TabIndex = 22;
            this.lblEdadCrear.Text = "Edad:";
            // 
            // txtDireccionCrear
            // 
            this.txtDireccionCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCrear.Location = new System.Drawing.Point(171, 247);
            this.txtDireccionCrear.Name = "txtDireccionCrear";
            this.txtDireccionCrear.Size = new System.Drawing.Size(261, 29);
            this.txtDireccionCrear.TabIndex = 7;
            this.txtDireccionCrear.TextChanged += new System.EventHandler(this.txtDireccionCrear_TextChanged);
            // 
            // lblDireccionCrear
            // 
            this.lblDireccionCrear.AutoSize = true;
            this.lblDireccionCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCrear.Location = new System.Drawing.Point(167, 224);
            this.lblDireccionCrear.Name = "lblDireccionCrear";
            this.lblDireccionCrear.Size = new System.Drawing.Size(95, 24);
            this.lblDireccionCrear.TabIndex = 20;
            this.lblDireccionCrear.Text = "Dirección:";
            // 
            // txtEmailCrear
            // 
            this.txtEmailCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCrear.Location = new System.Drawing.Point(663, 247);
            this.txtEmailCrear.Name = "txtEmailCrear";
            this.txtEmailCrear.Size = new System.Drawing.Size(275, 29);
            this.txtEmailCrear.TabIndex = 9;
            this.txtEmailCrear.TextChanged += new System.EventHandler(this.txtEmailCrear_TextChanged);
            // 
            // lblEmailCrear
            // 
            this.lblEmailCrear.AutoSize = true;
            this.lblEmailCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCrear.Location = new System.Drawing.Point(659, 224);
            this.lblEmailCrear.Name = "lblEmailCrear";
            this.lblEmailCrear.Size = new System.Drawing.Size(62, 24);
            this.lblEmailCrear.TabIndex = 18;
            this.lblEmailCrear.Text = "Email:";
            // 
            // txtTelefonoCrear
            // 
            this.txtTelefonoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCrear.Location = new System.Drawing.Point(453, 247);
            this.txtTelefonoCrear.Name = "txtTelefonoCrear";
            this.txtTelefonoCrear.Size = new System.Drawing.Size(190, 29);
            this.txtTelefonoCrear.TabIndex = 8;
            this.txtTelefonoCrear.TextChanged += new System.EventHandler(this.txtTelefonoCrear_TextChanged);
            // 
            // lblTelefonoCrear
            // 
            this.lblTelefonoCrear.AutoSize = true;
            this.lblTelefonoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCrear.Location = new System.Drawing.Point(449, 224);
            this.lblTelefonoCrear.Name = "lblTelefonoCrear";
            this.lblTelefonoCrear.Size = new System.Drawing.Size(90, 24);
            this.lblTelefonoCrear.TabIndex = 16;
            this.lblTelefonoCrear.Text = "Teléfono:";
            // 
            // txtDNICrear
            // 
            this.txtDNICrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNICrear.Location = new System.Drawing.Point(14, 247);
            this.txtDNICrear.Name = "txtDNICrear";
            this.txtDNICrear.Size = new System.Drawing.Size(142, 29);
            this.txtDNICrear.TabIndex = 6;
            this.txtDNICrear.TextChanged += new System.EventHandler(this.txtDNICrear_TextChanged);
            // 
            // lblDNICrear
            // 
            this.lblDNICrear.AutoSize = true;
            this.lblDNICrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNICrear.Location = new System.Drawing.Point(10, 224);
            this.lblDNICrear.Name = "lblDNICrear";
            this.lblDNICrear.Size = new System.Drawing.Size(46, 24);
            this.lblDNICrear.TabIndex = 14;
            this.lblDNICrear.Text = "DNI:";
            // 
            // dtpNacimientoCrear
            // 
            this.dtpNacimientoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimientoCrear.Location = new System.Drawing.Point(15, 304);
            this.dtpNacimientoCrear.Name = "dtpNacimientoCrear";
            this.dtpNacimientoCrear.Size = new System.Drawing.Size(350, 29);
            this.dtpNacimientoCrear.TabIndex = 10;
            this.dtpNacimientoCrear.ValueChanged += new System.EventHandler(this.dtpNacimientoCrear_ValueChanged_1);
            // 
            // imgCrearUsuario
            // 
            this.imgCrearUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgCrearUsuario.Image")));
            this.imgCrearUsuario.Location = new System.Drawing.Point(14, 16);
            this.imgCrearUsuario.Name = "imgCrearUsuario";
            this.imgCrearUsuario.Size = new System.Drawing.Size(143, 136);
            this.imgCrearUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCrearUsuario.TabIndex = 11;
            this.imgCrearUsuario.TabStop = false;
            // 
            // lblCrearUsuarioInstrucciones
            // 
            this.lblCrearUsuarioInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrearUsuarioInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearUsuarioInstrucciones.Location = new System.Drawing.Point(167, 13);
            this.lblCrearUsuarioInstrucciones.Name = "lblCrearUsuarioInstrucciones";
            this.lblCrearUsuarioInstrucciones.Size = new System.Drawing.Size(762, 139);
            this.lblCrearUsuarioInstrucciones.TabIndex = 10;
            this.lblCrearUsuarioInstrucciones.Text = resources.GetString("lblCrearUsuarioInstrucciones.Text");
            // 
            // lblIdCrear
            // 
            this.lblIdCrear.AutoSize = true;
            this.lblIdCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCrear.Location = new System.Drawing.Point(11, 163);
            this.lblIdCrear.Name = "lblIdCrear";
            this.lblIdCrear.Size = new System.Drawing.Size(141, 24);
            this.lblIdCrear.TabIndex = 9;
            this.lblIdCrear.Text = "N° Identificador:";
            // 
            // txtContraseñaCrear
            // 
            this.txtContraseñaCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaCrear.Location = new System.Drawing.Point(341, 186);
            this.txtContraseñaCrear.Name = "txtContraseñaCrear";
            this.txtContraseñaCrear.Size = new System.Drawing.Size(155, 29);
            this.txtContraseñaCrear.TabIndex = 2;
            this.txtContraseñaCrear.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtUsuarioCrear
            // 
            this.txtUsuarioCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCrear.Location = new System.Drawing.Point(171, 186);
            this.txtUsuarioCrear.Name = "txtUsuarioCrear";
            this.txtUsuarioCrear.Size = new System.Drawing.Size(151, 29);
            this.txtUsuarioCrear.TabIndex = 1;
            this.txtUsuarioCrear.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtIdCrear
            // 
            this.txtIdCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCrear.Location = new System.Drawing.Point(15, 186);
            this.txtIdCrear.Name = "txtIdCrear";
            this.txtIdCrear.Size = new System.Drawing.Size(137, 29);
            this.txtIdCrear.TabIndex = 0;
            this.txtIdCrear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCrear_KeyPress);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Enabled = false;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(301, 356);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(394, 38);
            this.btnCrearUsuario.TabIndex = 12;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // lblUsuarioCrear
            // 
            this.lblUsuarioCrear.AutoSize = true;
            this.lblUsuarioCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCrear.Location = new System.Drawing.Point(167, 163);
            this.lblUsuarioCrear.Name = "lblUsuarioCrear";
            this.lblUsuarioCrear.Size = new System.Drawing.Size(79, 24);
            this.lblUsuarioCrear.TabIndex = 4;
            this.lblUsuarioCrear.Text = "Usuario:";
            // 
            // cmbPermisosCrear
            // 
            this.cmbPermisosCrear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermisosCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPermisosCrear.FormattingEnabled = true;
            this.cmbPermisosCrear.Location = new System.Drawing.Point(392, 301);
            this.cmbPermisosCrear.Name = "cmbPermisosCrear";
            this.cmbPermisosCrear.Size = new System.Drawing.Size(197, 32);
            this.cmbPermisosCrear.TabIndex = 11;
            this.cmbPermisosCrear.SelectedIndexChanged += new System.EventHandler(this.cmbPermisos_SelectedIndexChanged);
            // 
            // lblContraseñaCrear
            // 
            this.lblContraseñaCrear.AutoSize = true;
            this.lblContraseñaCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaCrear.Location = new System.Drawing.Point(337, 163);
            this.lblContraseñaCrear.Name = "lblContraseñaCrear";
            this.lblContraseñaCrear.Size = new System.Drawing.Size(111, 24);
            this.lblContraseñaCrear.TabIndex = 5;
            this.lblContraseñaCrear.Text = "Contraseña:";
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisos.Location = new System.Drawing.Point(388, 279);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(93, 24);
            this.lblPermisos.TabIndex = 6;
            this.lblPermisos.Text = "Permisos:";
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelBuscar.Controls.Add(this.cmbBuscarTipoDeDato);
            this.panelBuscar.Controls.Add(this.lblBuscarPorCampo);
            this.panelBuscar.Controls.Add(this.btnLimpiarBuscar);
            this.panelBuscar.Controls.Add(this.lblBuscarPorFecha);
            this.panelBuscar.Controls.Add(this.label10);
            this.panelBuscar.Controls.Add(this.txtDatoDeBusqueda);
            this.panelBuscar.Controls.Add(this.lblBusquedaSeleccionada);
            this.panelBuscar.Controls.Add(this.dtpBuscarFecha);
            this.panelBuscar.Controls.Add(this.pictureBox2);
            this.panelBuscar.Controls.Add(this.btnBuscarUsuario);
            this.panelBuscar.Controls.Add(this.cmbBuscarPermisos);
            this.panelBuscar.Location = new System.Drawing.Point(242, 4);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(1003, 413);
            this.panelBuscar.TabIndex = 29;
            this.panelBuscar.Visible = false;
            // 
            // cmbBuscarTipoDeDato
            // 
            this.cmbBuscarTipoDeDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarTipoDeDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarTipoDeDato.FormattingEnabled = true;
            this.cmbBuscarTipoDeDato.Items.AddRange(new object[] {
            "N° Identificador",
            "Usuario",
            "Contraseña",
            "Nombre",
            "Apellido",
            "Edad",
            "DNI",
            "Dirección",
            "Teléfono",
            "E-mail",
            "Fecha de nacimiento",
            "Fecha de alta",
            "Permisos"});
            this.cmbBuscarTipoDeDato.Location = new System.Drawing.Point(356, 183);
            this.cmbBuscarTipoDeDato.Name = "cmbBuscarTipoDeDato";
            this.cmbBuscarTipoDeDato.Size = new System.Drawing.Size(243, 32);
            this.cmbBuscarTipoDeDato.TabIndex = 30;
            this.cmbBuscarTipoDeDato.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarTipoDeDato_SelectedIndexChanged);
            // 
            // lblBuscarPorCampo
            // 
            this.lblBuscarPorCampo.AutoSize = true;
            this.lblBuscarPorCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCampo.Location = new System.Drawing.Point(319, 158);
            this.lblBuscarPorCampo.Name = "lblBuscarPorCampo";
            this.lblBuscarPorCampo.Size = new System.Drawing.Size(374, 24);
            this.lblBuscarPorCampo.TabIndex = 29;
            this.lblBuscarPorCampo.Text = "Seleccione tipo dato de referencia a buscar";
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(256, 312);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(222, 38);
            this.btnLimpiarBuscar.TabIndex = 28;
            this.btnLimpiarBuscar.Text = "Limpiar";
            this.btnLimpiarBuscar.UseVisualStyleBackColor = true;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // lblBuscarPorFecha
            // 
            this.lblBuscarPorFecha.AutoSize = true;
            this.lblBuscarPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorFecha.Location = new System.Drawing.Point(294, 220);
            this.lblBuscarPorFecha.Name = "lblBuscarPorFecha";
            this.lblBuscarPorFecha.Size = new System.Drawing.Size(161, 24);
            this.lblBuscarPorFecha.TabIndex = 27;
            this.lblBuscarPorFecha.Text = "Seleccione fecha:";
            this.lblBuscarPorFecha.Visible = false;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 16);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(766, 136);
            this.label10.TabIndex = 12;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // txtDatoDeBusqueda
            // 
            this.txtDatoDeBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoDeBusqueda.Location = new System.Drawing.Point(335, 247);
            this.txtDatoDeBusqueda.Name = "txtDatoDeBusqueda";
            this.txtDatoDeBusqueda.Size = new System.Drawing.Size(264, 29);
            this.txtDatoDeBusqueda.TabIndex = 9;
            this.txtDatoDeBusqueda.Visible = false;
            this.txtDatoDeBusqueda.TextChanged += new System.EventHandler(this.txtDatoDeBusqueda_TextChanged);
            this.txtDatoDeBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatoDeBusqueda_KeyPress);
            // 
            // lblBusquedaSeleccionada
            // 
            this.lblBusquedaSeleccionada.AutoSize = true;
            this.lblBusquedaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaSeleccionada.Location = new System.Drawing.Point(375, 220);
            this.lblBusquedaSeleccionada.Name = "lblBusquedaSeleccionada";
            this.lblBusquedaSeleccionada.Size = new System.Drawing.Size(175, 24);
            this.lblBusquedaSeleccionada.TabIndex = 18;
            this.lblBusquedaSeleccionada.Text = "Opción del usuario:";
            this.lblBusquedaSeleccionada.Visible = false;
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBuscarFecha.Location = new System.Drawing.Point(293, 246);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.Size = new System.Drawing.Size(350, 29);
            this.dtpBuscarFecha.TabIndex = 10;
            this.dtpBuscarFecha.Value = new System.DateTime(2025, 6, 1, 0, 0, 0, 0);
            this.dtpBuscarFecha.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Enabled = false;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(484, 312);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(222, 38);
            this.btnBuscarUsuario.TabIndex = 12;
            this.btnBuscarUsuario.Text = "Buscar usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // cmbBuscarPermisos
            // 
            this.cmbBuscarPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarPermisos.FormattingEnabled = true;
            this.cmbBuscarPermisos.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.cmbBuscarPermisos.Location = new System.Drawing.Point(298, 245);
            this.cmbBuscarPermisos.Name = "cmbBuscarPermisos";
            this.cmbBuscarPermisos.Size = new System.Drawing.Size(338, 32);
            this.cmbBuscarPermisos.TabIndex = 11;
            this.cmbBuscarPermisos.Visible = false;
            // 
            // panelActualizar
            // 
            this.panelActualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelActualizar.Controls.Add(this.imgActualizarEliminarUsuario);
            this.panelActualizar.Controls.Add(this.chkMensaje);
            this.panelActualizar.Controls.Add(this.lblActualizarEliminarUsuarioInstrucciones);
            this.panelActualizar.Controls.Add(this.btnEliminarUs);
            this.panelActualizar.Controls.Add(this.btnLimpiarAct);
            this.panelActualizar.Controls.Add(this.lblIdEliminar);
            this.panelActualizar.Controls.Add(this.txtActualizar);
            this.panelActualizar.Controls.Add(this.cmbPermisosActualizar);
            this.panelActualizar.Controls.Add(this.lblPermisosEliminar);
            this.panelActualizar.Controls.Add(this.lblContraseñaEliminar);
            this.panelActualizar.Controls.Add(this.lblUusarioEliminar);
            this.panelActualizar.Controls.Add(this.txtContraActualizar);
            this.panelActualizar.Controls.Add(this.txtUsuarioActualizar);
            this.panelActualizar.Controls.Add(this.btnActualizarUsuario);
            this.panelActualizar.Location = new System.Drawing.Point(431, 164);
            this.panelActualizar.Name = "panelActualizar";
            this.panelActualizar.Size = new System.Drawing.Size(569, 249);
            this.panelActualizar.TabIndex = 15;
            this.panelActualizar.Visible = false;
            // 
            // imgActualizarEliminarUsuario
            // 
            this.imgActualizarEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgActualizarEliminarUsuario.Image")));
            this.imgActualizarEliminarUsuario.Location = new System.Drawing.Point(16, 11);
            this.imgActualizarEliminarUsuario.Name = "imgActualizarEliminarUsuario";
            this.imgActualizarEliminarUsuario.Size = new System.Drawing.Size(105, 101);
            this.imgActualizarEliminarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgActualizarEliminarUsuario.TabIndex = 17;
            this.imgActualizarEliminarUsuario.TabStop = false;
            // 
            // chkMensaje
            // 
            this.chkMensaje.AutoSize = true;
            this.chkMensaje.Checked = true;
            this.chkMensaje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMensaje.Location = new System.Drawing.Point(318, 221);
            this.chkMensaje.Name = "chkMensaje";
            this.chkMensaje.Size = new System.Drawing.Size(144, 17);
            this.chkMensaje.TabIndex = 16;
            this.chkMensaje.Text = "Mensaje de confirmación";
            this.chkMensaje.UseVisualStyleBackColor = true;
            // 
            // lblActualizarEliminarUsuarioInstrucciones
            // 
            this.lblActualizarEliminarUsuarioInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActualizarEliminarUsuarioInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarEliminarUsuarioInstrucciones.Location = new System.Drawing.Point(127, 11);
            this.lblActualizarEliminarUsuarioInstrucciones.Name = "lblActualizarEliminarUsuarioInstrucciones";
            this.lblActualizarEliminarUsuarioInstrucciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblActualizarEliminarUsuarioInstrucciones.Size = new System.Drawing.Size(438, 114);
            this.lblActualizarEliminarUsuarioInstrucciones.TabIndex = 16;
            this.lblActualizarEliminarUsuarioInstrucciones.Text = resources.GetString("lblActualizarEliminarUsuarioInstrucciones.Text");
            // 
            // btnEliminarUs
            // 
            this.btnEliminarUs.Enabled = false;
            this.btnEliminarUs.Location = new System.Drawing.Point(318, 177);
            this.btnEliminarUs.Name = "btnEliminarUs";
            this.btnEliminarUs.Size = new System.Drawing.Size(139, 38);
            this.btnEliminarUs.TabIndex = 15;
            this.btnEliminarUs.Text = "Eliminar usuario";
            this.btnEliminarUs.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.Location = new System.Drawing.Point(28, 177);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(139, 38);
            this.btnLimpiarAct.TabIndex = 13;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = true;
            // 
            // lblIdEliminar
            // 
            this.lblIdEliminar.AutoSize = true;
            this.lblIdEliminar.Location = new System.Drawing.Point(21, 135);
            this.lblIdEliminar.Name = "lblIdEliminar";
            this.lblIdEliminar.Size = new System.Drawing.Size(83, 13);
            this.lblIdEliminar.TabIndex = 9;
            this.lblIdEliminar.Text = "N° Identificador:";
            // 
            // txtActualizar
            // 
            this.txtActualizar.Enabled = false;
            this.txtActualizar.Location = new System.Drawing.Point(24, 151);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtActualizar.TabIndex = 8;
            this.txtActualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // cmbPermisosActualizar
            // 
            this.cmbPermisosActualizar.Enabled = false;
            this.cmbPermisosActualizar.FormattingEnabled = true;
            this.cmbPermisosActualizar.Location = new System.Drawing.Point(247, 150);
            this.cmbPermisosActualizar.Name = "cmbPermisosActualizar";
            this.cmbPermisosActualizar.Size = new System.Drawing.Size(101, 21);
            this.cmbPermisosActualizar.TabIndex = 7;
            // 
            // lblPermisosEliminar
            // 
            this.lblPermisosEliminar.AutoSize = true;
            this.lblPermisosEliminar.Location = new System.Drawing.Point(244, 135);
            this.lblPermisosEliminar.Name = "lblPermisosEliminar";
            this.lblPermisosEliminar.Size = new System.Drawing.Size(49, 13);
            this.lblPermisosEliminar.TabIndex = 6;
            this.lblPermisosEliminar.Text = "Permisos";
            // 
            // lblContraseñaEliminar
            // 
            this.lblContraseñaEliminar.AutoSize = true;
            this.lblContraseñaEliminar.Location = new System.Drawing.Point(354, 135);
            this.lblContraseñaEliminar.Name = "lblContraseñaEliminar";
            this.lblContraseñaEliminar.Size = new System.Drawing.Size(64, 13);
            this.lblContraseñaEliminar.TabIndex = 5;
            this.lblContraseñaEliminar.Text = "Contraseña:";
            // 
            // lblUusarioEliminar
            // 
            this.lblUusarioEliminar.AutoSize = true;
            this.lblUusarioEliminar.Location = new System.Drawing.Point(132, 135);
            this.lblUusarioEliminar.Name = "lblUusarioEliminar";
            this.lblUusarioEliminar.Size = new System.Drawing.Size(46, 13);
            this.lblUusarioEliminar.TabIndex = 4;
            this.lblUusarioEliminar.Text = "Usuario:";
            // 
            // txtContraActualizar
            // 
            this.txtContraActualizar.Enabled = false;
            this.txtContraActualizar.Location = new System.Drawing.Point(357, 151);
            this.txtContraActualizar.Name = "txtContraActualizar";
            this.txtContraActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtContraActualizar.TabIndex = 3;
            // 
            // txtUsuarioActualizar
            // 
            this.txtUsuarioActualizar.Location = new System.Drawing.Point(135, 151);
            this.txtUsuarioActualizar.Name = "txtUsuarioActualizar";
            this.txtUsuarioActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioActualizar.TabIndex = 1;
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Enabled = false;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(173, 177);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(139, 38);
            this.btnActualizarUsuario.TabIndex = 0;
            this.btnActualizarUsuario.Text = "Actualizar usuario";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelAcciones.Controls.Add(this.panelBuscar);
            this.panelAcciones.Controls.Add(this.panelCrear);
            this.panelAcciones.Controls.Add(this.panelOpciones);
            this.panelAcciones.Controls.Add(this.panelActualizar);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcciones.Location = new System.Drawing.Point(0, 0);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(1245, 417);
            this.panelAcciones.TabIndex = 16;
            // 
            // frmUsuariosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 971);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "frmUsuariosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.clsUsuariosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrearUsuario)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelActualizar.ResumeLayout(false);
            this.panelActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActualizarEliminarUsuario)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbPermisosCrear;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblContraseñaCrear;
        private System.Windows.Forms.Label lblUsuarioCrear;
        private System.Windows.Forms.TextBox txtContraseñaCrear;
        private System.Windows.Forms.TextBox txtUsuarioCrear;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Panel panelActualizar;
        private System.Windows.Forms.Button btnLimpiarAct;
        private System.Windows.Forms.Label lblIdEliminar;
        private System.Windows.Forms.TextBox txtActualizar;
        private System.Windows.Forms.ComboBox cmbPermisosActualizar;
        private System.Windows.Forms.Label lblPermisosEliminar;
        private System.Windows.Forms.Label lblContraseñaEliminar;
        private System.Windows.Forms.Label lblUusarioEliminar;
        private System.Windows.Forms.TextBox txtContraActualizar;
        private System.Windows.Forms.TextBox txtUsuarioActualizar;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Label lblIdCrear;
        private System.Windows.Forms.TextBox txtIdCrear;
        private System.Windows.Forms.CheckBox chkMensaje;
        private System.Windows.Forms.Button btnEliminarUs;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Label lblCrearUsuarioInstrucciones;
        private System.Windows.Forms.PictureBox imgCrearUsuario;
        private System.Windows.Forms.PictureBox imgActualizarEliminarUsuario;
        private System.Windows.Forms.Label lblActualizarEliminarUsuarioInstrucciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombreCrear;
        private System.Windows.Forms.Label lblNombreCrear;
        private System.Windows.Forms.TextBox txtApellidoCrear;
        private System.Windows.Forms.Label lblApellidoCrear;
        private System.Windows.Forms.TextBox txtEdadCrear;
        private System.Windows.Forms.Label lblEdadCrear;
        private System.Windows.Forms.TextBox txtDireccionCrear;
        private System.Windows.Forms.Label lblDireccionCrear;
        private System.Windows.Forms.TextBox txtEmailCrear;
        private System.Windows.Forms.Label lblEmailCrear;
        private System.Windows.Forms.TextBox txtTelefonoCrear;
        private System.Windows.Forms.Label lblTelefonoCrear;
        private System.Windows.Forms.TextBox txtDNICrear;
        private System.Windows.Forms.Label lblDNICrear;
        private System.Windows.Forms.DateTimePicker dtpNacimientoCrear;
        private System.Windows.Forms.Label lblFechaNaciminetoCrear;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarTipoDeDato;
        private System.Windows.Forms.Label lblBuscarPorCampo;
        private System.Windows.Forms.Button btnLimpiarBuscar;
        private System.Windows.Forms.Label lblBuscarPorFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDatoDeBusqueda;
        private System.Windows.Forms.Label lblBusquedaSeleccionada;
        private System.Windows.Forms.DateTimePicker dtpBuscarFecha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.ComboBox cmbBuscarPermisos;
    }
}