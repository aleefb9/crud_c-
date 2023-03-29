using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    /**
    * Clase Empresas que hereda de la clase contactos
    */
    public class Empresa : Contacto
    {
        /**
        * Atributos de la clase empresa
        */
        public string sector;
        public string nEmpleados;
        /**
          * Método de la clase empresa que recoge los datos específicos 
          */
        public void DatosEmpresa()
        {
            Console.WriteLine("\nSector: ");
            sector = Console.ReadLine();

            Console.WriteLine("\nNúmero de empleados: ");
            nEmpleados = Console.ReadLine();
        }
    }
}
