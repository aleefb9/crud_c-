//Alejandro Fernández Banda

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        public int i = 0;

        /** 
        * Creamos las listas que contienen las notas y los datos para introducirlas en otra lista general
        */
        public List<List<String>> listaDatos = new List<List<String>>();
        public List<String> listaContacto = new List<String>();
        public List<String> listaNotas = new List<String>();

        /** 
         * Método de la clase alta que se encarga de coger los datos para pasarlos al método que los introduce en la lista
         */
        public List<List<String>> Inicio()
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

                /** 
                * Bucle que nos pide la introducción de notas hasta que se desee
                */
                Console.WriteLine("\n¿Quiere introducir Notas? s/n");
                string respuestaNotas = Console.ReadLine();

                if(respuestaNotas == "s") {
                    Console.WriteLine("\nIntroduce n cuando quieras dejar de añadir notas");
                    while (true)
                    {
                        Console.WriteLine("\nNota[" + i++ + "]: ");
                        notas = Console.ReadLine();

                        if (notas == "n")
                        {
                            break;
                        }
                        listaNotas.Add(notas);
                    }
                }
            }
            Console.Clear();

           /** 
           * Guardamos los datos en una lista para retornarlos
           */
            listaContacto.Add(nombre);
            listaContacto.Add(apellidos);
            listaContacto.Add(dni);
            listaContacto.Add(telefono);
            listaContacto.Add(persona.sexo);
            listaContacto.Add(persona.edad);
            listaContacto.Add(empresa.sector);
            listaContacto.Add(empresa.nEmpleados);
            listaContacto.Add(tipo);
            listaContacto.Add(persona.mascota);


            /** 
            * Guardamos las dos listas generadas en la lista general que enviaremos
            */
            listaDatos.Add(listaContacto);
            listaDatos.Add(listaNotas);

            return listaDatos;
        }
    }
}