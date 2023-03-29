//Alejandro Fernández Banda

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Contacto
    {
        public string nombre;
        public string apellidos;
        public string dni;
        public string telefono;
        public string tipo;
        public string notas;

        /** 
         * Método de la clase alta que se encarga de coger los datos para pasarlos al método que los introduce en la lista
         */
        public string[] Inicio()
        {
            Persona persona = new Persona();
            Empresa empresa = new Empresa();

           

            Console.Clear();
            Console.WriteLine("SELECIIONE UN PERFIL DE USUARIO\n");
            Console.WriteLine("1. Persona");
            Console.WriteLine("2. Empresa");

            string seleccionPerfil = Console.ReadLine();

            if (seleccionPerfil != "1" && seleccionPerfil != "2")
            {
                Console.Clear();
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("Introduzca una opción correcta");
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("AÑADIR CONTACTO");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("\nNombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("\nApellidos: ");
                apellidos = Console.ReadLine();

                Console.WriteLine("\nDNI: ");
                dni = Console.ReadLine();

                Console.WriteLine("\nTelefono: ");
                telefono = Console.ReadLine();


                if (seleccionPerfil == "1")
                {
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("DATOS PERSONA");
                    Console.WriteLine("-------------------------------");

                    persona.DatosPersona();

                    tipo = "1";
                }
                if (seleccionPerfil == "2")
                {
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("DATOS EMPRESA");
                    Console.WriteLine("-------------------------------");
                    
                    empresa.DatosEmpresa();

                    tipo = "2";
                }

                while (notas != "0")
                {
                    Console.WriteLine("\nNotas: ");
                    notas = Console.ReadLine();
                }
            }
    

            Console.Clear();

            /** 
            * Guardamos los datos en un array para retornarlos
            */
            string[] arrayDatos = new string[] { nombre, apellidos, dni, telefono, persona.sexo, persona.edad, empresa.sector, empresa.nEmpleados, tipo, notas };

            return arrayDatos;
        }
    }
}
