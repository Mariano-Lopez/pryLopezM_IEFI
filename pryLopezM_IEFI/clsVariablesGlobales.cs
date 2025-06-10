using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezM_IEFI
{
    public static class clsVariablesGlobales
    {
        public static string nomUs { get; set; }
        public static int idUsuario { get; set; }
        public static int idSesion { get; set; }
        public static string idPermisos { get; set; }

        public static DateTime fechaAccion = DateTime.Now;

        public static TimeSpan sesionActual { get; set; }

        public static List<string> lstTarea { get; set; } = new List<string>();

        public static List<string> lstLugar { get; set; } = new List<string>();

        public static void AgregarALista(List<string> lst,string opcion)
        {
            if (!string.IsNullOrEmpty(opcion) && !lst.Contains(opcion))
            {
                lst.Add(opcion);
            }
        }

        public static void EliminarDeLista(List<string> lst, string opcion)
        {
            lst.Remove(opcion);
        }


    }




}
