using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {
        internal UserControl AbrirNuevaPersona()
        {
            return new NuevaPersona();
        }

        internal UserControl AbrirListadoPersonas()
        {
            return new ListadoPersonas();
        }
    }
}
