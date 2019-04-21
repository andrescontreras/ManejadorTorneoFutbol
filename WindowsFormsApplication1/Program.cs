using Negocio;
using Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Sistema sis = new Sistema();
            //string res;

          /*  res = sis.crearEquipo("bar", "felipe", "Rojo");
            Console.WriteLine(res);
            res = sis.crearEquipo("rea", "andres", "Blanco");
            Console.WriteLine(res);
            res = sis.crearEquipo("juv", "aaaa", "Amarillo");
            Console.WriteLine(res);
            res = sis.crearEquipo("atl", "bbbb", "Cyan");
            Console.WriteLine(res);
            res = sis.crearEquipo("psg", "hhh", "Morado");
            Console.WriteLine(res);
            res = sis.crearEquipo("bayern", "iii", "Verde");
            Console.WriteLine(res);*/
            Application.Run(new CrearEqui(sis));
           
        }
    }
}
