using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGD.Modelo
{
    class Administrador : Usuario
    {
        public Administrador(int cedula, string nombre, string apellidoP, string apellidoM, int telefono, DateTime fechNac) : base(cedula, nombre, apellidoP, apellidoM, telefono, fechNac)
        {
        }
    }
}
