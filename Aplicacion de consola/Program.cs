using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importamos las clases de uan carpeta como si fuera una libreria
using Aplicacion_de_consola.Clases;
namespace Aplicacion_de_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 1;

             //Declaracion de un arreglo
             int[] arreglo = new int[10];

             //Declaracion de una lista
             List<int> lista = new List<int> {4,19};

             //Insertar datos en la lista
             //lista.Add(4);
             lista.Add(60);

             string texto = "El valor de x es: ";

            //Otra forma de recorrer una lista
             foreach (int i in lista)
             {
                 Console.WriteLine("Valor: " + i);
             }

             //Recorrido en una lista o  arreglo
             /* for (int i = 0; i < lista.Count; i++)
              {
                  Console.Write("Posicion " + i + " es: " + lista[i] + "\n");
              }
             */
            Alumno alumno = new Alumno("0297525", "Oscar", "Martinez");
            Console.WriteLine(alumno.ObtenerInformacion());

            Materias materia = new Materias();

            materia.Nombre = "Interfaces";
            Console.Read();
        }
    }
}
