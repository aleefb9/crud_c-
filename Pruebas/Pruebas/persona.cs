using Microsoft.VisualBasic.FileIO;
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
        public string mascota;

        /**
        * Método de la clase persona que recoge los datos específicos 
        */
        public void DatosPersona()
        {
            string opcion;
            Console.WriteLine("\nedad: ");
            edad = Console.ReadLine();

            Console.WriteLine("\nsexo: ");
            sexo = Console.ReadLine();

            Console.WriteLine("\nMascota: ");
            Console.WriteLine("1. Gato");
            Console.WriteLine("2. Perro");
            opcion = Console.ReadLine();

            if(opcion != "1" && opcion != "2")
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("Introduzca una opción correcta");
                Console.WriteLine("-------------------------------");
            }
            else
            {
                if (opcion == "1")
                {
                    IMascotas obj = new Gato();
                    mascota = obj.hayMascota();
                    Console.WriteLine(mascota);
                }
                if (opcion == "2")
                {
                    IMascotas obj = new Perro();
                    mascota = obj.hayMascota();
                    Console.WriteLine(mascota);
                }
            }
        }
    }
}
