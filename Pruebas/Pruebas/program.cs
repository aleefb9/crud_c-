//Alejandro Fernández Banda

using System;
using System.Collections.Generic;

namespace Pruebas
{
    class Program
    {
        /** 
         * Método que inicializa la clase y el método Inicio()
         */
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Inicio();
        }

        /** 
         * Método que se encarga de cambiar las vistas según la opción introducida
         */
        public void Inicio()
        {
            Modelo modelo = new Modelo();
            Contacto contacto = new Contacto();

            string[] arrayDatos = new string[9];

            Console.Clear();

            while (true) 
            {
                Console.WriteLine("\nSeleccione una de las siguientes opciones:");
                Console.WriteLine("1. Añadir contacto");
                Console.WriteLine("2. Listar contacto");
                Console.WriteLine("3. Borrar contacto");
                Console.WriteLine("4. Buscar contacto");
                Console.WriteLine("5. Editar contacto");

                var opcion = Console.ReadLine();

                if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Introduzca una opción correcta");
                    Console.WriteLine("-------------------------------");
                }
                else
                {
                    if (opcion == "1")
                    {
                        arrayDatos = contacto.Inicio();
                        modelo.CogerDatos(arrayDatos);
                    }
                    if (opcion == "2")
                    {
                        Console.Clear();
                        modelo.MostrarDatos();
                    }
                    if (opcion == "3")
                    {
                        Console.Clear();
                        modelo.BorrarDatos();
                    }
                    if (opcion == "4")
                    {
                        Console.Clear();
                        modelo.BuscarDatos();
                    }
                    if (opcion == "5")
                    {
                        Console.Clear();
                        modelo.EditarDatos();
                    }
                }
            }
        }
    }
}

