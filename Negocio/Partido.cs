using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Partido
    {
        public Partido(int equi1, int equi2,Sistema sis)
        {
            this.IDp = CONT;
            this.equi1 = equi1;
            this.equi2 = equi2;
            this.eq1 = sis.equipos.Find(x => x.IDe == equi1);
            this.eq2 = sis.equipos.Find(x => x.IDe == equi2);
            this.activo = true;
            this.golesE1 = 0;
            this.golesE2 = 0;
            this.ganadorID = -1;
            CONT++;
        }
        public static int CONT = 0;
        public int IDp;
        public int equi1 { get; set; }
        public int equi2 { get; set; }
        public bool activo { get; set; }
        public Equipo eq1 = null;
        public Equipo eq2 = null;
        public int golesE1;
        public int golesE2;
        public int ganadorID;

        public override string ToString()
        {
            return string.Format("{0} VS {1}",eq1.nombreEq,eq2.nombreEq);
        }
    }
}
