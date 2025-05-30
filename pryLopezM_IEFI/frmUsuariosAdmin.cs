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
    public partial class frmUsuariosAdmin : Form
    {
        public frmUsuariosAdmin()
        {
            InitializeComponent();
        }

        clsConexionBBDD BBDD = new clsConexionBBDD();

        clsUsuarios lstUsuarios = new clsUsuarios();

        private void clsUsuariosAdmin_Load(object sender, EventArgs e)
        {
            BBDD.mostrarDatos(dgvUsuarios);
            BBDD.cargarUsuarios(lstUsuarios);

            // --CREAR --
            cmbPermisos.Items.Add("Administrador");
            cmbPermisos.Items.Add("Operador");

            // --BUSCAR--
            cmbBuscarFiltro.Items.Add("Identificador");
            cmbBuscarFiltro.Items.Add("Usuario");
            cmbBuscarFiltro.Items.Add("Permisos");

            cmbPermisosBuscar.Items.Add("Administrador");
            cmbPermisosBuscar.Items.Add("Operador");

            // --ACTUALIZAR--
            cmbPermisosActualizar.Items.Add("Adminsitrador");
            cmbPermisosActualizar.Items.Add("Operador");


            
        }

        // --CREAR--

        /* MIRAR ESTO */
        public void habilitarBtn(Button btn)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContra.Text) && cmbPermisos.SelectedIndex != -1)
            {
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBtn(btnCrearUs);
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            habilitarBtn(btnCrearUs);
        }

        private void cmbPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBtn(btnCrearUs);
        }

        private void btnCrearUs_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            //clsUsuario aux = new clsUsuario(id, txtUsuario.Text, txtContra.Text, cmbPermisos.Text);

            BBDD.crearUsuario(txtId, txtUsuario, txtContra, cmbPermisos.Text);

            BBDD.mostrarDatos(dgvUsuarios);

            //lstUsuarios.agregarUs(aux);


            txtId.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
            cmbPermisos.SelectedIndex = -1;
        }

        // --BUSCAR--

        private void cmbBuscarFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarFiltro.SelectedIndex == 0) // Buscar por ID
            {
                habilitarComponentes(true, false, false);
                btnBuscarUsuario.Enabled = !string.IsNullOrEmpty(txtBuscar.Text);
            }
            else if (cmbBuscarFiltro.SelectedIndex == 1) // Buscar por usuario
            {
                habilitarComponentes(false, true, false);
                btnBuscarUsuario.Enabled = !string.IsNullOrEmpty(txtUsuarioBuscar.Text);
            }
            else if (cmbBuscarFiltro.SelectedIndex == 2) // Buscar por permisos
            {
                habilitarComponentes(false, false, true);
                btnBuscarUsuario.Enabled = cmbPermisos.SelectedIndex != -1;
            }
        }

        public void habilitarComponentes(bool buscarActivo, bool usuarioActivo, bool permisosActivo)
        {
            txtBuscar.Enabled = buscarActivo;
            txtUsuarioBuscar.Enabled = usuarioActivo;
            cmbPermisosBuscar.Enabled = permisosActivo;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscarFiltro.SelectedIndex == 0)
                btnBuscarUsuario.Enabled = !string.IsNullOrEmpty(txtBuscar.Text);
        }

        private void txtUsuarioBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscarFiltro.SelectedIndex == 1)
                btnBuscarUsuario.Enabled = !string.IsNullOrEmpty(txtUsuario.Text);
        
        }

        private void cmbPermisosBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarFiltro.SelectedIndex == 2)
                btnBuscarUsuario.Enabled = cmbPermisosBuscar.SelectedIndex != -1;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (cmbBuscarFiltro.SelectedIndex == 0) 
            {
                BBDD.mostrarDatos(dgvUsuarios);

                var resul = lstUsuarios.buscarUs(Convert.ToInt32(txtBuscar.Text));

                txtUsuarioBuscar.Text = resul.usuario.ToString();

                txtContraseñaBuscar.Text = resul.contra.ToString();

                cmbPermisosBuscar.Text = resul.permisos.ToString();

            }
            else if (cmbBuscarFiltro.SelectedIndex == 1)
            {
                BBDD.mostrarDatos(dgvUsuarios);

                var resul = lstUsuarios.buscarUs(txtBuscar.Text);

                txtUsuarioBuscar.Text = resul.usuario.ToString();

                txtContraseñaBuscar.Text = resul.contra.ToString();

                cmbPermisosBuscar.Text = resul.permisos.ToString();
            }
            else if (cmbBuscarFiltro.SelectedIndex == 2)
            {
                dgvUsuarios.DataSource = lstUsuarios.buscarUsuarios(cmbPermisosBuscar.Text);
            }
        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            BBDD.mostrarDatos(dgvUsuarios);

            txtBuscar.Text = "";
            txtUsuarioBuscar.Text = "";
            txtContraseñaBuscar.Text = "";
            cmbPermisosBuscar.SelectedIndex = -1;
        }

        // --ACTUALIZAR--

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si no selecciona la columna.
            if (e.RowIndex >= 0)
            {
                //Toma los datos de la fila y llena los componentes.
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                txtBuscar.Text = fila.Cells["id"].Value.ToString();

                txtUsuarioBuscar.Text = fila.Cells["usuario"].Value.ToString();

                txtContraseñaBuscar.Text = fila.Cells["contraseña"].Value.ToString();

                cmbPermisosBuscar.Text = fila.Cells["permisos"].Value.ToString();

            }

            habilitarCompoAct(true, true);

        }

        private void btnLimpiarAct_Click(object sender, EventArgs e)
        {
            limpiarComponentesDeActualizar();

            habilitarCompoAct(false, false);
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            
            //BBDD.actualizarDatosUs(txtUsuarioActualizar, txtContraActualizar, cmbPermisosActualizar, Convert.ToInt32(txtActualizar.Text));

            BBDD.mostrarDatos(dgvUsuarios);

            limpiarComponentesDeActualizar();
        }

        /*private void btnBuscarActualizar_Click(object sender, EventArgs e)
        {
            var resul = lstUsuarios.buscarUs(txtUsuarioActualizar.Text);

            if (resul != null)
            {
                txtContraActualizar.Text = resul.contra;

                cmbPermisosActualizar.Text = resul.permisos;

                txtActualizar.Text = (resul.id).ToString();

                habilitarCompoAct(true, true);

                btnEliminarUs.Enabled = true;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.","Error");
            }
        }*/

        public void habilitarCompoAct(bool t, bool t2)
        {
            txtContraActualizar.Enabled = t;
            cmbPermisosActualizar.Enabled=t2;
        }

        private void txtUsuarioActualizar_TextChanged(object sender, EventArgs e)
        {
            habilitarbtnAct();
        }

        private void txtContraActualizar_TextChanged(object sender, EventArgs e)
        {
            habilitarbtnAct();
        }

        public void habilitarbtnAct()
        {
            if (!string.IsNullOrEmpty(txtUsuarioActualizar.Text) && !string.IsNullOrEmpty(txtContraActualizar.Text))
            {
                btnActualizarUsuario.Enabled = true;

            }
            else
            {
                btnActualizarUsuario.Enabled = false;
            }
        }

        public void limpiarComponentesDeActualizar()
        {
            txtUsuarioActualizar.Text = "";
            txtContraActualizar.Text = "";
            txtActualizar.Text = "";
            cmbPermisosActualizar.SelectedIndex = -1;
        }

        // --ELIMINAR--

        private void btnEliminarUs_Click(object sender, EventArgs e)
        {
            BBDD.eliminarDatosUs(Convert.ToInt32(txtActualizar.Text));
            BBDD.mostrarDatos(dgvUsuarios);
        }

        // --PANELES--
        private void btnCrear_Click(object sender, EventArgs e)
        {
            paneles(panelCrear);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            paneles(panelBuscar);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            paneles(panelActualizar);
        }

        public void paneles(Panel pnl)
        {
            // Ocultamos todos
            panelCrear.Visible = false;
            panelBuscar.Visible = false;
            panelActualizar.Visible = false;

            // Mostramos el deseado
            pnl.Visible = true;
            pnl.BringToFront();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter si no es válido
            }
        }

        
    }
}
