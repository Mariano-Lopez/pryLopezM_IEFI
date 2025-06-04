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
            this.lblEstudioTarea = new System.Windows.Forms.CheckBox();
            this.chkVacacionTarea = new System.Windows.Forms.CheckBox();
            this.lblLicenciaTarea = new System.Windows.Forms.Label();
            this.chkInsumo = new System.Windows.Forms.CheckBox();
            this.btnCancelarTarea = new System.Windows.Forms.Button();
            this.btnGrabarTarea = new System.Windows.Forms.Button();
            this.txtComentarioTarea = new System.Windows.Forms.TextBox();
            this.lblComentarioTarea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.mrcDetalleTarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaTarea
            // 
            this.lblFechaTarea.AutoSize = true;
            this.lblFechaTarea.Location = new System.Drawing.Point(9, 11);
            this.lblFechaTarea.Name = "lblFechaTarea";
            this.lblFechaTarea.Size = new System.Drawing.Size(40, 13);
            this.lblFechaTarea.TabIndex = 0;
            this.lblFechaTarea.Text = "Fecha:";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(9, 59);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(38, 13);
            this.lblTarea.TabIndex = 1;
            this.lblTarea.Text = "Tarea:";
            // 
            // lblLugarTarea
            // 
            this.lblLugarTarea.AutoSize = true;
            this.lblLugarTarea.Location = new System.Drawing.Point(9, 103);
            this.lblLugarTarea.Name = "lblLugarTarea";
            this.lblLugarTarea.Size = new System.Drawing.Size(37, 13);
            this.lblLugarTarea.TabIndex = 2;
            this.lblLugarTarea.Text = "Lugar:";
            // 
            // dtpFechaTarea
            // 
            this.dtpFechaTarea.Location = new System.Drawing.Point(12, 27);
            this.dtpFechaTarea.Name = "dtpFechaTarea";
            this.dtpFechaTarea.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTarea.TabIndex = 3;
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(12, 75);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbTarea.TabIndex = 4;
            // 
            // cmbLugarTarea
            // 
            this.cmbLugarTarea.FormattingEnabled = true;
            this.cmbLugarTarea.Location = new System.Drawing.Point(12, 119);
            this.cmbLugarTarea.Name = "cmbLugarTarea";
            this.cmbLugarTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbLugarTarea.TabIndex = 5;
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(12, 150);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(443, 156);
            this.dgvTareas.TabIndex = 6;
            // 
            // lblUniformeTarea
            // 
            this.lblUniformeTarea.AutoSize = true;
            this.lblUniformeTarea.Location = new System.Drawing.Point(7, 16);
            this.lblUniformeTarea.Name = "lblUniformeTarea";
            this.lblUniformeTarea.Size = new System.Drawing.Size(49, 13);
            this.lblUniformeTarea.TabIndex = 7;
            this.lblUniformeTarea.Text = "Uniforme";
            // 
            // mrcDetalleTarea
            // 
            this.mrcDetalleTarea.Controls.Add(this.chkSalarioTarea);
            this.mrcDetalleTarea.Controls.Add(this.chkReciboTarea);
            this.mrcDetalleTarea.Controls.Add(this.lblReclamoTarea);
            this.mrcDetalleTarea.Controls.Add(this.lblEstudioTarea);
            this.mrcDetalleTarea.Controls.Add(this.chkVacacionTarea);
            this.mrcDetalleTarea.Controls.Add(this.lblLicenciaTarea);
            this.mrcDetalleTarea.Controls.Add(this.chkInsumo);
            this.mrcDetalleTarea.Controls.Add(this.lblUniformeTarea);
            this.mrcDetalleTarea.Location = new System.Drawing.Point(225, 27);
            this.mrcDetalleTarea.Name = "mrcDetalleTarea";
            this.mrcDetalleTarea.Size = new System.Drawing.Size(219, 111);
            this.mrcDetalleTarea.TabIndex = 8;
            this.mrcDetalleTarea.TabStop = false;
            this.mrcDetalleTarea.Text = "Detalle";
            // 
            // chkSalarioTarea
            // 
            this.chkSalarioTarea.AutoSize = true;
            this.chkSalarioTarea.Location = new System.Drawing.Point(119, 34);
            this.chkSalarioTarea.Name = "chkSalarioTarea";
            this.chkSalarioTarea.Size = new System.Drawing.Size(58, 17);
            this.chkSalarioTarea.TabIndex = 14;
            this.chkSalarioTarea.Text = "Salario";
            this.chkSalarioTarea.UseVisualStyleBackColor = true;
            // 
            // chkReciboTarea
            // 
            this.chkReciboTarea.AutoSize = true;
            this.chkReciboTarea.Location = new System.Drawing.Point(119, 57);
            this.chkReciboTarea.Name = "chkReciboTarea";
            this.chkReciboTarea.Size = new System.Drawing.Size(60, 17);
            this.chkReciboTarea.TabIndex = 13;
            this.chkReciboTarea.Text = "Recibo";
            this.chkReciboTarea.UseVisualStyleBackColor = true;
            // 
            // lblReclamoTarea
            // 
            this.lblReclamoTarea.AutoSize = true;
            this.lblReclamoTarea.Location = new System.Drawing.Point(116, 18);
            this.lblReclamoTarea.Name = "lblReclamoTarea";
            this.lblReclamoTarea.Size = new System.Drawing.Size(49, 13);
            this.lblReclamoTarea.TabIndex = 12;
            this.lblReclamoTarea.Text = "Reclamo";
            // 
            // lblEstudioTarea
            // 
            this.lblEstudioTarea.AutoSize = true;
            this.lblEstudioTarea.Location = new System.Drawing.Point(10, 68);
            this.lblEstudioTarea.Name = "lblEstudioTarea";
            this.lblEstudioTarea.Size = new System.Drawing.Size(61, 17);
            this.lblEstudioTarea.TabIndex = 11;
            this.lblEstudioTarea.Text = "Estudio";
            this.lblEstudioTarea.UseVisualStyleBackColor = true;
            // 
            // chkVacacionTarea
            // 
            this.chkVacacionTarea.AutoSize = true;
            this.chkVacacionTarea.Location = new System.Drawing.Point(10, 91);
            this.chkVacacionTarea.Name = "chkVacacionTarea";
            this.chkVacacionTarea.Size = new System.Drawing.Size(71, 17);
            this.chkVacacionTarea.TabIndex = 10;
            this.chkVacacionTarea.Text = "Vacación";
            this.chkVacacionTarea.UseVisualStyleBackColor = true;
            // 
            // lblLicenciaTarea
            // 
            this.lblLicenciaTarea.AutoSize = true;
            this.lblLicenciaTarea.Location = new System.Drawing.Point(7, 52);
            this.lblLicenciaTarea.Name = "lblLicenciaTarea";
            this.lblLicenciaTarea.Size = new System.Drawing.Size(47, 13);
            this.lblLicenciaTarea.TabIndex = 9;
            this.lblLicenciaTarea.Text = "Licencia";
            // 
            // chkInsumo
            // 
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Location = new System.Drawing.Point(10, 32);
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.Size = new System.Drawing.Size(60, 17);
            this.chkInsumo.TabIndex = 8;
            this.chkInsumo.Text = "Insumo";
            this.chkInsumo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTarea
            // 
            this.btnCancelarTarea.Location = new System.Drawing.Point(577, 320);
            this.btnCancelarTarea.Name = "btnCancelarTarea";
            this.btnCancelarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTarea.TabIndex = 15;
            this.btnCancelarTarea.Text = "Cancelar";
            this.btnCancelarTarea.UseVisualStyleBackColor = true;
            // 
            // btnGrabarTarea
            // 
            this.btnGrabarTarea.Location = new System.Drawing.Point(682, 320);
            this.btnGrabarTarea.Name = "btnGrabarTarea";
            this.btnGrabarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnGrabarTarea.TabIndex = 16;
            this.btnGrabarTarea.Text = "Grabar";
            this.btnGrabarTarea.UseVisualStyleBackColor = true;
            // 
            // txtComentarioTarea
            // 
            this.txtComentarioTarea.Location = new System.Drawing.Point(472, 47);
            this.txtComentarioTarea.Multiline = true;
            this.txtComentarioTarea.Name = "txtComentarioTarea";
            this.txtComentarioTarea.Size = new System.Drawing.Size(397, 259);
            this.txtComentarioTarea.TabIndex = 17;
            // 
            // lblComentarioTarea
            // 
            this.lblComentarioTarea.AutoSize = true;
            this.lblComentarioTarea.Location = new System.Drawing.Point(469, 31);
            this.lblComentarioTarea.Name = "lblComentarioTarea";
            this.lblComentarioTarea.Size = new System.Drawing.Size(63, 13);
            this.lblComentarioTarea.TabIndex = 15;
            this.lblComentarioTarea.Text = "Comentario:";
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 351);
            this.Controls.Add(this.lblComentarioTarea);
            this.Controls.Add(this.txtComentarioTarea);
            this.Controls.Add(this.btnGrabarTarea);
            this.Controls.Add(this.btnCancelarTarea);
            this.Controls.Add(this.mrcDetalleTarea);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.cmbLugarTarea);
            this.Controls.Add(this.cmbTarea);
            this.Controls.Add(this.dtpFechaTarea);
            this.Controls.Add(this.lblLugarTarea);
            this.Controls.Add(this.lblTarea);
            this.Controls.Add(this.lblFechaTarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarTarea";
            this.Text = "Registrar tarea";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.mrcDetalleTarea.ResumeLayout(false);
            this.mrcDetalleTarea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox lblEstudioTarea;
        private System.Windows.Forms.CheckBox chkVacacionTarea;
        private System.Windows.Forms.Label lblLicenciaTarea;
        private System.Windows.Forms.CheckBox chkInsumo;
        private System.Windows.Forms.Button btnCancelarTarea;
        private System.Windows.Forms.Button btnGrabarTarea;
        private System.Windows.Forms.TextBox txtComentarioTarea;
        private System.Windows.Forms.Label lblComentarioTarea;
    }
}