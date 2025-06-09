using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezM_IEFI
{
    public partial class frmRegistrarTarea : Form
    {
        public frmRegistrarTarea()
        {
            InitializeComponent();
        }

        clsConexionBBDD BBDD = new clsConexionBBDD();

        string detalle;

        


        private void frmRegistrarTarea_Load(object sender, EventArgs e)
        {
            BBDD.mostrarDatosTarea(dgvTareas);

            dtpFechaTarea.MaxDate = DateTime.Today;
        }

        private void btnGrabarTarea_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = System.DateTime.Now;
            DateTime fechaElegida = dtpFechaTarea.Value.Date;

            string comentario = txtComentarioTarea.Text;

            string lugar = cmbLugarTarea.Text;
            string tarea = cmbTarea.Text;

            TimeSpan hora = DateTime.Now.TimeOfDay;

            if (detalle == null)
            {
                detalle = "Sin detalle";
            }

            BBDD.registrarTarea(fechaElegida, tarea, lugar, hora, clsVariablesGlobales.idUsuario, comentario, detalle, fechaHoy);

            dtpFechaTarea.Value = fechaHoy;
            cmbTarea.SelectedIndex = -1;
            cmbLugarTarea.SelectedIndex = -1;

            chkInsumo.Checked = false;
            chkEstudioTarea.Checked = false;
            chkVacacionTarea.Checked = false;
            chkSalarioTarea.Checked = false;
            chkReciboTarea.Checked = false;

            txtComentarioTarea.Text = "";

            BBDD.mostrarDatosTarea(dgvTareas);

            
        }

        private void txtComentarioTarea_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonDeGrabar();
        }

        private void cmbLugarTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotonDeGrabar();
        }

        private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotonDeGrabar();
        }

        public void habilitarBotonDeGrabar()
        {
            if (!string.IsNullOrEmpty(txtComentarioTarea.Text) && cmbTarea.SelectedIndex != -1 && cmbLugarTarea.SelectedIndex != -1)
            {
                btnGrabarTarea.Enabled = true;
            }
            else
            {
                btnGrabarTarea.Enabled= false;
            }
        }

        private void chkInsumo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInsumo.Checked)
            {
                detalle += (string.IsNullOrEmpty(detalle) ? "" : ";") + "Insumo";
            }
        }

        private void chkEstudioTarea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstudioTarea.Checked)
            {
                detalle += (string.IsNullOrEmpty(detalle) ? "" : ";") + "Estudio";
            }
        }

        private void chkVacacionTarea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVacacionTarea.Checked)
            {
                detalle += (string.IsNullOrEmpty(detalle) ? "" : ";") + "Vacacion";
            }
        }

        private void chkSalarioTarea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalarioTarea.Checked)
            {
                detalle += (string.IsNullOrEmpty(detalle) ? "" : ";") + "Salario";
            }
        }

        private void chkReciboTarea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReciboTarea.Checked)
            {
                detalle += (string.IsNullOrEmpty(detalle) ? "" : ";") + "Recibo";
            }
        }

        private void btnCancelarTarea_Click(object sender, EventArgs e)
        {

        }
    }
}
