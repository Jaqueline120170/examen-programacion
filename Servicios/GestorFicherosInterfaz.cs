using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.jromresExamenProgramacion.Servicios
{
    internal interface GestorFicherosInterfaz
    {
        /// <summary>
        /// METODO PARA ASIGNAR RUTA Y NOMBRE AL FICHERO EN FUNCION D ELA FECHA ACTUAL
        /// JRT- 4-3-2024
        /// </summary>
        /// <returns></returns>
        public string asignarFichero();
        /// <summary>
        /// metodo que crea el fichero en la rita que ha sido asignada
        /// JRT 4-3-2023
        /// </summary>
        public void sobreEscribir(string accion);
        /// <summary>
        ///  metodo para sobreeescrbir en el fichero
        ///  JRT 4-3-2024
        /// </summary>
        /// <param name="accion"></param>



        /// <summary>
        ///  metodo para leer
        ///  JRT 4-3-2024
        /// </summary>
        /// <param name="accion"></param>

        public void leerArchivo();

    }
}
