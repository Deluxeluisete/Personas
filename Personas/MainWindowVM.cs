using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp10
{
    class MainWindowVM : ObservableObject
    {
        private readonly ServicioNavegacion servicio;

        private UserControl opcion;

        public UserControl Opcion
        {
            get { return opcion; }
            set { SetProperty(ref opcion, value); }
        }


       
        public RelayCommand AbrirNuevaPersonaCommand { get; }
        public RelayCommand AbrirListadoPersonasCommand { get; }
        public MainWindowVM()
        {

            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);
            AbrirListadoPersonasCommand = new RelayCommand(AbrirListadoPersonas);
            servicio = new ServicioNavegacion();
        }
        private void AbrirNuevaPersona()
        {
            servicio.AbrirNuevaPersona();


        }
        private void AbrirListadoPersonas()
        {
            servicio.AbrirListadoPersonas();


        }

    }
}
