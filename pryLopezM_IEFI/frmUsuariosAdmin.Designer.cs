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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panelCrear = new System.Windows.Forms.Panel();
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCrearUs = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtActualizar = new System.Windows.Forms.TextBox();
            this.cmbPermisosActualizar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContraseñaActualizar = new System.Windows.Forms.TextBox();
            this.txtUsuarioActualizar = new System.Windows.Forms.TextBox();
            this.btnActualizarUs = new System.Windows.Forms.Button();
            this.btnObtenerUs = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkMensaje = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.panelCrear.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(196, 229);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(695, 317);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelOpciones.Controls.Add(this.panel1);
            this.panelOpciones.Controls.Add(this.btnBorrar);
            this.panelOpciones.Controls.Add(this.btnActualizar);
            this.panelOpciones.Controls.Add(this.btnBuscar);
            this.panelOpciones.Controls.Add(this.btnCrear);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(180, 558);
            this.panelOpciones.TabIndex = 1;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrar.Location = new System.Drawing.Point(0, 156);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(180, 52);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar usuario";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizar.Location = new System.Drawing.Point(0, 104);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 52);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar usuario";
            this.btnActualizar.UseVisualStyleBackColor = true;
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
            // 
            // panelCrear
            // 
            this.panelCrear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelCrear.Controls.Add(this.panelBuscar);
            this.panelCrear.Controls.Add(this.cmbPermisos);
            this.panelCrear.Controls.Add(this.lblPermisos);
            this.panelCrear.Controls.Add(this.lblContraseña);
            this.panelCrear.Controls.Add(this.lblUsuario);
            this.panelCrear.Controls.Add(this.txtContra);
            this.panelCrear.Controls.Add(this.txtUsuario);
            this.panelCrear.Controls.Add(this.btnCrearUs);
            this.panelCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrear.Location = new System.Drawing.Point(180, 0);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Size = new System.Drawing.Size(727, 217);
            this.panelCrear.TabIndex = 4;
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(250, 106);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(121, 21);
            this.cmbPermisos.TabIndex = 7;
            this.cmbPermisos.SelectedIndexChanged += new System.EventHandler(this.cmbPermisos_SelectedIndexChanged);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(247, 91);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(49, 13);
            this.lblPermisos.TabIndex = 6;
            this.lblPermisos.Text = "Permisos";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(129, 91);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(11, 91);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(132, 107);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 3;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(14, 107);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnCrearUs
            // 
            this.btnCrearUs.Enabled = false;
            this.btnCrearUs.Location = new System.Drawing.Point(105, 156);
            this.btnCrearUs.Name = "btnCrearUs";
            this.btnCrearUs.Size = new System.Drawing.Size(139, 38);
            this.btnCrearUs.TabIndex = 0;
            this.btnCrearUs.Text = "Crear usuario";
            this.btnCrearUs.UseVisualStyleBackColor = true;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscar.Location = new System.Drawing.Point(0, 0);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(727, 217);
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
            this.btnBuscarUs.Location = new System.Drawing.Point(54, 167);
            this.btnBuscarUs.Name = "btnBuscarUs";
            this.btnBuscarUs.Size = new System.Drawing.Size(139, 38);
            this.btnBuscarUs.TabIndex = 0;
            this.btnBuscarUs.Text = "Buscar usuario";
            this.btnBuscarUs.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.chkMensaje);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnObtenerUs);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtActualizar);
            this.panel1.Controls.Add(this.cmbPermisosActualizar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtContraseñaActualizar);
            this.panel1.Controls.Add(this.txtUsuarioActualizar);
            this.panel1.Controls.Add(this.btnActualizarUs);
            this.panel1.Location = new System.Drawing.Point(72, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 217);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "N° Identificador:";
            // 
            // txtActualizar
            // 
            this.txtActualizar.Enabled = false;
            this.txtActualizar.Location = new System.Drawing.Point(13, 33);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtActualizar.TabIndex = 8;
            // 
            // cmbPermisosActualizar
            // 
            this.cmbPermisosActualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermisosActualizar.Enabled = false;
            this.cmbPermisosActualizar.FormattingEnabled = true;
            this.cmbPermisosActualizar.Location = new System.Drawing.Point(130, 32);
            this.cmbPermisosActualizar.Name = "cmbPermisosActualizar";
            this.cmbPermisosActualizar.Size = new System.Drawing.Size(121, 21);
            this.cmbPermisosActualizar.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Permisos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Contraseña:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Usuario:";
            // 
            // txtContraseñaActualizar
            // 
            this.txtContraseñaActualizar.Enabled = false;
            this.txtContraseñaActualizar.Location = new System.Drawing.Point(131, 82);
            this.txtContraseñaActualizar.Name = "txtContraseñaActualizar";
            this.txtContraseñaActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaActualizar.TabIndex = 3;
            // 
            // txtUsuarioActualizar
            // 
            this.txtUsuarioActualizar.Location = new System.Drawing.Point(13, 82);
            this.txtUsuarioActualizar.Name = "txtUsuarioActualizar";
            this.txtUsuarioActualizar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioActualizar.TabIndex = 1;
            // 
            // btnActualizarUs
            // 
            this.btnActualizarUs.Enabled = false;
            this.btnActualizarUs.Location = new System.Drawing.Point(158, 108);
            this.btnActualizarUs.Name = "btnActualizarUs";
            this.btnActualizarUs.Size = new System.Drawing.Size(139, 38);
            this.btnActualizarUs.TabIndex = 0;
            this.btnActualizarUs.Text = "Actualizar usuario";
            this.btnActualizarUs.UseVisualStyleBackColor = true;
            // 
            // btnObtenerUs
            // 
            this.btnObtenerUs.Location = new System.Drawing.Point(13, 108);
            this.btnObtenerUs.Name = "btnObtenerUs";
            this.btnObtenerUs.Size = new System.Drawing.Size(139, 25);
            this.btnObtenerUs.TabIndex = 12;
            this.btnObtenerUs.Text = "Cargar usuario";
            this.btnObtenerUs.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(13, 139);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // chkMensaje
            // 
            this.chkMensaje.AutoSize = true;
            this.chkMensaje.Location = new System.Drawing.Point(158, 145);
            this.chkMensaje.Name = "chkMensaje";
            this.chkMensaje.Size = new System.Drawing.Size(144, 17);
            this.chkMensaje.TabIndex = 14;
            this.chkMensaje.Text = "Mensaje de confirmación";
            this.chkMensaje.UseVisualStyleBackColor = true;
            // 
            // frmUsuariosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 558);
            this.Controls.Add(this.panelCrear);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnBorrar;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtActualizar;
        private System.Windows.Forms.ComboBox cmbPermisosActualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContraseñaActualizar;
        private System.Windows.Forms.TextBox txtUsuarioActualizar;
        private System.Windows.Forms.Button btnActualizarUs;
        private System.Windows.Forms.Button btnObtenerUs;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkMensaje;
    }
}