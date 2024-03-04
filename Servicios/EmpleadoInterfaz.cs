using edu.jromresExamenProgramacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.jromresExamenProgramacion.Servicios
{
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// metodo para añadir una venta que hace uso d ela lista de ventas crea una instancia de ese objeto y le añade un elemento
        /// </summary>
        /// <param name="listaVentas"></param>
        public void añadirVenta(List<VentasDto> listaVentas);
        /// <summary>
        /// metodo para el calculo de ventas hace uso d ela lista de ventas crea una instancia de ese objeto 
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calcularVentas(List<VentasDto> listaVentas);
    }
}
