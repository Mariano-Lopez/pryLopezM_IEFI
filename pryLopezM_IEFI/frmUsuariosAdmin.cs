using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
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

            /*Cambiar esto */
            // --CREAR --
            cmbPermisosCrear.Items.Add("Administrador");
            cmbPermisosCrear.Items.Add("Operador");

            // --BUSCAR--

            // --ACTUALIZAR--
            cmbPermisosActualizar.Items.Add("Adminsitrador");
            cmbPermisosActualizar.Items.Add("Operador");


            
        }



        // --CREAR--

        bool fechaSeleccionada = false;
        public void habilitarBotonCrear(Button btn)
        {
            if (!string.IsNullOrEmpty(txtIdCrear.Text) && !string.IsNullOrEmpty(txtUsuarioCrear.Text) && !string.IsNullOrEmpty(txtContraseñaCrear.Text)
                && !string.IsNullOrEmpty(txtNombreCrear.Text) && !string.IsNullOrEmpty(txtApellidoCrear.Text) && !string.IsNullOrEmpty(txtEdadCrear.Text)
                && !string.IsNullOrEmpty(txtDNICrear.Text) && !string.IsNullOrEmpty(txtDireccionCrear.Text) && !string.IsNullOrEmpty(txtTelefonoCrear.Text)
                && !string.IsNullOrEmpty(txtEmailCrear.Text) && fechaSeleccionada && cmbPermisosCrear.SelectedIndex != -1)
            {
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;
            }
        }

        //--COMPONENTES CREAR

        #region CREAR 
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void txtNombreCrear_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void txtApellidoCrear_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void txtEdadCrear_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void txtDNICrear_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void txtDireccionCrear_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void txtTelefonoCrear_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void txtEmailCrear_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }
        private void dtpNacimientoCrear_ValueChanged_1(object sender, EventArgs e)
        {
            fechaSeleccionada = true;
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void cmbPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotonCrear(btnCrearUsuario);
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdCrear.Text);
            int edad = Convert.ToInt32(txtEdadCrear.Text);
            DateTime fechaActual = System.DateTime.Now;
            DateTime fechaNacimiento = dtpNacimientoCrear.Value.Date;

            clsUsuario aux = new clsUsuario(id, txtUsuarioCrear.Text, txtContraseñaCrear.Text, txtNombreCrear.Text, txtApellidoCrear.Text, edad, txtDNICrear.Text,
                 txtDireccionCrear.Text, txtTelefonoCrear.Text, txtEmailCrear.Text, fechaNacimiento, fechaActual, cmbPermisosCrear.Text);

            BBDD.crearUsuario(id, txtUsuarioCrear, txtContraseñaCrear, txtNombreCrear, txtApellidoCrear, edad, txtDNICrear,
                 txtDireccionCrear, txtTelefonoCrear, txtEmailCrear, fechaNacimiento, fechaActual, cmbPermisosCrear);

            lstUsuarios.agregarUsuario(aux);
            BBDD.mostrarDatos(dgvUsuarios);

            txtIdCrear.Text = "";
            txtUsuarioCrear.Text = "";
            txtContraseñaCrear.Text = "";
            txtNombreCrear.Text = "";
            txtApellidoCrear.Text = "";
            txtEdadCrear.Text = "";
            txtDNICrear.Text = "";
            txtDireccionCrear.Text = "";
            txtTelefonoCrear.Text = "";
            txtEmailCrear.Text = "";
            fechaSeleccionada = false;
            cmbPermisosCrear.SelectedIndex = -1;
        }

        #endregion

        // --BUSCAR--

        bool tipoDeCarga;

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            BBDD.mostrarDatos(dgvUsuarios);
        }

        private void txtDatoDeBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!tipoDeCarga)
            {
                
                // Solo permitir dígitos y control (como backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }


        public void habilitarBtnBuscar()
        {
            if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
            {
                btnBuscarUsuario.Enabled = true;
            }
            else
            {
                btnBuscarUsuario.Enabled = false;
            }
        }

        private void txtDatoDeBusqueda_TextChanged(object sender, EventArgs e)
        {
            habilitarBtnBuscar();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

            List<clsUsuario> resul = new List<clsUsuario>();

            switch (cmbBuscarTipoDeDato.SelectedIndex)
            {
                case 0:


                    string dato = "";
                    string campo = "id";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);

                    break;

                case 1:

                    dato = "";
                    campo = "usuario";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 2:
                    dato = "";
                    campo = "contraseña";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 3:
                    dato = "";
                    campo = "nombre";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 4:
                    dato = "";
                    campo = "apellido";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 5:
                    dato = "";
                    campo = "edad";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 6:
                    dato = "";
                    campo = "DNI";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 7:
                    dato = "";
                    campo = "direccion";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 8:
                    dato = "";
                    campo = "telefono";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 9:
                    dato = "";
                    campo = "email";

                    if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                    {
                        dato = txtDatoDeBusqueda.Text;
                        btnBuscarUsuario.Enabled = true;
                    }
                    else
                    {
                        btnBuscarUsuario.Enabled = false;
                    }

                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 10:
                    DateTime datoF = dtpBuscarFecha.Value.Date;  // Obtenés un DateTime sin la hora
                    dato = datoF.ToString("yyyy-MM-dd");         
                    campo = "fechanacimiento";
                    resul = lstUsuarios.buscarUsuario(datoF.ToString("yyyy-MM-dd"), campo);
                    
                    break;
                case 11:
                    DateTime fechaSeleccionada = dtpBuscarFecha.Value.Date;
                    dato = fechaSeleccionada.ToString("yyyy-MM-dd");
                    campo = "fechaAlta";
                    resul = lstUsuarios.buscarUsuario(dato, campo);
                    break;
                case 12:

                    if (cmbBuscarPermisos.SelectedIndex == 0)
                    {
                        dato = "";
                        campo = "permisos";

                        if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                        {
                            dato = txtDatoDeBusqueda.Text;
                            btnBuscarUsuario.Enabled = true;
                        }
                        else
                        {
                            btnBuscarUsuario.Enabled = false;
                        }

                        resul = lstUsuarios.buscarUsuario(dato, campo);
                        break;
                    }
                    else
                    {
                        dato = "";
                        campo = "permisos";

                        if (!string.IsNullOrEmpty(txtDatoDeBusqueda.Text))
                        {
                            dato = txtDatoDeBusqueda.Text;
                            btnBuscarUsuario.Enabled = true;
                        }
                        else
                        {
                            btnBuscarUsuario.Enabled = false;
                        }

                        resul = lstUsuarios.buscarUsuario(dato, campo);
                        break;
                    }
            }

            if (resul.Count == 0)
            {
                MessageBox.Show("No se encontraron datos.","Búsqueda finalizada.");
                BBDD.mostrarDatos(dgvUsuarios);
            }
            else
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = resul;
            }

            txtDatoDeBusqueda.Text = "";
            dtpBuscarFecha.Value = System.DateTime.Now;
            cmbBuscarPermisos.SelectedIndex = -1;


        }

        private void cmbBuscarTipoDeDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBuscarTipoDeDato.SelectedIndex)
            {
                case 0:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue un N° de ID:";
                    tipoDeCarga = false;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;

                    break;

                case 1:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue un usuario:";
                    tipoDeCarga = true;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    break;
                case 2:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue una contraseña:";
                    tipoDeCarga = true;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    // Opción 2
                    break;
                case 3:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue un nombre:";
                    tipoDeCarga = true;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    // Opción 2
                    break;
                case 4:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue un apellido:";
                    tipoDeCarga = true;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    break;
                case 5:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue una edad:";
                    tipoDeCarga = false;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    break;
                case 6:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue N° de DNI:";
                    tipoDeCarga = false;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    break;
                case 7:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue una dirección:";
                    tipoDeCarga = true;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    break;
                case 8:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue un teléfono:";
                    tipoDeCarga = false;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    break;
                case 9:
                    esconderComponentes();
                    txtDatoDeBusqueda.Text = "";
                    lblBusquedaSeleccionada.Text = "Cargue un e-mail:";
                    tipoDeCarga = true;
                    lblBusquedaSeleccionada.Visible = true;
                    txtDatoDeBusqueda.Visible = true;
                    break;
                case 10:
                    esconderComponentes();
                    btnBuscarUsuario.Enabled = true;
                    tipoDeCarga = true;
                    lblBuscarPorFecha.Visible = true;
                    dtpBuscarFecha.Visible = true;
                    break;
                case 11:
                    esconderComponentes();
                    btnBuscarUsuario.Enabled = true;
                    tipoDeCarga = true;
                    lblBuscarPorFecha.Visible = true;
                    dtpBuscarFecha.Visible = true;
                    break;
                case 12:
                    esconderComponentes();
                    lblBusquedaSeleccionada.Text = "Seleccione rol a filtrar:";
                    tipoDeCarga = true;
                    lblBusquedaSeleccionada.Visible = true;
                    cmbBuscarPermisos.Visible = true;
                    break;
            }

        }

        public void esconderComponentes()
        {
            lblBuscarPorFecha.Visible = false;
            lblBusquedaSeleccionada.Visible = false;

            dtpBuscarFecha.Visible = false;
            cmbBuscarPermisos.Visible = false;
            txtDatoDeBusqueda.Visible = false;

            BBDD.mostrarDatos(dgvUsuarios);
            btnBuscarUsuario.Enabled = false;

        }

        // --ACTUALIZAR--

        /*private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnBuscarActualizar_Click(object sender, EventArgs e)
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
        }

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
        }*/

        // --PANELES--
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            paneles(panelCrear);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            paneles(panelBuscar);
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

        private void txtIdCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter si no es válido
            }
        }

        
    }
}
