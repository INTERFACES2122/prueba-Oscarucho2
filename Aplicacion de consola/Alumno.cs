using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_consola
{

    //Accesibilidad de la clase
    public class Alumno
    {
        public string cve_unica;
        public string nombres;
        public string apellidos;

        /// <summary>
        /// Constructor de la clase alumno
        /// </summary>
        /// <param name="_cve_unica">Clave unica del alumno</param>
        /// <param name="_nombres">Nombre o nombres del alumno</param>
        /// <param name="_apellidos">Apellidos del alumno</param>
        public Alumno(string _cve_unica, string _nombres, string _apellidos)
        { 

            cve_unica = _cve_unica;
            nombres = _nombres;
            apellidos = _apellidos;

        }

        public string ObtenerInformacion()
        {
            string informacion = "";

            informacion = cve_unica + "- " + nombres + "-" + apellidos;

            return informacion;
        }
    }
}