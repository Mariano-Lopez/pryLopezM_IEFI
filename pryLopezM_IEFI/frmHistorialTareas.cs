using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezM_IEFI
{
    public partial class frmHistorialTareas : Form
    {
        public frmHistorialTareas()
        {
            InitializeComponent();
        }

        clsConexionBBDD BBDD = new clsConexionBBDD();

        clsUsuarios lstUsuarios = new clsUsuarios();

        private void frmHistorialTareas_Load(object sender, EventArgs e)
        {
            BBDD.mostrarDatosTarea(dgvHistorialTarea);
            BBDD.cargarUsuarios(lstUsuarios);


            dtpFechaBusquedaTarea.MaxDate = DateTime.Now;
        }

        private void cmbFiltrarTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFiltrarTarea.SelectedIndex)
            {
                case 0:
                    limpiarComponentesSeleccion();
                    lblCargaDeDato.Text = "Fecha de tarea";
                    lblCargaDeDato.Visible = true;
                    dtpFechaBusquedaTarea.Visible = true;
                    btnFiltrarTarea.Enabled = true;

                    break;

                case 1:
                    limpiarComponentesSeleccion();
                    lblCargaDeDato.Text = "Fecha de registro de tarea";
                    lblCargaDeDato.Visible = true;
                    dtpFechaBusquedaTarea.Visible = true;
                    btnFiltrarTarea.Enabled = true;

                    break;

                case 2:

                    limpiarComponentesSeleccion();

                    lblCargaDeDato.Text = "Tarea realizada";
                    lblCargaDeDato.Visible = true;
                    cmbBusquedaTarea.Items.Clear();
                    cmbBusquedaTarea.Items.Add("Auditoría");
                    cmbBusquedaTarea.Items.Add("Consultas");
                    cmbBusquedaTarea.Items.Add("Inspección");
                    cmbBusquedaTarea.Items.Add("Reclamos");
                    cmbBusquedaTarea.Items.Add("Visitas");
                    cmbBusquedaTarea.Visible = true;

                    break;

                case 3:

                    limpiarComponentesSeleccion();

                    lblCargaDeDato.Text = "Lugar de tarea";
                    lblCargaDeDato.Visible = true;
                    cmbBusquedaTarea.Items.Clear();
                    cmbBusquedaTarea.Items.Add("Empresa");
                    cmbBusquedaTarea.Items.Add("Servicio");
                    cmbBusquedaTarea.Items.Add("Oficina");
                    cmbBusquedaTarea.Visible = true;

                    break;

                case 4:

                    limpiarComponentesSeleccion();

                    lblCargaDeDato.Text = "Seleccione detalle";
                    lblCargaDeDato.Visible = true;
                    cmbBusquedaTarea.Items.Clear();
                    cmbBusquedaTarea.Items.Add("Insumo");
                    cmbBusquedaTarea.Items.Add("Estudio");
                    cmbBusquedaTarea.Items.Add("Vacación");
                    cmbBusquedaTarea.Items.Add("Salario");
                    cmbBusquedaTarea.Items.Add("Recibo");
                    cmbBusquedaTarea.Visible = true;

                    break;

                case 5:
                    limpiarComponentesSeleccion();
                    lblCargaDeDato.Text = "Comentario buscado";
                    lblCargaDeDato.Visible = true;
                    txtBusquedaTarea.Visible = true;


                    break;

                case 6:
                    limpiarComponentesSeleccion();
                    lblCargaDeDato.Text = "N° ID del usuario";
                    lblCargaDeDato.Visible = true;
                    txtBusquedaTarea.Visible = true;


                    break;
            }
        }

        private void btnFiltrarTarea_Click(object sender, EventArgs e)
        {
            switch (cmbFiltrarTarea.SelectedIndex)
            {
                case 0:

                    string dato = dtpFechaBusquedaTarea.Value.Date.ToString("yyyy/MM/dd");
                    string campo = "fechaTarea";
                    BBDD.filtrarTareaPorDato(dgvHistorialTarea, dato, campo);

                    break;

                case 1:

                    dato = dtpFechaBusquedaTarea.Value.Date.ToString("yyyy/MM/dd");
                    campo = "fechaRegistro";
                    BBDD.filtrarTareaPorDato(dgvHistorialTarea, dato, campo);

                    break;

                case 2:

                    dato = cmbBusquedaTarea.Text;
                    campo = "tareaPrincipal";

                    BBDD.filtrarTareaPorDato(dgvHistorialTarea, dato, campo);


                    break;

                case 3:
                    
                    dato = cmbBusquedaTarea.Text;
                    campo = "lugarTarea";

                    BBDD.filtrarTareaPorDato(dgvHistorialTarea, dato, campo);


                    break;

                case 4:

                    dato = cmbBusquedaTarea.Text;
                    campo = "detalle";

                    BBDD.filtrarTareaPorDato(dato, campo, dgvHistorialTarea);


                    break;

                case 5:

                    dato = txtBusquedaTarea.Text;
                    campo = "comentario";

                    BBDD.filtrarTareaPorDato(dato, campo, dgvHistorialTarea);
                    
                    break;

                case 6:

                    int id = Convert.ToInt32(txtBusquedaTarea.Text);
                    clsUsuario aux = lstUsuarios.buscarUsuario(id);

                    if (aux != null)
                    {
                        BBDD.filtrarTareaPorDato(dgvHistorialTarea, id);
                    }
                    else
                    {
                        MessageBox.Show("ID inexistente", "Error");
                    }



                    break;
            }
        }

        public void limpiarComponentesHistorialTarea()
        {
            cmbFiltrarTarea.SelectedIndex = -1;

            cmbBusquedaTarea.SelectedIndex = -1;
            cmbBusquedaTarea.Visible = false;

            txtBusquedaTarea.Text = "";
            txtBusquedaTarea.Visible = false;

            dtpFechaBusquedaTarea.Value = DateTime.Now;
            dtpFechaBusquedaTarea.Visible = false;

            lblTipoDeDato.Visible = false;

            btnFiltrarTarea.Enabled = false;


        }

        public void limpiarComponentesSeleccion()
        {
            cmbBusquedaTarea.Visible = false;

            txtBusquedaTarea.Text = "";
            txtBusquedaTarea.Visible = false;

            dtpFechaBusquedaTarea.Value = DateTime.Now.Date;
            dtpFechaBusquedaTarea.Visible = false;

            btnFiltrarTarea.Enabled = false;
        }

        private void cmbBusquedaTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBusquedaTarea.SelectedIndex != -1)
            {
                btnFiltrarTarea.Enabled = true;
            }
        }

        private void txtBusquedaTarea_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusquedaTarea.Text))
            {
                btnFiltrarTarea.Enabled = true;
            }
            else
            {
                btnFiltrarTarea.Enabled = false;
            }
        }

        private void txtBusquedaTarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFiltrarTarea.SelectedIndex == 6)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Cancela el carácter si no es válido
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarComponentesHistorialTarea();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
