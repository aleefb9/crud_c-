using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    /**
     * Clase Personas que hereda de la clase contactos
     */
    public class Persona : Contacto
    {
        /**
        * Atributos de la clase persona
        */
        public string edad;
        public string sexo;
        /**
        * Método de la clase persona que recoge los datos específicos 
        */
        public void DatosPersona()
        {
            Console.WriteLine("\nedad: ");
            edad = Console.ReadLine();

            Console.WriteLine("\nsexo: ");
            sexo = Console.ReadLine();
        }
    }
}
