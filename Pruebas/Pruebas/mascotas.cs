using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public interface IMascotas
    {
        string hayMascota();
    }

    class Perro : IMascotas
    {
        string IMascotas.hayMascota()
        {
            return "perro";
        }
    }

    class Gato : IMascotas
    {
        string IMascotas.hayMascota()
        {
            return "gato";
        }
    }
}
