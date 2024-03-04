using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using edu.jromresExamenProgramacion.Dtos;

namespace edu.jromresExamenProgramacion.Servicios
{
    internal class GerenciaImplementacion : GerenciaInterfaz
    {

        public void realizarPedido(List<PedidosDto> listaPedidos)
        {
            bool continuarPedido = false;
            do
            {
                Console.WriteLine("REALIZAR PEDIDO");
                long idPed = calculoIdPedido(listaPedidos);
                Console.WriteLine("Introduzca el nombre del pedido ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Introduzca la cantidad del pedido");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca la fecha deseada en la que desea  tener el pedido");
                string fecha = Console.ReadLine();
                PedidosDto pedidos = new PedidosDto(idPed, nombre, cantidad, fecha);
                listaPedidos.Add(pedidos);
                Console.WriteLine("¿Desea introducir otro pedido ? s/n");
                char sn = Convert.ToChar(Console.ReadLine());
                if (sn == 's')
                {
                    continuarPedido = true;
                }
                else if (sn == 'n')
                {
                    continuarPedido = false;
                    foreach (PedidosDto pedidosDto in listaPedidos)
                    {
                        Console.WriteLine(listaPedidos.ToString());
                    }
                }

            } while (continuarPedido);
            
           
        }
        /// <summary>
        /// metodo para calcular el id del pedido 
        /// JRT 4-3-2024
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns>un dato tipo long que sera agnado a id</returns>
        private long calculoIdPedido(List<PedidosDto> listaPedidos)
        {
            long idCalculado;
            int tamanioLista = listaPedidos.Count;
            if (tamanioLista > 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaPedidos[tamanioLista - 1].IdProducto + 1;
            }
            return idCalculado;

        }
        public void mostrarVentas(List<VentasDto> listaVentas)
        {
            GerenciaInterfaz gi = new GerenciaImplementacion();
            GestorFicherosInterfaz gf = new GestorFicherosImplementacion();
            
            Console.WriteLine("MOSTRAR VENTAS");
            if (listaVentas.Count > 0)
            {
                foreach (VentasDto ventas in listaVentas)
                {
                    Console.WriteLine($"///////////////\n" +
                                      $"Id: {ventas.IdVenta}\n" +
                                      $"venta: {ventas.ImporteVenta}\n" +
                                      $"Hora: {ventas.Fecha}\n" +
                                      $"///////////////");
                }


            }
            gf.sobreEscribir("VENTAS DIARIAS");
        }   
        
    }
}
        
       

    

