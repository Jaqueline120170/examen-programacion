using edu.jromresExamenProgramacion.Dtos;
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
    internal interface GerenciaInterfaz
    {
        /// <summary>
        /// metodo que solicita al usuario los datos necesarios para realizar un pedido e itera para saber si desea añadir algun pedido mas a la lista pedidos
       ///JRT 4-3-2024
        /// </summary>
        /// <param name="listaPedidos"></param>
        public void realizarPedido(List<PedidosDto> listaPedidos);
        /// <summary>
        /// METODO PARA MOSTRAR LAS VENTAS 
        /// JRT 4-3-2023
        /// </summary>
        /// <param name="listaVentas"></param>
        public void mostrarVentas(List<VentasDto> listaVentas);
    }
}
