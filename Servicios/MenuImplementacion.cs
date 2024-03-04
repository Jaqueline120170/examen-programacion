using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using edu.jromresExamenProgramacion.Dtos;

namespace edu.jromresExamenProgramacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz

    {
        GerenciaInterfaz gi = new GerenciaImplementacion();
        EmpleadoInterfaz ei = new EmpleadoImplementacion();
        List<VentasDto> listaVentas = new List<VentasDto> ();
        List<PedidosDto> listaPedidos = new List<PedidosDto> ();
        GestorFicherosInterfaz gf = new GestorFicherosImplementacion ();
        public int menuPrincipal()
        {
            int seleccionPrincipal;
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. ACCESO GERENCIA");
            Console.WriteLine("2. ACCESO EMPLEADO");
            Console.WriteLine("SELECCIONE UNA OPCION");
            seleccionPrincipal=Convert.ToInt32(Console.ReadLine());
            return seleccionPrincipal;
        }
        /// <summary>
        /// metodo que controla la interaccion con el usuario cuando este accede a la version GERENTE, le muestra las ociones
        ///JRT 4-3-2024
        /// </summary>
        /// <returns>recoge un dato tipo int con la opcion que seleccione el usuario</returns>
        private int menuGerencia()
        {
            int seleccionGerencia;
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Escribir fichero");
            Console.WriteLine("2. Realizar pedido");
            Console.WriteLine("Seleccione una opcion");
            seleccionGerencia = Convert.ToInt32(Console.ReadLine());
            return seleccionGerencia;
        }
        public void accesoGerencia()
        {
            int opcionGerencia = menuGerencia();
            switch(opcionGerencia)
            {
                case 0:
                    break;
                case 1:
                    gi.mostrarVentas(listaVentas);
                    break;
                case 2:
                    gi.realizarPedido(listaPedidos);
                    break;
                default:
                    Console.WriteLine("INTRODUZCA OPCION VALIDA");
                    break;

            }
        }
        /// <summary>
        /// metodo que controla la interaccion con el usuario cuando este accede a la version empleado, le muestra las ociones
        ///JRT 4-3-2024
        /// </summary>
        /// <returns>recoge un dato tipo int con la opcion que seleccione el usuario</returns>
        private int menuEmpleado()
        {
            int seleccionEmpleado;
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Añadir Venta");
            Console.WriteLine("2. Calculo de ventas");
            Console.WriteLine("Seleccione una opcion");
            seleccionEmpleado = Convert.ToInt32(Console.ReadLine());
            return seleccionEmpleado;
        }
        public void accesoEmpleado()
        {
            int opcionEmpleado = menuEmpleado();
            switch (opcionEmpleado)
            {
                case 0:
                    break;
                case 1:
                    ei.añadirVenta(listaVentas);
                    break;
                case 2:
                    ei.calcularVentas(listaVentas);
                    break;
                default:
                    Console.WriteLine("INTRODUZCA OPCION VALIDA");
                    break;

            }
        }
    }
}
