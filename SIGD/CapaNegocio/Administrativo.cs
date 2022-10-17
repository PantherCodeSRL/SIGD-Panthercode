using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Modelo
{
    class Administrativo : Usuario
    {
        public Administrativo(int cedula, string nombre, string apellidoP, string apellidoM, int telefono, DateTime fechNac) : base(cedula, nombre, apellidoP, apellidoM, telefono, fechNac)
        {
        }
    }
}
