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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panelCrear = new System.Windows.Forms.Panel();
            this.imgCrearUsuario = new System.Windows.Forms.PictureBox();
            this.lblCrearUsuarioInstrucciones = new System.Windows.Forms.Label();
            this.lblIdCrear = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCrearUs = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.imgBuscarUsuario = new System.Windows.Forms.PictureBox();
            this.lblBuscarUusariosInstrucciones = new System.Windows.Forms.Label();
            this.btnLimpiarBuscar = new System.Windows.Forms.Button();
            this.cmbBuscarFiltro = new System.Windows.Forms.ComboBox();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.lblIdBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbPermisosBuscar = new System.Windows.Forms.ComboBox();
            this.lblPermisosBuscar = new System.Windows.Forms.Label();
            this.lblContrseñaBuscar = new System.Windows.Forms.Label();
            this.lblUsuarioBuscar = new System.Windows.Forms.Label();
            this.txtContraseñaBuscar = new System.Windows.Forms.TextBox();
            this.txtUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarUsuario)).BeginInit();
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
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(579, 76);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(417, 238);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelOpciones.Controls.Add(this.btnActualizar);
            this.panelOpciones.Controls.Add(this.btnBuscar);
            this.panelOpciones.Controls.Add(this.btnCrear);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1017, 59);
            this.panelOpciones.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActualizar.Location = new System.Drawing.Point(360, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 59);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar/Eliminar usuario";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Location = new System.Drawing.Point(180, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 59);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar usuario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCrear.Location = new System.Drawing.Point(0, 0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(180, 59);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panelCrear
            // 
            this.panelCrear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelCrear.Controls.Add(this.imgCrearUsuario);
            this.panelCrear.Controls.Add(this.lblCrearUsuarioInstrucciones);
            this.panelCrear.Controls.Add(this.lblIdCrear);
            this.panelCrear.Controls.Add(this.txtContra);
            this.panelCrear.Controls.Add(this.txtUsuario);
            this.panelCrear.Controls.Add(this.txtId);
            this.panelCrear.Controls.Add(this.btnCrearUs);
            this.panelCrear.Controls.Add(this.lblUsuario);
            this.panelCrear.Controls.Add(this.cmbPermisos);
            this.panelCrear.Controls.Add(this.lblContraseña);
            this.panelCrear.Controls.Add(this.lblPermisos);
            this.panelCrear.Location = new System.Drawing.Point(3, 67);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Size = new System.Drawing.Size(568, 247);
            this.panelCrear.TabIndex = 4;
            this.panelCrear.Visible = false;
            // 
            // imgCrearUsuario
            // 
            this.imgCrearUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgCrearUsuario.Image")));
            this.imgCrearUsuario.Location = new System.Drawing.Point(14, 16);
            this.imgCrearUsuario.Name = "imgCrearUsuario";
            this.imgCrearUsuario.Size = new System.Drawing.Size(105, 101);
            this.imgCrearUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCrearUsuario.TabIndex = 11;
            this.imgCrearUsuario.TabStop = false;
            // 
            // lblCrearUsuarioInstrucciones
            // 
            this.lblCrearUsuarioInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrearUsuarioInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearUsuarioInstrucciones.Location = new System.Drawing.Point(125, 13);
            this.lblCrearUsuarioInstrucciones.Name = "lblCrearUsuarioInstrucciones";
            this.lblCrearUsuarioInstrucciones.Size = new System.Drawing.Size(422, 104);
            this.lblCrearUsuarioInstrucciones.TabIndex = 10;
            this.lblCrearUsuarioInstrucciones.Text = resources.GetString("lblCrearUsuarioInstrucciones.Text");
            // 
            // lblIdCrear
            // 
            this.lblIdCrear.AutoSize = true;
            this.lblIdCrear.Location = new System.Drawing.Point(16, 131);
            this.lblIdCrear.Name = "lblIdCrear";
            this.lblIdCrear.Size = new System.Drawing.Size(83, 13);
            this.lblIdCrear.TabIndex = 9;
            this.lblIdCrear.Text = "N° Identificador:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(258, 147);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 3;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(137, 148);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(19, 147);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // btnCrearUs
            // 
            this.btnCrearUs.Enabled = false;
            this.btnCrearUs.Location = new System.Drawing.Point(180, 174);
            this.btnCrearUs.Name = "btnCrearUs";
            this.btnCrearUs.Size = new System.Drawing.Size(139, 38);
            this.btnCrearUs.TabIndex = 0;
            this.btnCrearUs.Text = "Crear usuario";
            this.btnCrearUs.UseVisualStyleBackColor = true;
            this.btnCrearUs.Click += new System.EventHandler(this.btnCrearUs_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(134, 132);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(377, 146);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(101, 21);
            this.cmbPermisos.TabIndex = 7;
            this.cmbPermisos.SelectedIndexChanged += new System.EventHandler(this.cmbPermisos_SelectedIndexChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(255, 131);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(374, 131);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(49, 13);
            this.lblPermisos.TabIndex = 6;
            this.lblPermisos.Text = "Permisos";
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelBuscar.Controls.Add(this.imgBuscarUsuario);
            this.panelBuscar.Controls.Add(this.lblBuscarUusariosInstrucciones);
            this.panelBuscar.Controls.Add(this.btnLimpiarBuscar);
            this.panelBuscar.Controls.Add(this.cmbBuscarFiltro);
            this.panelBuscar.Controls.Add(this.lblBuscarUsuario);
            this.panelBuscar.Controls.Add(this.lblIdBuscar);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.cmbPermisosBuscar);
            this.panelBuscar.Controls.Add(this.lblPermisosBuscar);
            this.panelBuscar.Controls.Add(this.lblContrseñaBuscar);
            this.panelBuscar.Controls.Add(this.lblUsuarioBuscar);
            this.panelBuscar.Controls.Add(this.txtContraseñaBuscar);
            this.panelBuscar.Controls.Add(this.txtUsuarioBuscar);
            this.panelBuscar.Controls.Add(this.btnBuscarUsuario);
            this.panelBuscar.Location = new System.Drawing.Point(3, 65);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(568, 250);
            this.panelBuscar.TabIndex = 8;
            // 
            // imgBuscarUsuario
            // 
            this.imgBuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgBuscarUsuario.Image")));
            this.imgBuscarUsuario.Location = new System.Drawing.Point(14, 14);
            this.imgBuscarUsuario.Name = "imgBuscarUsuario";
            this.imgBuscarUsuario.Size = new System.Drawing.Size(105, 101);
            this.imgBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBuscarUsuario.TabIndex = 15;
            this.imgBuscarUsuario.TabStop = false;
            // 
            // lblBuscarUusariosInstrucciones
            // 
            this.lblBuscarUusariosInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBuscarUusariosInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUusariosInstrucciones.Location = new System.Drawing.Point(125, 14);
            this.lblBuscarUusariosInstrucciones.Name = "lblBuscarUusariosInstrucciones";
            this.lblBuscarUusariosInstrucciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBuscarUusariosInstrucciones.Size = new System.Drawing.Size(424, 104);
            this.lblBuscarUusariosInstrucciones.TabIndex = 12;
            this.lblBuscarUusariosInstrucciones.Text = resources.GetString("lblBuscarUusariosInstrucciones.Text");
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(154, 177);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(100, 37);
            this.btnLimpiarBuscar.TabIndex = 14;
            this.btnLimpiarBuscar.Text = "Limpiar";
            this.btnLimpiarBuscar.UseVisualStyleBackColor = true;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // cmbBuscarFiltro
            // 
            this.cmbBuscarFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarFiltro.FormattingEnabled = true;
            this.cmbBuscarFiltro.Location = new System.Drawing.Point(14, 141);
            this.cmbBuscarFiltro.Name = "cmbBuscarFiltro";
            this.cmbBuscarFiltro.Size = new System.Drawing.Size(100, 21);
            this.cmbBuscarFiltro.TabIndex = 11;
            this.cmbBuscarFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarFiltro_SelectedIndexChanged);
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(11, 126);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(61, 13);
            this.lblBuscarUsuario.TabIndex = 10;
            this.lblBuscarUsuario.Text = "Buscar por:";
            // 
            // lblIdBuscar
            // 
            this.lblIdBuscar.AutoSize = true;
            this.lblIdBuscar.Location = new System.Drawing.Point(119, 126);
            this.lblIdBuscar.Name = "lblIdBuscar";
            this.lblIdBuscar.Size = new System.Drawing.Size(83, 13);
            this.lblIdBuscar.TabIndex = 9;
            this.lblIdBuscar.Text = "N° Identificador:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Location = new System.Drawing.Point(122, 142);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // cmbPermisosBuscar
            // 
            this.cmbPermisosBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermisosBuscar.Enabled = false;
            this.cmbPermisosBuscar.FormattingEnabled = true;
            this.cmbPermisosBuscar.Location = new System.Drawing.Point(454, 141);
            this.cmbPermisosBuscar.Name = "cmbPermisosBuscar";
            this.cmbPermisosBuscar.Size = new System.Drawing.Size(101, 21);
            this.cmbPermisosBuscar.TabIndex = 7;
            this.cmbPermisosBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbPermisosBuscar_SelectedIndexChanged);
            // 
            // lblPermisosBuscar
            // 
            this.lblPermisosBuscar.AutoSize = true;
            this.lblPermisosBuscar.Location = new System.Drawing.Point(451, 126);
            this.lblPermisosBuscar.Name = "lblPermisosBuscar";
            this.lblPermisosBuscar.Size = new System.Drawing.Size(49, 13);
            this.lblPermisosBuscar.TabIndex = 6;
            this.lblPermisosBuscar.Text = "Permisos";
            // 
            // lblContrseñaBuscar
            // 
            this.lblContrseñaBuscar.AutoSize = true;
            this.lblContrseñaBuscar.Location = new System.Drawing.Point(339, 126);
            this.lblContrseñaBuscar.Name = "lblContrseñaBuscar";
            this.lblContrseñaBuscar.Size = new System.Drawing.Size(64, 13);
            this.lblContrseñaBuscar.TabIndex = 5;
            this.lblContrseñaBuscar.Text = "Contraseña:";
            // 
            // lblUsuarioBuscar
            // 
            this.lblUsuarioBuscar.AutoSize = true;
            this.lblUsuarioBuscar.Location = new System.Drawing.Point(230, 126);
            this.lblUsuarioBuscar.Name = "lblUsuarioBuscar";
            this.lblUsuarioBuscar.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioBuscar.TabIndex = 4;
            this.lblUsuarioBuscar.Text = "Usuario:";
            // 
            // txtContraseñaBuscar
            // 
            this.txtContraseñaBuscar.Enabled = false;
            this.txtContraseñaBuscar.Location = new System.Drawing.Point(342, 142);
            this.txtContraseñaBuscar.Name = "txtContraseñaBuscar";
            this.txtContraseñaBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaBuscar.TabIndex = 3;
            // 
            // txtUsuarioBuscar
            // 
            this.txtUsuarioBuscar.Enabled = false;
            this.txtUsuarioBuscar.Location = new System.Drawing.Point(233, 142);
            this.txtUsuarioBuscar.Name = "txtUsuarioBuscar";
            this.txtUsuarioBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioBuscar.TabIndex = 1;
            this.txtUsuarioBuscar.TextChanged += new System.EventHandler(this.txtUsuarioBuscar_TextChanged);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Enabled = false;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(260, 176);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(139, 38);
            this.btnBuscarUsuario.TabIndex = 0;
            this.btnBuscarUsuario.Text = "Buscar usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
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
            this.panelActualizar.Location = new System.Drawing.Point(3, 66);
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
            this.btnEliminarUs.Click += new System.EventHandler(this.btnEliminarUs_Click);
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.Location = new System.Drawing.Point(28, 177);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(139, 38);
            this.btnLimpiarAct.TabIndex = 13;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = true;
            this.btnLimpiarAct.Click += new System.EventHandler(this.btnLimpiarAct_Click);
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
            this.txtContraActualizar.TextChanged += new System.EventHandler(this.txtContraActualizar_TextChanged);
            // 
            // txtUsuarioActualizar
            // 
            this.txtUsuarioActualizar.Location = new System.Drawing.Point(135, 151);
            this.txtUsuarioActualizar.Name = "txtUsuarioActualizar";
            this.txtUsuarioActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioActualizar.TabIndex = 1;
            this.txtUsuarioActualizar.TextChanged += new System.EventHandler(this.txtUsuarioActualizar_TextChanged);
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
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelAcciones.Controls.Add(this.panelCrear);
            this.panelAcciones.Controls.Add(this.panelActualizar);
            this.panelAcciones.Controls.Add(this.panelBuscar);
            this.panelAcciones.Controls.Add(this.dgvUsuarios);
            this.panelAcciones.Controls.Add(this.panelOpciones);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcciones.Location = new System.Drawing.Point(0, 0);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(1017, 325);
            this.panelAcciones.TabIndex = 16;
            // 
            // frmUsuariosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 323);
            this.Controls.Add(this.panelAcciones);
            this.Name = "frmUsuariosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.clsUsuariosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrearUsuario)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarUsuario)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbPermisos;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCrearUs;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.ComboBox cmbPermisosBuscar;
        private System.Windows.Forms.Label lblPermisosBuscar;
        private System.Windows.Forms.Label lblContrseñaBuscar;
        private System.Windows.Forms.Label lblUsuarioBuscar;
        private System.Windows.Forms.TextBox txtContraseñaBuscar;
        private System.Windows.Forms.TextBox txtUsuarioBuscar;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label lblIdBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarFiltro;
        private System.Windows.Forms.Label lblBuscarUsuario;
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
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnLimpiarBuscar;
        private System.Windows.Forms.CheckBox chkMensaje;
        private System.Windows.Forms.Button btnEliminarUs;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Label lblCrearUsuarioInstrucciones;
        private System.Windows.Forms.PictureBox imgCrearUsuario;
        private System.Windows.Forms.PictureBox imgBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUusariosInstrucciones;
        private System.Windows.Forms.PictureBox imgActualizarEliminarUsuario;
        private System.Windows.Forms.Label lblActualizarEliminarUsuarioInstrucciones;
    }
}