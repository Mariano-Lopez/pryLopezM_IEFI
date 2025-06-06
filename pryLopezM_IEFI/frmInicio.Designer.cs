namespace pryLopezM_IEFI
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.mspInicio = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tsUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTiempoS = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerSesion = new System.Windows.Forms.Timer(this.components);
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.registrarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspInicio.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspInicio
            // 
            this.mspInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mspInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.administrarToolStripMenuItem});
            this.mspInicio.Location = new System.Drawing.Point(0, 0);
            this.mspInicio.Name = "mspInicio";
            this.mspInicio.Size = new System.Drawing.Size(800, 28);
            this.mspInicio.TabIndex = 0;
            this.mspInicio.Text = "mspInicio";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTareaToolStripMenuItem,
            this.historialTareasToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios...";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.auditoriaToolStripMenuItem.Text = "Auditoria...";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsuario,
            this.tsFecha,
            this.tsTiempoS});
            this.stsStatus.Location = new System.Drawing.Point(0, 424);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(800, 26);
            this.stsStatus.TabIndex = 3;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tsUsuario
            // 
            this.tsUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Size = new System.Drawing.Size(64, 21);
            this.tsUsuario.Text = "Usuario";
            // 
            // tsFecha
            // 
            this.tsFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFecha.Name = "tsFecha";
            this.tsFecha.Size = new System.Drawing.Size(50, 21);
            this.tsFecha.Text = "Fecha";
            // 
            // tsTiempoS
            // 
            this.tsTiempoS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTiempoS.Name = "tsTiempoS";
            this.tsTiempoS.Size = new System.Drawing.Size(110, 21);
            this.tsTiempoS.Text = "Tiempo sesion";
            // 
            // timerSesion
            // 
            this.timerSesion.Interval = 1000;
            this.timerSesion.Tick += new System.EventHandler(this.timerSesion_Tick);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarSesion.Location = new System.Drawing.Point(665, 1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(135, 27);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // registrarTareaToolStripMenuItem
            // 
            this.registrarTareaToolStripMenuItem.Name = "registrarTareaToolStripMenuItem";
            this.registrarTareaToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.registrarTareaToolStripMenuItem.Text = "Registrar tarea...";
            this.registrarTareaToolStripMenuItem.Click += new System.EventHandler(this.registrarTareaToolStripMenuItem_Click);
            // 
            // historialTareasToolStripMenuItem
            // 
            this.historialTareasToolStripMenuItem.Name = "historialTareasToolStripMenuItem";
            this.historialTareasToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.historialTareasToolStripMenuItem.Text = "Historial tareas...";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.mspInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspInicio;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing_1);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.mspInicio.ResumeLayout(false);
            this.mspInicio.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspInicio;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsFecha;
        private System.Windows.Forms.Timer timerSesion;
        private System.Windows.Forms.ToolStripStatusLabel tsTiempoS;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem registrarTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialTareasToolStripMenuItem;
    }
}