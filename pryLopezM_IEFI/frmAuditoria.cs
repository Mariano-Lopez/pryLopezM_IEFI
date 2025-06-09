using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezM_IEFI
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        clsConexionBBDD BBDD = new clsConexionBBDD();
        clsUsuarios lstUsuarios = new clsUsuarios();

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            BBDD.datosAuditoriaSesiones(dgvAuditoria);            
        }

        private void cmbOpcionesAuditoría_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbOpcionesAuditoría.SelectedIndex == 0)
            {
                txtIdAuditoría.Enabled = true;
                dtpAuditoría.Enabled = false;
            }
            else if (cmbOpcionesAuditoría.SelectedIndex == 1)
            {
                txtIdAuditoría.Enabled = false;
                dtpAuditoría.Enabled = true;
            }
            else if (cmbOpcionesAuditoría.SelectedIndex == 2)
            {
                txtIdAuditoría.Enabled = true;
                dtpAuditoría.Enabled = true;
            }
        }

        private void optSesionUsuario_CheckedChanged(object sender, EventArgs e)
        {
            BBDD.datosAuditoriaSesiones(dgvAuditoria);
        }

        private void optAccionesRealizadas_CheckedChanged(object sender, EventArgs e)
        {
            BBDD.datosAuditoriaAcciones(dgvAuditoria);
        }

        private void btnBuscarUsuarioAuditoria_Click(object sender, EventArgs e)
        {
            clsUsuario aux;

            if (cmbOpcionesAuditoría.SelectedIndex == 0)
            {
                int id = Convert.ToInt32(txtIdAuditoría.Text);

                //--VERIFICAR ESTO
                aux = lstUsuarios.buscarUsuario(id);


                if (optSesionUsuario.Checked)
                {
                    BBDD.datosAuditoriaId(id, dgvAuditoria, "sesionUsuario", "idUsuarioSesion");
                }
                else if (optAccionesRealizadas.Checked)
                {
                    BBDD.datosAuditoriaId(id, dgvAuditoria, "accionRealizada", "idUsuarioAccion");
                }
            }
            else if (cmbOpcionesAuditoría.SelectedIndex == 1)
            {
                dtpAuditoría.Enabled = true;
                string fechaAuditoria = dtpAuditoría.Value.Date.ToString("yyyy/MM/dd");

                //MessageBox.Show(fechaAuditoria.ToString("yyyy/MM/dd"));
                

                if (optSesionUsuario.Checked)
                {
                    BBDD.datosAuditoriaFecha(fechaAuditoria, dgvAuditoria, "sesionUsuario", "fechaUltConeccion");
                }
                else if (optAccionesRealizadas.Checked)
                {
                    BBDD.datosAuditoriaFecha(fechaAuditoria, dgvAuditoria, "accionRealizada", "fechaDeAccion");
                }

            }
            else if (cmbOpcionesAuditoría.SelectedIndex == 2)
            {
                int id = Convert.ToInt32(txtIdAuditoría.Text);
                string fechaAuditoria = dtpAuditoría.Value.Date.ToString("yyyy/MM/dd");

                txtIdAuditoría.Enabled = true;
                dtpAuditoría.Enabled = true;
                if (optSesionUsuario.Checked)
                {
                    BBDD.datosAuditoriaIdFecha(id, fechaAuditoria, dgvAuditoria, "sesionUsuario", "fechaUltConeccion", "idUsuarioSesion");
                }
                else if (optAccionesRealizadas.Checked)
                {
                    BBDD.datosAuditoriaIdFecha(id, fechaAuditoria, dgvAuditoria, "sesionUsuario", "fechaUltConeccion", "idUsuarioAccion");
                }
            }

            txtIdAuditoría.Text = "";

        }

        private void btnLimpiarAuditoria_Click(object sender, EventArgs e)
        {
            txtIdAuditoría.Enabled = false;
            dtpAuditoría.Enabled = false;

            txtIdAuditoría.Text = "";
            cmbOpcionesAuditoría.SelectedIndex = -1;

            optSesionUsuario.Checked = true;
            BBDD.datosAuditoriaSesiones(dgvAuditoria);
        }

        private void dgvAuditoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Ejemplo suponiendo que la columna se llama "horaInicio"
            if (dgvAuditoria.Columns[e.ColumnIndex].Name == "tiempoTotal" && e.Value is TimeSpan tiempo)
            {
                e.Value = tiempo.ToString(@"hh\:mm\:ss");
                e.FormattingApplied = true;
            }
        }
    }
}
