using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class CT : Usuario
    {
        public CT(int cedula, string nombre, string apellidoP, string apellidoM, int telefono, DateTime fechNac, String rol) : base(cedula, nombre, apellidoP, apellidoM, telefono, fechNac)
        {
        }
    }
}
