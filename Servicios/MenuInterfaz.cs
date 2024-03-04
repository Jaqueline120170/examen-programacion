using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.jromresExamenProgramacion.Servicios
{   /// <summary>
/// iNTERFAZ QUE GESTIONA LA RELACION DE CADA METODO Y SU IMPLEMENTACION
/// JRT 4-3-2024
/// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// menu que controla las interaccion con el usuario, es el menu rincipal para que pueda seleccionar a que version o menu quiere acceder
        /// JRT 4.3.2024
        /// </summary>
        /// <returns>devuelve un entero con la opcion guardada</returns>
        public int menuPrincipal();

        /// <summary>
        /// Metodo que recoge la opcion que seleccione el usuario cuando accede a la version gerencia
        /// JRT 4-3-2024
        /// </summary>
        public void accesoGerencia();

        /// <summary>
        /// Metodo que recoge la opcion que seleccione el usuario cuando accede a la version empleado
        /// JRT 4-3-2024
        /// </summary>
        public void accesoEmpleado();
    }
}
