namespace pryLopezM_IEFI
{
    partial class frmAuditoria
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
            this.dgvBBDDTablas = new System.Windows.Forms.DataGridView();
            this.lblVisualizarDatos = new System.Windows.Forms.Label();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDDTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBBDDTablas
            // 
            this.dgvBBDDTablas.AllowUserToAddRows = false;
            this.dgvBBDDTablas.AllowUserToDeleteRows = false;
            this.dgvBBDDTablas.AllowUserToResizeColumns = false;
            this.dgvBBDDTablas.AllowUserToResizeRows = false;
            this.dgvBBDDTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBBDDTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBBDDTablas.Location = new System.Drawing.Point(32, 49);
            this.dgvBBDDTablas.MultiSelect = false;
            this.dgvBBDDTablas.Name = "dgvBBDDTablas";
            this.dgvBBDDTablas.ReadOnly = true;
            this.dgvBBDDTablas.RowHeadersVisible = false;
            this.dgvBBDDTablas.Size = new System.Drawing.Size(732, 397);
            this.dgvBBDDTablas.TabIndex = 0;
            // 
            // lblVisualizarDatos
            // 
            this.lblVisualizarDatos.AutoSize = true;
            this.lblVisualizarDatos.Location = new System.Drawing.Point(29, 23);
            this.lblVisualizarDatos.Name = "lblVisualizarDatos";
            this.lblVisualizarDatos.Size = new System.Drawing.Size(45, 13);
            this.lblVisualizarDatos.TabIndex = 1;
            this.lblVisualizarDatos.Text = "Mostrar:";
            // 
            // cmbTablas
            // 
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(80, 20);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(121, 21);
            this.cmbTablas.TabIndex = 2;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.lblVisualizarDatos);
            this.Controls.Add(this.dgvBBDDTablas);
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDDTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBBDDTablas;
        private System.Windows.Forms.Label lblVisualizarDatos;
        private System.Windows.Forms.ComboBox cmbTablas;
    }
}