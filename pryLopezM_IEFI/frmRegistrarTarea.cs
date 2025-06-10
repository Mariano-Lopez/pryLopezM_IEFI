using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            BBDD.cargarCombo(cmbTarea, "Tarea");
            BBDD.cargarCombo(cmbLugarTarea, "Lugar");
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

            dtpFechaTarea.Value = System.DateTime.Now.Date;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            panelAgregarEliminar.Visible = false;
        }

        private void btnAgregarEliminarTareaLugar_Click(object sender, EventArgs e)
        {
            panelAgregarEliminar.Visible=true;
        }

        private void cmbTareaLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cmbTareaLugar.SelectedIndex == 0 || cmbTareaLugar.SelectedIndex == 1)
            {
                mostrarComponentes(false, true, true, true, false);
                btnAñadirtxt.Text = "Añadir";
                btnAñadirtxt.BackColor = Color.ForestGreen;
                lblAgregarEliminar.Text = cmbTareaLugar.Text;
                
                


            }
            else if (cmbTareaLugar.SelectedIndex == 2 || cmbTareaLugar.SelectedIndex == 3)
            {


                mostrarComponentes(true, false, false, true, true);
                btnEliminarcmb.Text = "Eliminar";
                btnEliminarcmb.BackColor = Color.Red;
                lblAgregarEliminar.Text = cmbTareaLugar.Text;
                


                if (cmbAñadirEliminar.SelectedIndex == -1)
                {
                btnAñadirtxt.Enabled = false;
                }
            }

            if (cmbTareaLugar.SelectedIndex == 0 || cmbTareaLugar.SelectedIndex == 2)
            {
                BBDD.cargarCombo(cmbAñadirEliminar, "Tarea");
            }
            else if (cmbTareaLugar.SelectedIndex == 1 || cmbTareaLugar.SelectedIndex == 3)
            {
                BBDD.cargarCombo(cmbAñadirEliminar, "Lugar");
            }


        }
        public void mostrarComponentes(bool t, bool v, bool u, bool w, bool x)
        {
            cmbAñadirEliminar.Visible = t;
            txtNuevaTareaLugar.Visible = v;
            btnAñadirtxt.Visible = u;
            lblAgregarEliminar.Visible = w;
            btnEliminarcmb.Visible = x;

        }

        public void limpiarComponentes()
        {
            btnAñadirtxt.Visible = false;
            cmbTareaLugar.SelectedIndex = -1;

            txtNuevaTareaLugar.Text = "";
            txtNuevaTareaLugar.Visible = false;

            cmbAñadirEliminar.SelectedIndex = -1;
            cmbAñadirEliminar.Visible = false;

            mostrarComponentes(false, false, false, false, false);
        }


        private void btnAñadirEliminar_Click(object sender, EventArgs e)
        {
            if (cmbTareaLugar.SelectedIndex == 0)
            {
                    string nuevaOpcion = txtNuevaTareaLugar.Text.Trim();

                    if (!string.IsNullOrEmpty(nuevaOpcion))
                    {
                        if (!string.IsNullOrEmpty(nuevaOpcion) && !clsVariablesGlobales.lstTarea.Contains(nuevaOpcion))
                        {
                            clsVariablesGlobales.lstTarea.Add(nuevaOpcion);
                            BBDD.agregarDatoCombo("Tarea", nuevaOpcion);
                            BBDD.cargarCombo(cmbAñadirEliminar, "Tarea");
                            BBDD.cargarCombo(cmbTarea, "Tarea");
                        
                    }
                        else
                        {
                            MessageBox.Show("Ya existe opción", "Error");
                        }
                        limpiarComponentes();
                    }
                    else
                    {
                        MessageBox.Show("No se pueden dejar campos vacíos.", "Error");
                    }
            }
            else if (cmbTareaLugar.SelectedIndex == 1)
            {
                string nuevaOpcion = txtNuevaTareaLugar.Text.Trim();

                if (!string.IsNullOrEmpty(nuevaOpcion))
                {
                    if (!string.IsNullOrEmpty(nuevaOpcion) && !clsVariablesGlobales.lstLugar.Contains(nuevaOpcion))
                    {
                        clsVariablesGlobales.lstLugar.Add(nuevaOpcion);
                        BBDD.agregarDatoCombo("Lugar", nuevaOpcion);
                        BBDD.cargarCombo(cmbAñadirEliminar, "Lugar");
                        BBDD.cargarCombo(cmbLugarTarea, "Lugar");
                        
                    }
                    else
                    {
                        MessageBox.Show("Ya existe opción", "Error");
                    }
                    limpiarComponentes();

                }
                else
                {
                    MessageBox.Show("No se pueden dejar campos vacíos.", "Error");
                }
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
        }

        private void cmbAñadirEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTareaLugar.SelectedIndex == 2 || cmbTareaLugar.SelectedIndex == 3)
            {
                if (cmbAñadirEliminar.SelectedIndex != -1)
                {
                    btnAñadirtxt.Enabled = true;
                }
            }
        }

        private void btnEliminarcmb_Click(object sender, EventArgs e)
        {
            if (cmbAñadirEliminar.SelectedIndex != -1)
            {
                if (cmbTareaLugar.SelectedIndex == 2)
                {
                    string seleccion = cmbAñadirEliminar.SelectedItem?.ToString();

                    clsVariablesGlobales.lstTarea.Remove(seleccion);
                    BBDD.eliminarDatoCombo("Tarea", seleccion);
                    BBDD.cargarCombo(cmbTarea, "Tarea");
                    BBDD.cargarCombo(cmbAñadirEliminar, "Tarea");




                    limpiarComponentes();
                }
                else if (cmbTareaLugar.SelectedIndex == 3)
                {
                    string seleccion = cmbAñadirEliminar.SelectedItem?.ToString();

                    clsVariablesGlobales.lstLugar.Remove(seleccion);
                    BBDD.eliminarDatoCombo("Lugar", seleccion);
                    BBDD.cargarCombo(cmbLugarTarea, "Lugar");
                    BBDD.cargarCombo(cmbAñadirEliminar, "Lugar");


                    limpiarComponentes();

                }

            }
            else
            {
                MessageBox.Show("Selecicone una opción", "Error");
            }

            
        }

        private void txtNuevaTareaLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNuevaTareaLugar.Text))
            {
                btnAñadirtxt.Enabled = true;
            }
            else
            {
                btnAñadirtxt.Enabled = false;
            }
        }
    }
}
