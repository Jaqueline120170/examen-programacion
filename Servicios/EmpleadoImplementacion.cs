using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using edu.jromresExamenProgramacion.Dtos;

namespace edu.jromresExamenProgramacion.Servicios
{
    /// <summary>
    /// c
    /// </summary>
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        List<VentasDto> listaVentas = new List<VentasDto> ();
        public void añadirVenta(List<VentasDto>listaVentas)
        {
            Console.WriteLine("AÑADIR VENTA");
            long id = calcularId(listaVentas);
            Console.WriteLine("Introduzca el importe de la venta");
            double importe= Convert.ToDouble(Console.ReadLine());
            DateTime fecha = DateTime.Now;
            VentasDto venta = new VentasDto (id, importe, fecha);
            listaVentas.Add(venta);
        }
        /// <summary>
        /// metodo para calcular el id de la venta 
        /// JRT 4-3-2024
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns>un dato tipo long que sera agnado a id</returns>
        private long calcularId(List<VentasDto> listaVentas)
        {
            long idCalculado;
            int tamanioLista =listaVentas.Count;
            if( tamanioLista > 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaVentas[tamanioLista - 1].IdVenta + 1;       
            }
            return idCalculado;

        }
       
        public void calcularVentas(List<VentasDto>listaVentas)
        {
            Console.WriteLine("CALCULAR VENTAS");
            
            Console.WriteLine("Ingrese una fecha dd-MM-YY: ");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());

            double totalVentasDiaro = 0;
            TimeSpan diferenciaDeTiempo = TimeSpan.Zero;

            foreach (VentasDto ventas in listaVentas)
            {

                if (ventas.Fecha.Equals(fecha))
                {

                    double sum = ventas.ImporteVenta;
                    totalVentasDiaro += sum;
                    diferenciaDeTiempo = TimeSpan(ventas.Fecha) - diferenciaDeTiempo;

                }
            }

            Console.WriteLine($"Total ventas diario {fecha.ToShortDateString()} es : {totalVentasDiaro} ");
            Console.WriteLine($"Tiempo transcurrido desde la primera hasta la última venta realizada: {diferenciaDeTiempo.Hours} horas, {diferenciaDeTiempo.Minutes} minutos y  {diferenciaDeTiempo.Seconds} segundos");
        }

    }
}




