namespace pryLopezM_IEFI
{
    partial class frmHistorialTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialTareas));
            this.dgvHistorialTarea = new System.Windows.Forms.DataGridView();
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrarTarea = new System.Windows.Forms.Button();
            this.cmbBusquedaTarea = new System.Windows.Forms.ComboBox();
            this.lblCargaDeDato = new System.Windows.Forms.Label();
            this.txtBusquedaTarea = new System.Windows.Forms.TextBox();
            this.dtpFechaBusquedaTarea = new System.Windows.Forms.DateTimePicker();
            this.lblTipoDeDato = new System.Windows.Forms.Label();
            this.cmbFiltrarTarea = new System.Windows.Forms.ComboBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTituloHistorialTarea = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelAuditoria = new System.Windows.Forms.Panel();
            this.imgHistorial = new System.Windows.Forms.PictureBox();
            this.lblHistorialAuditorias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialTarea)).BeginInit();
            this.panelHistorial.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialTarea
            // 
            this.dgvHistorialTarea.AllowUserToAddRows = false;
            this.dgvHistorialTarea.AllowUserToDeleteRows = false;
            this.dgvHistorialTarea.AllowUserToResizeColumns = false;
            this.dgvHistorialTarea.AllowUserToResizeRows = false;
            this.dgvHistorialTarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorialTarea.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialTarea.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialTarea.GridColor = System.Drawing.Color.White;
            this.dgvHistorialTarea.Location = new System.Drawing.Point(9, 442);
            this.dgvHistorialTarea.MultiSelect = false;
            this.dgvHistorialTarea.Name = "dgvHistorialTarea";
            this.dgvHistorialTarea.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorialTarea.RowHeadersVisible = false;
            this.dgvHistorialTarea.ShowCellErrors = false;
            this.dgvHistorialTarea.Size = new System.Drawing.Size(1183, 240);
            this.dgvHistorialTarea.TabIndex = 0;
            // 
            // panelHistorial
            // 
            this.panelHistorial.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelHistorial.Controls.Add(this.btnLimpiar);
            this.panelHistorial.Controls.Add(this.btnFiltrarTarea);
            this.panelHistorial.Controls.Add(this.cmbBusquedaTarea);
            this.panelHistorial.Controls.Add(this.lblCargaDeDato);
            this.panelHistorial.Controls.Add(this.txtBusquedaTarea);
            this.panelHistorial.Controls.Add(this.dtpFechaBusquedaTarea);
            this.panelHistorial.Controls.Add(this.lblTipoDeDato);
            this.panelHistorial.Controls.Add(this.cmbFiltrarTarea);
            this.panelHistorial.Location = new System.Drawing.Point(280, 244);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(708, 192);
            this.panelHistorial.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 3;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(173, 124);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 50);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrarTarea
            // 
            this.btnFiltrarTarea.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFiltrarTarea.Enabled = false;
            this.btnFiltrarTarea.FlatAppearance.BorderSize = 3;
            this.btnFiltrarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarTarea.Location = new System.Drawing.Point(318, 131);
            this.btnFiltrarTarea.Name = "btnFiltrarTarea";
            this.btnFiltrarTarea.Size = new System.Drawing.Size(155, 37);
            this.btnFiltrarTarea.TabIndex = 7;
            this.btnFiltrarTarea.Text = "Filtrar tarea";
            this.btnFiltrarTarea.UseVisualStyleBackColor = false;
            this.btnFiltrarTarea.Click += new System.EventHandler(this.btnFiltrarTarea_Click);
            // 
            // cmbBusquedaTarea
            // 
            this.cmbBusquedaTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusquedaTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusquedaTarea.FormattingEnabled = true;
            this.cmbBusquedaTarea.Location = new System.Drawing.Point(183, 71);
            this.cmbBusquedaTarea.Name = "cmbBusquedaTarea";
            this.cmbBusquedaTarea.Size = new System.Drawing.Size(121, 26);
            this.cmbBusquedaTarea.TabIndex = 6;
            this.cmbBusquedaTarea.Visible = false;
            this.cmbBusquedaTarea.SelectedIndexChanged += new System.EventHandler(this.cmbBusquedaTarea_SelectedIndexChanged);
            // 
            // lblCargaDeDato
            // 
            this.lblCargaDeDato.AutoSize = true;
            this.lblCargaDeDato.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaDeDato.Location = new System.Drawing.Point(180, 50);
            this.lblCargaDeDato.Name = "lblCargaDeDato";
            this.lblCargaDeDato.Size = new System.Drawing.Size(242, 18);
            this.lblCargaDeDato.TabIndex = 5;
            this.lblCargaDeDato.Text = "Tipo de dato seleccionado";
            this.lblCargaDeDato.Visible = false;
            // 
            // txtBusquedaTarea
            // 
            this.txtBusquedaTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaTarea.Location = new System.Drawing.Point(183, 72);
            this.txtBusquedaTarea.Name = "txtBusquedaTarea";
            this.txtBusquedaTarea.Size = new System.Drawing.Size(200, 25);
            this.txtBusquedaTarea.TabIndex = 4;
            this.txtBusquedaTarea.Visible = false;
            this.txtBusquedaTarea.TextChanged += new System.EventHandler(this.txtBusquedaTarea_TextChanged);
            this.txtBusquedaTarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaTarea_KeyPress);
            // 
            // dtpFechaBusquedaTarea
            // 
            this.dtpFechaBusquedaTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusquedaTarea.Location = new System.Drawing.Point(183, 70);
            this.dtpFechaBusquedaTarea.Name = "dtpFechaBusquedaTarea";
            this.dtpFechaBusquedaTarea.Size = new System.Drawing.Size(302, 22);
            this.dtpFechaBusquedaTarea.TabIndex = 3;
            this.dtpFechaBusquedaTarea.Visible = false;
            // 
            // lblTipoDeDato
            // 
            this.lblTipoDeDato.AutoSize = true;
            this.lblTipoDeDato.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeDato.Location = new System.Drawing.Point(9, 14);
            this.lblTipoDeDato.Name = "lblTipoDeDato";
            this.lblTipoDeDato.Size = new System.Drawing.Size(269, 18);
            this.lblTipoDeDato.TabIndex = 2;
            this.lblTipoDeDato.Text = "Seleccione tipo de búsqueda:";
            // 
            // cmbFiltrarTarea
            // 
            this.cmbFiltrarTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarTarea.FormattingEnabled = true;
            this.cmbFiltrarTarea.Items.AddRange(new object[] {
            "Fecha de tarea",
            "Fecha de registro",
            "Tarea",
            "Lugar",
            "Detalle",
            "Comentario",
            "Usuario"});
            this.cmbFiltrarTarea.Location = new System.Drawing.Point(283, 13);
            this.cmbFiltrarTarea.Name = "cmbFiltrarTarea";
            this.cmbFiltrarTarea.Size = new System.Drawing.Size(223, 23);
            this.cmbFiltrarTarea.TabIndex = 0;
            this.cmbFiltrarTarea.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarTarea_SelectedIndexChanged);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitulo.Controls.Add(this.lblTituloHistorialTarea);
            this.panelTitulo.Controls.Add(this.btnHome);
            this.panelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitulo.Location = new System.Drawing.Point(282, 12);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(404, 60);
            this.panelTitulo.TabIndex = 37;
            // 
            // lblTituloHistorialTarea
            // 
            this.lblTituloHistorialTarea.AutoSize = true;
            this.lblTituloHistorialTarea.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTituloHistorialTarea.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistorialTarea.Location = new System.Drawing.Point(59, 12);
            this.lblTituloHistorialTarea.Name = "lblTituloHistorialTarea";
            this.lblTituloHistorialTarea.Size = new System.Drawing.Size(347, 39);
            this.lblTituloHistorialTarea.TabIndex = 35;
            this.lblTituloHistorialTarea.Text = "Historial tareas";
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
            // panelAuditoria
            // 
            this.panelAuditoria.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelAuditoria.Controls.Add(this.imgHistorial);
            this.panelAuditoria.Controls.Add(this.lblHistorialAuditorias);
            this.panelAuditoria.Location = new System.Drawing.Point(280, 78);
            this.panelAuditoria.Name = "panelAuditoria";
            this.panelAuditoria.Size = new System.Drawing.Size(708, 160);
            this.panelAuditoria.TabIndex = 38;
            // 
            // imgHistorial
            // 
            this.imgHistorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgHistorial.BackgroundImage")));
            this.imgHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHistorial.Location = new System.Drawing.Point(12, 13);
            this.imgHistorial.Name = "imgHistorial";
            this.imgHistorial.Size = new System.Drawing.Size(107, 113);
            this.imgHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHistorial.TabIndex = 19;
            this.imgHistorial.TabStop = false;
            // 
            // lblHistorialAuditorias
            // 
            this.lblHistorialAuditorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHistorialAuditorias.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialAuditorias.Location = new System.Drawing.Point(125, 13);
            this.lblHistorialAuditorias.Name = "lblHistorialAuditorias";
            this.lblHistorialAuditorias.Size = new System.Drawing.Size(569, 139);
            this.lblHistorialAuditorias.TabIndex = 3;
            this.lblHistorialAuditorias.Text = "Seleccione los datos a filtrar sino el botón no se habilitará, si no sabe el ID d" +
    "el usuario le recomendamos ir a la pestaña de \"Usuarios\"-\"Buscar usuario\".";
            // 
            // frmHistorialTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 697);
            this.Controls.Add(this.panelAuditoria);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelHistorial);
            this.Controls.Add(this.dgvHistorialTarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial tareas";
            this.Load += new System.EventHandler(this.frmHistorialTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialTarea)).EndInit();
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelAuditoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialTarea;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.ComboBox cmbFiltrarTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaBusquedaTarea;
        private System.Windows.Forms.Label lblTipoDeDato;
        private System.Windows.Forms.Label lblCargaDeDato;
        private System.Windows.Forms.TextBox txtBusquedaTarea;
        private System.Windows.Forms.ComboBox cmbBusquedaTarea;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFiltrarTarea;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloHistorialTarea;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelAuditoria;
        private System.Windows.Forms.PictureBox imgHistorial;
        private System.Windows.Forms.Label lblHistorialAuditorias;
    }
}