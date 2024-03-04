using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.jromresExamenProgramacion.Dtos
{
    internal class PedidosDto
    {
        //atributos del objeto venta
        //jrt 4-3-2024
        long idProducto = 0;
        string nombreProducto = "aaaaa";
        int cantidadProducto = 11111;
        string fechaDeseada = "aaaaa";

        //constructor con los atributos que solicita añadir una venta
        //jrt 4-3-2024
        public PedidosDto(long idProducto, string nombreProducto, int cantidadProducto, string fechaDeseada)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fechaDeseada = fechaDeseada;
        }

        //constructor vacio 
        //jrt 4-3-2024
        public PedidosDto()
        {
        }


        //metodos get y set 
        //jrt 4-3-2024
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public string FechaDeseada { get => fechaDeseada; set => fechaDeseada = value; }
        
        /// <summary>
        /// metodo toStrng que hace la conversión de datos de maner aautomatica al momento de llamarlo y mostrar objeto
        /// </summary>
        /// <returns>string con atributos introducidos</returns>
        public string ToString()
        {
            string pedido = "ID PRODUCTO: " + this.idProducto + "NOMBRE PRODUCTO: " + this.nombreProducto + "CANTIDAD PRODUCTO:"+  this.cantidadProducto + "FECHA DESEADA" + this.fechaDeseada;
            return pedido;
        }
    }
}
