using edu.jromresExamenProgramacion.Servicios;

namespace edu.jromresExamenProgramacion.Controladores
{
      /// <summary>
      /// Clase principal d ela aplicacion
      /// JRT 4.3.2024
      /// </summary>
        internal class Program
        {
           
            static string logFilePath = "log.txt";
            public static StreamWriter logStreamWriter;
            /// <summary>
            /// METODO PRINCIPAL DE LA APLICACION
            /// JRT 4.3.2024
            /// </summary>
            /// <param name="args"></param>
            static void Main(string[] args)
            {
                MenuInterfaz mi = new MenuImplementacion();
            GestorFicherosInterfaz gf = new GestorFicherosImplementacion();
            logStreamWriter = new StreamWriter(logFilePath);


                int opcionSeleccionada;
                bool cerrarMenu = false;

                fichero("Menú Principal ");
            gf.sobreEscribir("ACCESO APLICACION");
                while(!cerrarMenu)
                {
                    opcionSeleccionada = mi.menuPrincipal();
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            cerrarMenu = true;
                            Console.WriteLine("Cerrado");

                            fichero("[INFO 0] - cerrar menu");

                            break;
                        case 1:
                            mi.accesoGerencia();
                            fichero("[INFO 1] - Menu Gerencia");

                            break;

                        case 2:
                            mi.accesoEmpleado();
                            fichero("[INFO 2 ]- Menu Empleado");

                            break;

                        default:

                            

                            Console.WriteLine("La opcion no existe");
                            break;
                    }

                } 

                logStreamWriter.Close();

            }
        /// <summary>
        /// metodo prueba para crear fichero
        /// </summary>
        /// <param name="mensaje"></param>
            private static void fichero (string mensaje)
            {
                try
                {
                    logStreamWriter.WriteLine(DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss") + " - " + mensaje);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error  " + ex.Message);
                }
            }
        }

    }

