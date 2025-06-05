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
    public partial class frmInicio : Form
    {
        private int idSesionActual;
        private int idUsuarioActual;

        private DateTime inicioSesion;
        private TimeSpan tiempoSesionActual;

        clsConexionBBDD BBDD = new clsConexionBBDD();

        public frmInicio(int idSesion, int idUsuario)
        {
            InitializeComponent();

            idSesionActual = idSesion;
            idUsuarioActual = idUsuario;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            tsUsuario.Text = clsSesion.nomUs;
            tsFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            inicioSesion = DateTime.Now;
            tiempoSesionActual = TimeSpan.Zero;

            timerSesion.Start();
        }

        private void timerSesion_Tick(object sender, EventArgs e)
        {
            tiempoSesionActual = DateTime.Now - inicioSesion;
            tsTiempoS.Text = tiempoSesionActual.ToString(@"hh\:mm\:ss");
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerSesion.Stop();

            // Supongamos que tienes el tiempo total acumulado de alguna forma
            TimeSpan tiempoTotal = tiempoSesionActual; // Podés sumar lo anterior si querés

            BBDD.actualizarSesion(idSesionActual, tiempoSesionActual, tiempoTotal, DateTime.Now);
        }

        private void frmInicio_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            GuardarSesion();
        }

        private void GuardarSesion()
        {
            timerSesion.Stop();

            DateTime finSesion = DateTime.Now;
            TimeSpan tiempoSesion = finSesion - inicioSesion;

            // Obtenés el acumulado desde la base para este usuario
            long segundosPrevios = BBDD.obtenerTiempoTotalAcumulado(idUsuarioActual);
            TimeSpan tiempoTotal = TimeSpan.FromSeconds(segundosPrevios) + tiempoSesion;

            // Guardás la sesión existente (NO crear una nueva)
            BBDD.actualizarSesion(idSesionActual, tiempoSesion, tiempoTotal, finSesion);

            BBDD.registrarAcciones("Logout", "Cierre de sesión", clsSesion.idUsuario, finSesion);

            



        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria v = new frmAuditoria();
            v.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuariosAdmin v = new frmUsuariosAdmin();
            v.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
