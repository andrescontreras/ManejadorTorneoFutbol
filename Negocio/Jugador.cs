using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Jugador
    {
        public Jugador(int numeroJ,string nombreJ, string tipo)
        {
            this.numeroJ = numeroJ;
            this.nombreJ = nombreJ;
            this.mensaje = "INDEFINIDO";
            this.IDj = ID;
            ID++;
            if (tipo == "Amarilla")
            {
                this.restante = fechaAma;
            }
            else
            {
                this.restante = fechaRoj;
            }

        }

        public static int ID = 0;
        public static int fechaAma { get; set; }
        public static int fechaRoj { get; set; }
        public int IDj { get; set; }
        public int numeroJ { get; set; }
        public string nombreJ { get; set; }
        public int restante { get; set; }
        public string mensaje { get; set; }


        public override string ToString()
        {
            return String.Format(" INFO: _{0}_ {1} {2}",nombreJ,numeroJ,mensaje);
        }
    }
}
