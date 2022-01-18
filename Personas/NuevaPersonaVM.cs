using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class NuevaPersonaVM : ObservableObject
    {
        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }

        public NuevaPersonaVM()
        {
            Mensaje = "Soy el UserControl 1";
        }
    }
}