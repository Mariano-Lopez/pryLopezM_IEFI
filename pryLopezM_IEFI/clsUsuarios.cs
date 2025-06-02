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

        public void agregarUsuario(clsUsuario nuevo)
        {
            lstUsuarios.Add(nuevo);
        }

        public clsUsuario buscarUsuario(int dato)
        {
            return lstUsuarios.Find(e => e.id ==dato);
        }



        public List<clsUsuario> buscarUsuario(string dato, string campo)
        {
            return lstUsuarios.FindAll(e =>
            {
                switch (campo)
                {
                    case "id":
                        return e.id.ToString() == dato;
                    case "usuario":
                        return e.usuario == dato;
                    case "contraseña":
                        return e.contra == dato;
                    case "nombre":
                        return e.nombre == dato;
                    case "apellido":
                        return e.apellido == dato;
                    case "edad":
                        return e.edad.ToString() == dato;
                    case "dni":
                        return e.dni == dato;
                    case "direccion":
                        return e.direccion == dato;
                    case "telefono":
                        return e.telefono == dato;
                    case "email":
                        return e.email == dato;
                    case "fechanacimiento":
                        if (DateTime.TryParse(dato, out DateTime fechaBuscada))
                        {
                            return e.fechaNacimiento.Date == fechaBuscada.Date;
                        }
                        else
                        {
                            return false;
                        }
                    case "fechaAlta":
                        if (DateTime.TryParse(dato, out DateTime fechaAlta))
                        {
                            return e.fechaDeAlta.Date == fechaAlta.Date;
                        }
                        return false;
                    case "permisos":
                        return e.permisos == dato;
                    default:
                        return false;

                }
            });
        }
    }
}
