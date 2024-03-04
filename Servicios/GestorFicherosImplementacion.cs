using edu.jromresExamenProgramacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.jromresExamenProgramacion.Servicios
{
    internal class GestorFicherosImplementacion : GestorFicherosInterfaz
    {   
        public string asignarFichero()
        {
            string fecha = DateTime.Today.ToString("ddMMyyyy");
            string rutaFichero = "C://Users//Profesor//source//repos//edu.jromresExamenProgramacion" + fecha + ".txt";
            return rutaFichero;
        }

        public void sobreEscribir(string accion)
        {
            using (StreamWriter sw = new StreamWriter(asignarFichero(), true))
            {
                sw.WriteLine(accion);
            }
            Console.WriteLine("Se ha escrito en el archivo");
        }
        public void leerArchivo()
        {
            using (StreamReader sr = new StreamReader(asignarFichero()))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("Contenido del archivo:\n" + contenido);
            }

            Console.ReadLine(); 
        }



    }
}
