using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezM_IEFI
{
    public class clsUsuarios
    {
        public List<clsUsuario> lstUsuarios;

        public clsUsuarios()
        {
            lstUsuarios = new List<clsUsuario>();
        }

        public void agregarUs(clsUsuario nuevo)
        {
            lstUsuarios.Add(nuevo);
        }

        public clsUsuario buscarUs(int dato)
        {
            return lstUsuarios.Find(e => e.id ==dato);
        }

        public clsUsuario buscarUs(string dato)
        {
            return lstUsuarios.Find(e => e.usuario == dato);
        }

        public List <clsUsuario> buscarUsuarios(string dato)
        {
            return lstUsuarios.FindAll(e => e.permisos.Equals(dato));
        }
    }
}
