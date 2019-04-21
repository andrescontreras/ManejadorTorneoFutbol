using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Equipo : IComparable<Equipo>
    {
        public Equipo(string nombreEq, string nombrePe, string color)
        {

            this.nombreEq = nombreEq;
            this.nombrePe = nombrePe;
            this.color = color;
            this.parJugados = 0;
            this.pGanados = 0;
            this.pEmpatados = 0;
            this.pPerdidos = 0;
            this.golesF = 0;
            this.golesC = 0;
            this.DFgoles = 0;
            this.puntos = 0;
            this.IDe = ID++;
            this.contra = new List<int>();
            this.disponible = true;
            
            amarillas = new List<Jugador>();
            rojas = new List<Jugador>();
          

        }
        private static int ID = 0;
        public string nombreEq { get;  set; }
        public string nombrePe { get; set; }
        public string color { get; set; }
        public int pGanados { get; set; }
        public int pPerdidos { get; set; }
        public int pEmpatados { get; set; }
        public int golesF { get; set; }
        public int golesC { get; set; }
        public int DFgoles { get; set; }
        public int puntos { get; set; }
        public int IDe { get; set; }
        public bool disponible { get; set; }
        public int parJugados { get; set; }
        public List<int> contra { get; set; }
        public List<Jugador> amarillas { get; set; }
        public List<Jugador> rojas { get; set; }

        
        public int CompareTo(Equipo other)
        {
            // cuando puntos son diferentes
            if (this.puntos.CompareTo(other.puntos) != 0)
            {
                return this.puntos.CompareTo(other.puntos);
            }
            else if (this.DFgoles.CompareTo(other.DFgoles) != 0)
            {
                return this.DFgoles.CompareTo(other.DFgoles);
            }
            else
            {
                return 0;
            }
        }
    }
}
