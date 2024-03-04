using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.jromresExamenProgramacion.Dtos
{
    internal class VentasDto
    {
        //atributos del objeto venta
        //jrt 4-3-2024
        long idVenta;
        double importeVenta;
        DateTime fecha = DateTime.Now;


        //constructor vacio 
        //jrt 4-3-2024
        public VentasDto()
        {
        }

        //constructor con los atributos que solicita añadir una venta
        //jrt 4-3-2024
        public VentasDto(long idVenta, double importeVenta, DateTime fecha)
        {
            this.idVenta = idVenta;
            this.importeVenta = importeVenta;
            this.fecha = fecha;
        }


        //metodos get y set 
        //jrt 4-3-2024
        public long IdVenta { get => idVenta; set => idVenta = value; }
        public double ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        
    }

}
