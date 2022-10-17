using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Modelo
{
    class Seleccionador : Usuario
    {
        public Seleccionador(int cedula, string nombre, string apellidoP, string apellidoM, int telefono, DateTime fechNac) : base(cedula, nombre, apellidoP, apellidoM, telefono, fechNac)
        {
        }
    }
}
