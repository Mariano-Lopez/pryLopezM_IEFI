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

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }

        public string dni { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public string email { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public DateTime fechaDeAlta { get; set; }

        public string permisos { get; set; }

        

        public clsUsuario(int id, string usuario, string contra, string nombre, string apellido, int edad, string dni, string direccion, string telefono,
            string email, DateTime fechaNacimiento, DateTime fechaDeAlta, string permisos)
        {
            this.id = id;

            this.usuario = usuario;
            
            this.contra = contra;

            this.nombre = nombre;

            this.apellido = apellido;

            this.edad = edad;

            this.dni = dni;

            this.direccion = direccion;

            this.telefono = telefono;

            this.email = email;

            this.fechaNacimiento = fechaNacimiento;

            this.fechaDeAlta = fechaDeAlta;

            this.permisos = permisos;

        }


    }
}
