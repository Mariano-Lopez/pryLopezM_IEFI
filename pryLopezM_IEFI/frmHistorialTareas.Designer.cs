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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbFiltrarTarea = new System.Windows.Forms.ComboBox();
            this.lblFIltrarTarea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialTarea)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistorialTarea
            // 
            this.dgvHistorialTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialTarea.Location = new System.Drawing.Point(44, 114);
            this.dgvHistorialTarea.Name = "dgvHistorialTarea";
            this.dgvHistorialTarea.Size = new System.Drawing.Size(708, 324);
            this.dgvHistorialTarea.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblFIltrarTarea);
            this.panel1.Controls.Add(this.cmbFiltrarTarea);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 80);
            this.panel1.TabIndex = 1;
            // 
            // cmbFiltrarTarea
            // 
            this.cmbFiltrarTarea.FormattingEnabled = true;
            this.cmbFiltrarTarea.Location = new System.Drawing.Point(324, 27);
            this.cmbFiltrarTarea.Name = "cmbFiltrarTarea";
            this.cmbFiltrarTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrarTarea.TabIndex = 0;
            // 
            // lblFIltrarTarea
            // 
            this.lblFIltrarTarea.AutoSize = true;
            this.lblFIltrarTarea.Location = new System.Drawing.Point(248, 30);
            this.lblFIltrarTarea.Name = "lblFIltrarTarea";
            this.lblFIltrarTarea.Size = new System.Drawing.Size(63, 13);
            this.lblFIltrarTarea.TabIndex = 1;
            this.lblFIltrarTarea.Text = "FIltrar tarea:";
            // 
            // frmHistorialTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHistorialTarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialTareas";
            this.Text = "Historial tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialTarea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialTarea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFiltrarTarea;
        private System.Windows.Forms.Label lblFIltrarTarea;
    }
}