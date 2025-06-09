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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clsConexionBBDD BBDD = new clsConexionBBDD();

        clsUsuarios lstUsuarios = new clsUsuarios();

        private void frmSesionUsuario_Load(object sender, EventArgs e)
        {
            BBDD.cargarUsuarios(lstUsuarios);
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
            {
                var usuario = lstUsuarios.lstUsuarios.FirstOrDefault(u => u.usuario == txtUsuario.Text);

                if (usuario != null && usuario.contra == txtContraseña.Text)
                {
                    clsVariablesGlobales.nomUs = usuario.usuario;
                    clsVariablesGlobales.idUsuario = usuario.id;
                    clsVariablesGlobales.idPermisos = usuario.permisos;

                    DateTime fecha = DateTime.Now;


                    BBDD.registrarAcciones("Login", "Inicio de sesión", clsVariablesGlobales.idUsuario, fecha);

                    // Insertar nueva sesión y obtener el ID recién creado
                    clsVariablesGlobales.idSesion = BBDD.insertarNuevaSesionYObtenerID(usuario.id);

                    txtContraseña.Text = "";
                    txtUsuario.Text = "";

                    txtUsuario.Focus();

                    MessageBox.Show($"Bienvenido {usuario.usuario}.", "Login exitoso");

                    frmInicio v = new frmInicio(clsVariablesGlobales.idSesion, clsVariablesGlobales.idUsuario);
                    v.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión");
                }
            }
            else
            {
                MessageBox.Show("No se pueden dejar campos vacíos", "Error de inicio de sesión");
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !chkContraseña.Checked;
        }
    }
}
