using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____------_____");

            Sistema sis = new Sistema();
            string res;
            bool esta;
            res = sis.crearEquipo("bar", "felipe", "rojo");
            Console.WriteLine(res);
            res = sis.crearEquipo("rea", "andres", "blanco");
            Console.WriteLine(res);
            res = sis.crearEquipo("juv", "aaaa", "xxx");
            Console.WriteLine(res);
            res = sis.crearEquipo("atl", "bbbb", "ddd");
            Console.WriteLine(res);
            res = sis.crearEquipo("psg", "hhh", "ttt");
            Console.WriteLine(res);
           // res = sis.crearEquipo("bayern", "iii", "nnn");
            Console.WriteLine(res);
            Console.WriteLine("");

            Partido par = sis.generarPartido();
            Console.WriteLine(par.eq1.nombreEq + " VS " + par.eq2.nombreEq);

            Partido par1 = sis.generarPartido();
            Console.WriteLine(par1.eq1.nombreEq + " VS " + par1.eq2.nombreEq);

            Partido par2 = sis.generarPartido();
            if (par2 != null)
            {
                Console.WriteLine(par2.eq1.nombreEq + " VS " + par2.eq2.nombreEq);
            }
            else
            {
                Console.WriteLine("no hay");
            }
            Partido par3 = sis.generarPartido();
            if (par3 != null)
            {
                Console.WriteLine(par3.eq1.nombreEq + " VS " + par3.eq2.nombreEq);
            }
            else
            {
                Console.WriteLine("no hay");

            }

            Console.WriteLine("===================");
            foreach (Partido item in sis.partidos)
            {
                Console.WriteLine(item.ToString());

            }
            Console.WriteLine("===================");

            sis.terminarPartido(0);
            sis.terminarPartido(1);
            //sis.terminarPartido(2);
            Console.WriteLine("jajajaja");
            

            Console.ReadKey();

        }
    }
}
