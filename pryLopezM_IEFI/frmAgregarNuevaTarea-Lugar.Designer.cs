using System;

namespace pryLopezM_IEFI
{
    partial class frmAgregarNuevaTarea_Lugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarNuevaTarea_Lugar));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTituloRegistrarTarea = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAuditoriaInstrucciones = new System.Windows.Forms.Label();
            this.imgRegistrarTarea = new System.Windows.Forms.PictureBox();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNuevaTareaLugar = new System.Windows.Forms.TextBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblAgregarEliminar = new System.Windows.Forms.Label();
            this.btnAñadirEliminar = new System.Windows.Forms.Button();
            this.cmbTareaLugar = new System.Windows.Forms.ComboBox();
            this.cmbAñadirEliminar = new System.Windows.Forms.ComboBox();
            this.panelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRegistrarTarea)).BeginInit();
            this.panelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitulo.Controls.Add(this.lblTituloRegistrarTarea);
            this.panelTitulo.Controls.Add(this.btnHome);
            this.panelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitulo.Location = new System.Drawing.Point(21, 12);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(656, 60);
            this.panelTitulo.TabIndex = 40;
            // 
            // lblTituloRegistrarTarea
            // 
            this.lblTituloRegistrarTarea.AutoSize = true;
            this.lblTituloRegistrarTarea.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTituloRegistrarTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistrarTarea.Location = new System.Drawing.Point(62, 11);
            this.lblTituloRegistrarTarea.Name = "lblTituloRegistrarTarea";
            this.lblTituloRegistrarTarea.Size = new System.Drawing.Size(593, 39);
            this.lblTituloRegistrarTarea.TabIndex = 35;
            this.lblTituloRegistrarTarea.Text = "Agregar nueva Tarea/Lugar";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblAuditoriaInstrucciones);
            this.panel1.Controls.Add(this.imgRegistrarTarea);
            this.panel1.Location = new System.Drawing.Point(21, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 128);
            this.panel1.TabIndex = 38;
            // 
            // lblAuditoriaInstrucciones
            // 
            this.lblAuditoriaInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAuditoriaInstrucciones.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoriaInstrucciones.Location = new System.Drawing.Point(139, 13);
            this.lblAuditoriaInstrucciones.Name = "lblAuditoriaInstrucciones";
            this.lblAuditoriaInstrucciones.Size = new System.Drawing.Size(500, 108);
            this.lblAuditoriaInstrucciones.TabIndex = 4;
            this.lblAuditoriaInstrucciones.Text = "Para agregar una nueva Tarea/Lugar, deberá elegir desde el combobox, la opción qu" +
    "e necesite, recuerde que si no completa todos los campos, el botón no se habilit" +
    "ará.";
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
            // panelRegistro
            // 
            this.panelRegistro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelRegistro.Controls.Add(this.btnLimpiar);
            this.panelRegistro.Controls.Add(this.txtNuevaTareaLugar);
            this.panelRegistro.Controls.Add(this.lblOpcion);
            this.panelRegistro.Controls.Add(this.lblAgregarEliminar);
            this.panelRegistro.Controls.Add(this.btnAñadirEliminar);
            this.panelRegistro.Controls.Add(this.cmbTareaLugar);
            this.panelRegistro.Controls.Add(this.cmbAñadirEliminar);
            this.panelRegistro.Location = new System.Drawing.Point(134, 212);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(415, 155);
            this.panelRegistro.TabIndex = 39;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.FlatAppearance.BorderSize = 3;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(25, 93);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(46, 40);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNuevaTareaLugar
            // 
            this.txtNuevaTareaLugar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaTareaLugar.Location = new System.Drawing.Point(203, 45);
            this.txtNuevaTareaLugar.Name = "txtNuevaTareaLugar";
            this.txtNuevaTareaLugar.Size = new System.Drawing.Size(186, 29);
            this.txtNuevaTareaLugar.TabIndex = 17;
            this.txtNuevaTareaLugar.Visible = false;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(21, 21);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(137, 21);
            this.lblOpcion.TabIndex = 1;
            this.lblOpcion.Text = "Seleccione:";
            // 
            // lblAgregarEliminar
            // 
            this.lblAgregarEliminar.AutoSize = true;
            this.lblAgregarEliminar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEliminar.Location = new System.Drawing.Point(199, 21);
            this.lblAgregarEliminar.Name = "lblAgregarEliminar";
            this.lblAgregarEliminar.Size = new System.Drawing.Size(85, 21);
            this.lblAgregarEliminar.TabIndex = 2;
            this.lblAgregarEliminar.Text = "Opción";
            this.lblAgregarEliminar.Visible = false;
            // 
            // btnAñadirEliminar
            // 
            this.btnAñadirEliminar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAñadirEliminar.FlatAppearance.BorderSize = 3;
            this.btnAñadirEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirEliminar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEliminar.Location = new System.Drawing.Point(141, 93);
            this.btnAñadirEliminar.Name = "btnAñadirEliminar";
            this.btnAñadirEliminar.Size = new System.Drawing.Size(134, 36);
            this.btnAñadirEliminar.TabIndex = 16;
            this.btnAñadirEliminar.Text = "Grabar";
            this.btnAñadirEliminar.UseVisualStyleBackColor = false;
            this.btnAñadirEliminar.Visible = false;
            this.btnAñadirEliminar.Click += new System.EventHandler(this.btnAñadirEliminar_Click);
            // 
            // cmbTareaLugar
            // 
            this.cmbTareaLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTareaLugar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTareaLugar.FormattingEnabled = true;
            this.cmbTareaLugar.Items.AddRange(new object[] {
            "Añadir Tarea",
            "Añadir Lugar",
            "Eliminar Tarea",
            "Eliminar Lugar"});
            this.cmbTareaLugar.Location = new System.Drawing.Point(25, 45);
            this.cmbTareaLugar.Name = "cmbTareaLugar";
            this.cmbTareaLugar.Size = new System.Drawing.Size(172, 29);
            this.cmbTareaLugar.TabIndex = 4;
            this.cmbTareaLugar.SelectedIndexChanged += new System.EventHandler(this.cmbTareaLugar_SelectedIndexChanged);
            // 
            // cmbAñadirEliminar
            // 
            this.cmbAñadirEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAñadirEliminar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAñadirEliminar.FormattingEnabled = true;
            this.cmbAñadirEliminar.Items.AddRange(new object[] {
            "Empresa",
            "Servicio",
            "Oficina"});
            this.cmbAñadirEliminar.Location = new System.Drawing.Point(203, 45);
            this.cmbAñadirEliminar.Name = "cmbAñadirEliminar";
            this.cmbAñadirEliminar.Size = new System.Drawing.Size(144, 29);
            this.cmbAñadirEliminar.TabIndex = 5;
            this.cmbAñadirEliminar.Visible = false;
            // 
            // frmAgregarNuevaTarea_Lugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 375);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarNuevaTarea_Lugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarNuevaTarea_Lugar";
            this.Load += new System.EventHandler(this.frmAgregarNuevaTarea_Lugar_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRegistrarTarea)).EndInit();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloRegistrarTarea;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAuditoriaInstrucciones;
        private System.Windows.Forms.PictureBox imgRegistrarTarea;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Button btnAñadirEliminar;
        private System.Windows.Forms.ComboBox cmbTareaLugar;
        private System.Windows.Forms.ComboBox cmbAñadirEliminar;
        private System.Windows.Forms.TextBox txtNuevaTareaLugar;
        private System.Windows.Forms.Label lblAgregarEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}