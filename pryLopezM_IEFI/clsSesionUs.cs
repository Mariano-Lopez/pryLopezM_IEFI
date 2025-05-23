using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezM_IEFI
{
    public class clsSesionUs
    {
        public DateTime fechaUltConex { get; set; }

        public DateTime fechaActual { get; set; }

        public TimeSpan tiempoSesion { get; set; }

        public TimeSpan tiempoTot { get; set; }

        public clsSesionUs(DateTime fechaUltConex, DateTime fechaActual, TimeSpan tiempoSesion, TimeSpan tiempoTot)
        {
            this.fechaUltConex = fechaUltConex;

            this.fechaActual = fechaActual;

            this.tiempoSesion = tiempoSesion;

            this.tiempoTot = tiempoTot;
        }


    }
}
