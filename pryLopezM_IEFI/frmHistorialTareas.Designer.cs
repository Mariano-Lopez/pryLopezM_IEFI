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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialTarea)).BeginInit();
            this.panelHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistorialTarea
            // 
            this.dgvHistorialTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialTarea.Location = new System.Drawing.Point(44, 234);
            this.dgvHistorialTarea.Name = "dgvHistorialTarea";
            this.dgvHistorialTarea.Size = new System.Drawing.Size(708, 324);
            this.dgvHistorialTarea.TabIndex = 0;
            // 
            // panelHistorial
            // 
            this.panelHistorial.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelHistorial.Controls.Add(this.btnLimpiar);
            this.panelHistorial.Controls.Add(this.btnFiltrarTarea);
            this.panelHistorial.Controls.Add(this.cmbBusquedaTarea);
            this.panelHistorial.Controls.Add(this.lblCargaDeDato);
            this.panelHistorial.Controls.Add(this.txtBusquedaTarea);
            this.panelHistorial.Controls.Add(this.dtpFechaBusquedaTarea);
            this.panelHistorial.Controls.Add(this.lblTipoDeDato);
            this.panelHistorial.Controls.Add(this.cmbFiltrarTarea);
            this.panelHistorial.Location = new System.Drawing.Point(44, 12);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(708, 192);
            this.panelHistorial.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(300, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 25);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrarTarea
            // 
            this.btnFiltrarTarea.Enabled = false;
            this.btnFiltrarTarea.Location = new System.Drawing.Point(392, 142);
            this.btnFiltrarTarea.Name = "btnFiltrarTarea";
            this.btnFiltrarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarTarea.TabIndex = 7;
            this.btnFiltrarTarea.Text = "Filtrar tarea";
            this.btnFiltrarTarea.UseVisualStyleBackColor = true;
            this.btnFiltrarTarea.Click += new System.EventHandler(this.btnFiltrarTarea_Click);
            // 
            // cmbBusquedaTarea
            // 
            this.cmbBusquedaTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusquedaTarea.FormattingEnabled = true;
            this.cmbBusquedaTarea.Location = new System.Drawing.Point(451, 90);
            this.cmbBusquedaTarea.Name = "cmbBusquedaTarea";
            this.cmbBusquedaTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbBusquedaTarea.TabIndex = 6;
            this.cmbBusquedaTarea.Visible = false;
            this.cmbBusquedaTarea.SelectedIndexChanged += new System.EventHandler(this.cmbBusquedaTarea_SelectedIndexChanged);
            // 
            // lblCargaDeDato
            // 
            this.lblCargaDeDato.AutoSize = true;
            this.lblCargaDeDato.Location = new System.Drawing.Point(242, 70);
            this.lblCargaDeDato.Name = "lblCargaDeDato";
            this.lblCargaDeDato.Size = new System.Drawing.Size(133, 13);
            this.lblCargaDeDato.TabIndex = 5;
            this.lblCargaDeDato.Text = "Tipo de dato seleccionado";
            // 
            // txtBusquedaTarea
            // 
            this.txtBusquedaTarea.Location = new System.Drawing.Point(245, 116);
            this.txtBusquedaTarea.Name = "txtBusquedaTarea";
            this.txtBusquedaTarea.Size = new System.Drawing.Size(200, 20);
            this.txtBusquedaTarea.TabIndex = 4;
            this.txtBusquedaTarea.Visible = false;
            this.txtBusquedaTarea.TextChanged += new System.EventHandler(this.txtBusquedaTarea_TextChanged);
            this.txtBusquedaTarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaTarea_KeyPress);
            // 
            // dtpFechaBusquedaTarea
            // 
            this.dtpFechaBusquedaTarea.Location = new System.Drawing.Point(245, 90);
            this.dtpFechaBusquedaTarea.Name = "dtpFechaBusquedaTarea";
            this.dtpFechaBusquedaTarea.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaBusquedaTarea.TabIndex = 3;
            this.dtpFechaBusquedaTarea.Visible = false;
            // 
            // lblTipoDeDato
            // 
            this.lblTipoDeDato.AutoSize = true;
            this.lblTipoDeDato.Location = new System.Drawing.Point(170, 30);
            this.lblTipoDeDato.Name = "lblTipoDeDato";
            this.lblTipoDeDato.Size = new System.Drawing.Size(148, 13);
            this.lblTipoDeDato.TabIndex = 2;
            this.lblTipoDeDato.Text = "Seleccione tipo de búsqueda:";
            // 
            // cmbFiltrarTarea
            // 
            this.cmbFiltrarTarea.FormattingEnabled = true;
            this.cmbFiltrarTarea.Items.AddRange(new object[] {
            "Fecha de tarea",
            "Fecha de registro",
            "Tarea",
            "Lugar",
            "Detalle",
            "Comentario",
            "Usuario"});
            this.cmbFiltrarTarea.Location = new System.Drawing.Point(324, 27);
            this.cmbFiltrarTarea.Name = "cmbFiltrarTarea";
            this.cmbFiltrarTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrarTarea.TabIndex = 0;
            this.cmbFiltrarTarea.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarTarea_SelectedIndexChanged);
            // 
            // frmHistorialTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.panelHistorial);
            this.Controls.Add(this.dgvHistorialTarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialTareas";
            this.Text = "Historial tareas";
            this.Load += new System.EventHandler(this.frmHistorialTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialTarea)).EndInit();
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
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
    }
}