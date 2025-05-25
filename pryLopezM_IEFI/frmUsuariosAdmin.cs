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

        private void clsUsuariosAdmin_Load(object sender, EventArgs e)
        {
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

        // --BUSCAR--

        private void cmbBuscarFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarFiltro.SelectedIndex == 0) // Buscar por ID
            {
                habilitarComponentes(true, false, false);
                btnBuscarUs.Enabled = !string.IsNullOrEmpty(txtBuscar.Text);
            }
            else if (cmbBuscarFiltro.SelectedIndex == 1) // Buscar por usuario
            {
                habilitarComponentes(false, true, false);
                btnBuscarUs.Enabled = !string.IsNullOrEmpty(txtUsuarioBuscar.Text);
            }
            else if (cmbBuscarFiltro.SelectedIndex == 2) // Buscar por permisos
            {
                habilitarComponentes(false, false, true);
                btnBuscarUs.Enabled = cmbPermisos.SelectedIndex != -1;
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
                btnBuscarUs.Enabled = !string.IsNullOrEmpty(txtBuscar.Text);
        }

        private void txtUsuarioBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscarFiltro.SelectedIndex == 1)
                btnBuscarUs.Enabled = !string.IsNullOrEmpty(txtUsuario.Text);
        
        }

        private void cmbPermisosBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarFiltro.SelectedIndex == 2)
                btnBuscarUs.Enabled = cmbPermisosBuscar.SelectedIndex != -1;
        }

        // --ACTUALIZAR--



    }
}
