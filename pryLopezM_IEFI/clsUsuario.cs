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

        public string usuario { get; set; }

        public string contra { get; set; }

        public int permisos { get; set; }

        

        public clsUsuario(int id, string usuario, string contra, int permisos)
        {
            this.id = id;

            this.usuario = usuario;
            
            this.contra = contra;

            this.permisos = permisos;

            

        }


    }
}
