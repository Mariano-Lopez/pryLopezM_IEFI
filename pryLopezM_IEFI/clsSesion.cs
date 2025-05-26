using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezM_IEFI
{
    public static class clsSesion
    {
        public static string nomUs { get; set; }
        public static int idUsuario { get; set; }
        public static int idSesion { get; set; }
        public static string idPermisos { get; set; }

        public static DateTime ultSesion { get; set; }

        public static TimeSpan sesionActual { get; set; }
        


    }
}
