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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        clsConexionBBDD BBDD = new clsConexionBBDD();

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            cmbTablas.Items.Add("Usuarios");
            cmbTablas.Items.Add("Tiempos de sesión");

            
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedIndex == 0)
            {
                string comando = "SELECT id, usuario, permisos FROM Usuarios";

                BBDD.mostrarDatos(dgvBBDDTablas, comando);
            }
            else
            {
                string comando = "SELECT * FROM sesionUs";

                BBDD.mostrarDatos(dgvBBDDTablas, comando);
            }
        }
    }
}
