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
        private void txtIdCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter si no es válido
            }
        }

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

        private void txtDNICrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter si no es válido
            }
        }

        private void txtTelefonoCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter si no es válido
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(txtIdCrear.Text);
            clsUsuario nuevo;

            nuevo = lstUsuarios.buscarUsuario(id);

            if (nuevo == null)
            {
                int edad = Convert.ToInt32(txtEdadCrear.Text);
                DateTime fechaActual = System.DateTime.Now;
                DateTime fechaNacimiento = dtpNacimientoCrear.Value.Date;

                clsUsuario aux = new clsUsuario(id, txtUsuarioCrear.Text, txtContraseñaCrear.Text, txtNombreCrear.Text, txtApellidoCrear.Text, edad, txtDNICrear.Text,
                     txtDireccionCrear.Text, txtTelefonoCrear.Text, txtEmailCrear.Text, fechaNacimiento, fechaActual, cmbPermisosCrear.Text);

                BBDD.crearUsuario(id, txtUsuarioCrear, txtContraseñaCrear, txtNombreCrear, txtApellidoCrear, edad, txtDNICrear,
                     txtDireccionCrear, txtTelefonoCrear, txtEmailCrear, fechaNacimiento, fechaActual, cmbPermisosCrear);

                lstUsuarios.agregarUsuario(aux);
                BBDD.mostrarDatos(dgvUsuarios);

                BBDD.registrarAcciones("Creación de usuario", $"Se creó el usuario {txtUsuarioCrear.Text}", clsSesion.idUsuario, clsSesion.fechaAccion);
                vaciarComponentesCrear();
            }
            else
            {
                MessageBox.Show("El id que intenta cargar ya existe.","Error");
                txtIdCrear.Text = "";
            }


            
        }

        public void vaciarComponentesCrear()
        {
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

        #region BUSCAR

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
                    DateTime fechaSeleccionada = dtpBuscarFecha.Value.Date;  // Obtenés un DateTime sin la hora
                    dato = fechaSeleccionada.ToString("yyyy-MM-dd");         
                    campo = "fechanacimiento";
                    resul = lstUsuarios.buscarUsuario(fechaSeleccionada.ToString("yyyy-MM-dd"), campo);
                    
                    break;
                case 11:
                    fechaSeleccionada = dtpBuscarFecha.Value.Date;
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
                DateTime fechaBusqueda = dtpBuscarFecha.Value;

                if (cmbBuscarTipoDeDato.SelectedIndex == 11 || cmbBuscarTipoDeDato.SelectedIndex == 10)
                {
                    BBDD.registrarAcciones($"Búsqueda de {cmbBuscarTipoDeDato.Text}", $"Dato: {fechaBusqueda}", clsSesion.idUsuario, clsSesion.fechaAccion);
                }
                else
                {
                    BBDD.registrarAcciones($"Búsqueda de {cmbBuscarTipoDeDato.Text}", $"Dato: {txtDatoDeBusqueda.Text}", clsSesion.idUsuario, clsSesion.fechaAccion);
                }

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = resul;
            }

            vaciarComponentesBuscar();

        }

        public void vaciarComponentesBuscar()
        {
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
        #endregion
        // --ACTUALIZAR--

        private void txtDNIActualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter si no es válido
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si no selecciona la columna.
            if (e.RowIndex >= 0)
            {
                //Toma los datos de la fila y llena los componentes.
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                txtIDActualizar.Text = fila.Cells["idUsuario"].Value.ToString();
                txtIdParaEliminarUsuario.Text = fila.Cells["idUsuario"].Value.ToString();

                txtUsuarioActualizar.Text = fila.Cells["usuario"].Value.ToString();
                lblEliminarUsuarioDato.Text = fila.Cells["usuario"].Value.ToString();

                txtContraseñaActualizar.Text = fila.Cells["contraseña"].Value.ToString();
                lblEliminarContraseñaUsuario.Text = fila.Cells["contraseña"].Value.ToString();

                txtNombreActualizar.Text = fila.Cells["nombre"].Value.ToString();
                lblEliminarNombreUsuario.Text = fila.Cells["nombre"].Value.ToString();


                txtApellidoActualizar.Text = fila.Cells["apellido"].Value.ToString();
                lblEliminarApellidoUsuario.Text = fila.Cells["apellido"].Value.ToString();


                txtEdadActualizar.Text = fila.Cells["edad"].Value.ToString();
                lblEliminarEdadUsuario.Text = fila.Cells["edad"].Value.ToString();


                txtDNIActualizar.Text = fila.Cells["DNI"].Value.ToString();
                lblEliminarEmailUsuario.Text = fila.Cells["DNI"].Value.ToString();


                txtDireccionActualizar.Text = fila.Cells["direccion"].Value.ToString();
                lblEliminarDireccionUsuario.Text = fila.Cells["direccion"].Value.ToString();


                txtTelefonoActualizar.Text = fila.Cells["telefono"].Value.ToString();
                lblEliminarTelefonoUsuario.Text = fila.Cells["telefono"].Value.ToString();


                txtEmailActualizar.Text = fila.Cells["email"].Value.ToString();
                lblEliminarEmailUsuario.Text = fila.Cells["email"].Value.ToString();


                dtpFechaNActualizar.Value = Convert.ToDateTime(fila.Cells["fechaDeNacimiento"].Value);
                lblEliminarFechaNacimientoUsuario.Text = Convert.ToDateTime(fila.Cells["fechaDeNacimiento"].Value).ToString("dd/MM/yyyy");


                lblEliminarFechaAltaUsuario.Text = Convert.ToDateTime(fila.Cells["fechaDeAlta"].Value).ToString("dd/MM/yyyy");


                cmbPermisosActualizar.Text = fila.Cells["permisos"].Value.ToString();
                lblEliminarPermisosUsuario.Text = fila.Cells["permisos"].Value.ToString();


                habilitarComponentesDeActualizar(true, false);

            }            
        }

        public void habilitarComponentesDeActualizar(bool t, bool r)
        {
            txtIDActualizar.Enabled = r;
            txtUsuarioActualizar.Enabled = t;
            txtContraseñaActualizar.Enabled = t;
            txtNombreActualizar.Enabled = t;
            txtApellidoActualizar.Enabled = t;
            txtEdadActualizar.Enabled = t;
            txtDNIActualizar.Enabled = t; 
            txtDireccionActualizar.Enabled = t;
            txtTelefonoActualizar.Enabled = t;
            txtEmailActualizar.Enabled = t;
            dtpFechaNActualizar.Enabled = t;
            cmbPermisosActualizar.Enabled = t;
            btnActualizarUsuario.Enabled = t;
        }

        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {
            clsUsuario aux;


            int id = Convert.ToInt32(txtIDActualizar.Text);

            aux = lstUsuarios.buscarUsuario(id);

            if(aux == null)
            {
                MessageBox.Show("No se encontró ID","Error");
            }
            else
            {
                txtUsuarioActualizar.Text = aux.usuario;

                txtContraseñaActualizar.Text = aux.contra;
                txtNombreActualizar.Text = aux.nombre;
                txtApellidoActualizar.Text = aux.apellido;
                txtEdadActualizar.Text = aux.edad.ToString();
                txtDNIActualizar.Text = aux.dni;
                txtDireccionActualizar.Text = aux.direccion;
                txtTelefonoActualizar.Text = aux.telefono;
                txtEmailActualizar.Text = aux.email;
                dtpFechaNActualizar.Value = aux.fechaNacimiento;

                cmbPermisosActualizar.Text = aux.permisos;
            }

            habilitarComponentesDeActualizar(true, false);
        }

        private void btnLimpiarActualizar_Click_1(object sender, EventArgs e)
        {
            vaciarComponentesDeActualizar();
            habilitarComponentesDeActualizar(false, true);
        }

        public void vaciarComponentesDeActualizar()
        {
            txtIDActualizar.Text = "";
            txtUsuarioActualizar.Text = "";
            txtContraseñaActualizar.Text = "";
            txtNombreActualizar.Text = "";
            txtApellidoActualizar.Text = "";
            txtEdadActualizar.Text = "";
            txtDNIActualizar.Text = "";
            txtDireccionActualizar.Text = "";
            txtTelefonoActualizar.Text = "";
            txtEmailActualizar.Text = "";
            dtpFechaNActualizar.Value = System.DateTime.Now;

            cmbPermisosActualizar.SelectedIndex = -1;
        }

        private void txtIDActualizar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDActualizar.Text))
            {
                btnCargarUsuarioActualizar.Enabled = true;
            }
            else
            {
                btnCargarUsuarioActualizar.Enabled = false;
            }
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtIDActualizar.Text);
            DateTime fechaActualizada = dtpFechaNActualizar.Value.Date;

            clsUsuario aux;

            aux = lstUsuarios.buscarUsuario(id);

            if (!string.IsNullOrEmpty(txtUsuarioActualizar.Text) &&
                !string.IsNullOrEmpty(txtContraseñaActualizar.Text) &&
                !string.IsNullOrEmpty(txtNombreActualizar.Text) &&
                !string.IsNullOrEmpty(txtApellidoActualizar.Text) &&
                !string.IsNullOrEmpty(txtEdadActualizar.Text) &&
                !string.IsNullOrEmpty(txtDireccionActualizar.Text) &&
                !string.IsNullOrEmpty(txtDNIActualizar.Text) &&
                !string.IsNullOrEmpty(txtTelefonoActualizar.Text) &&
                !string.IsNullOrEmpty(txtEmailActualizar.Text))
            {
                BBDD.actualizarDatosUsuario(id, txtUsuarioActualizar, txtContraseñaActualizar, txtNombreActualizar, txtApellidoActualizar,
                    txtEdadActualizar,txtDNIActualizar, txtDireccionActualizar, txtTelefonoActualizar,
                    txtEmailActualizar, fechaActualizada, cmbPermisosActualizar );

                BBDD.mostrarDatos(dgvUsuarios);

                BBDD.registrarAcciones("Actualización de usuario", $"Cambio de datos del usuario {aux.usuario}", clsSesion.idUsuario, clsSesion.fechaAccion);

                vaciarComponentesDeActualizar();
                habilitarComponentesDeActualizar(false, true);

            }
            else
            {
                MessageBox.Show("No se pueden dejar campos vacíos.","Error");
            }
        }

        // --ELIMINAR--

        private void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            clsUsuario aux;
            int idParaEliminar = Convert.ToInt32(txtIdParaEliminarUsuario.Text);
            aux = lstUsuarios.buscarUsuario(idParaEliminar);

            BBDD.registrarAcciones("Usuarios", $"Eliminación de usuario '{aux.usuario}' ", clsSesion.idUsuario, clsSesion.fechaAccion);

            if (chkMensaje.Checked)
            {
                DialogResult confir = MessageBox.Show("Esta acción es irreversible, ¿está realmente seguro de borrar el usuario?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confir == DialogResult.Yes)
                {

                    BBDD.eliminarDatosUsusario(idParaEliminar);
                    BBDD.mostrarDatos(dgvUsuarios);

                    vaciarComponentesEliminar();
                }
            }
            else
            {

                BBDD.eliminarDatosUsusario(idParaEliminar);
                BBDD.mostrarDatos(dgvUsuarios);

                vaciarComponentesEliminar();
            }

            
            
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            clsUsuario aux;
            int idParaEliminar = Convert.ToInt32(txtIdParaEliminarUsuario.Text);
            aux = lstUsuarios.buscarUsuario(idParaEliminar);

            if (aux != null)
            {
                mrcEliminarUsuario.Visible = true;
            }
            else
            {
                MessageBox.Show("ID inexistente.","Error");
            }
        }

        private void txtIdParaEliminarUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdParaEliminarUsuario.Text))
            {
                btnEliminarUsuario.Enabled = true;
            }
            else
            {
                btnEliminarUsuario.Enabled = false;
            }
        }

        public void vaciarComponentesEliminar()
        {

            txtIdParaEliminarUsuario.Text = "";
            lblEliminarIdUsuario.Text = "";
            lblEliminarUsuarioDato.Text = "";
            lblEliminarContraseñaUsuario.Text = "";
            lblEliminarNombreUsuario.Text = "";
            lblEliminarApellidoUsuario.Text = "";
            lblEliminarEdadUsuario.Text = "";
            lblEliminarDireccionUsuario.Text = "";
            lblEliminarDNIUsuario.Text = "";
            lblEliminarTelefonoUsuario.Text = "";
            lblEliminarEmailUsuario.Text = "";
            lblEliminarFechaNacimientoUsuario.Text = "";
            lblEliminarFechaAltaUsuario.Text = "";
            lblEliminarPermisosUsuario.Text = "";
            
            mrcEliminarUsuario.Visible = false; 
            
            
        }

        // --PANELES--
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            paneles(panelCrear);
            
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            paneles(panelBuscar);
            vaciarComponentesBuscar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            paneles(panelActualizar);
            vaciarComponentesDeActualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            paneles(panelEliminar);
            vaciarComponentesEliminar();
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

        private void txtIdParaEliminarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter si no es válido
            }
        }

        
    }
}
