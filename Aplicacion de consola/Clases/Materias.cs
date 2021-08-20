using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_consola.Clases
{
    public class Materias
    {
        private string nombre;
        private int no_alumnos;
        
        public string Codigo { get; set; }
        /// <summary>
        /// Metodo de acceso para la variable private nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int NoAlumnos
        {
            get
            {
                return no_alumnos;
            }
            set
            {
                no_alumnos = value;
            }
        }
    }
}
