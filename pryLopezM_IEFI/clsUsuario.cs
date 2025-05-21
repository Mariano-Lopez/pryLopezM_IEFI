using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezM_IEFI
{
    public class clsUsuario
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public int permisos { get; set; }

        public DateTime fechaUltConex { get; set; }

        public DateTime fechaActual { get; set; }

        public TimeSpan tiempoSesion { get; set; }

        public TimeSpan tiempoTot { get; set; }

        public clsUsuario(int id, string nombre, int permisos, DateTime fechaUltConex, DateTime fechaActual, TimeSpan tiempoSesion, TimeSpan tiempoTot)
        {
            this.id = id;

            this.nombre = nombre;

            this.permisos = permisos;

            this.fechaUltConex = fechaUltConex;

            this.fechaActual = fechaActual;

            this.tiempoSesion = tiempoSesion;

            this.tiempoTot = tiempoTot;

        }


    }
}
