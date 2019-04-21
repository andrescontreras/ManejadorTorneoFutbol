using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Sistema
    {
        public static int NUM_PAR { get; set; }
        public List<Equipo> equipos { get; set; }
        public List<Partido> partidos { get; set; }
        public int num;

        public Sistema()
        {
            equipos = new List<Equipo>();
            partidos = new List<Partido>();
        }
        /*
        1 = ok
            */
        public string crearEquipo(string nombreEq, string nombrePe, string color)
        {
            Equipo equi = new Equipo(nombreEq, nombrePe, color);
            string respuesta = null;
            foreach (Equipo equipo in equipos)
            {
                if (equipo == null)
                {
                    equipos.Add(equi);
                    respuesta = "se agrego correctamente";
                }
                if (equipo.nombrePe == equi.nombrePe)
                {
                    respuesta = "el nombre de la persona ya esta en el sistema";
                }
                if (equipo.color == equi.color)
                {
                    respuesta = "el color diferenciador ya esta en uso";
                }

            }
            if (respuesta == null)
            {
                equipos.Add(equi);
                respuesta = "se agrego correctamente";
            }
            return respuesta;

        }

        // genera lista de equipos disponibles de forma ordenada por menos partidos
        public List<Equipo> listaDisponiblesOr()
        {
            List<Equipo> disponibles = new List<Equipo>();
            foreach (Equipo item in equipos)
            {
                if (item.disponible == true)
                {
                    disponibles.Add(item);
                }
                else
                {
                    Console.WriteLine("__ NULL __");
                }
            }
           
            foreach (Equipo item in disponibles)
            {
                Console.WriteLine("DISPO_" + item.disponible); 
            }
           
            IEnumerable<Equipo> orden = disponibles.OrderBy(x => x.parJugados);
            List<Equipo> dispo = new List<Equipo>();
            foreach (Equipo item in orden)
            {
                dispo.Add(item);
                
                
            }
            return dispo;
        }

        // revisar si partido es null
        public Partido generarPartido()
        {
            int c1 = 0, c2 = 0;
            bool listo1 = false, listo2 = false;
            Equipo E1, E2;
            Partido par = null;
            List<Equipo> equiposgenerar = listaDisponiblesOr();
            if (equiposgenerar != null && equiposgenerar.Count > 1)
            {
                while (listo1 == false)
                {
                    if (c1 < equiposgenerar.Count)
                    {
                        E1 = equiposgenerar[c1];
                        c2 = 0;
                        while (listo2 == false)
                        {
                            if (c2 == c1)
                            {
                                c2++;
                            }
                            if (c2 < equiposgenerar.Count)
                            {
                                E2 = equiposgenerar[c2];
                                bool disponible = verificar(E1, E2.IDe);
                                if (disponible == true)
                                {
                                    listo2 = true;
                                    listo1 = true;
                                    par = new Partido(E1.IDe, E2.IDe, this);
                                    partidos.Add(par);
                                    E1.disponible = false;
                                    E2.disponible = false;
                                    E1.contra.Add(E2.IDe);
                                    E2.contra.Add(E1.IDe);
                                    restarFechaTar(par.eq1.IDe);
                                    restarFechaTar(par.eq2.IDe);


                                }
                                else
                                {
                                    c2++;
                                }
                            }
                            else
                            {
                                listo2 = true;
                            }


                            // fin de while 2
                        }
                        c1++;
                        if (c1 > equiposgenerar.Count)
                        {
                            listo2 = true;
                            listo1 = true;
                        }
                    }
                    else
                    {
                        listo1 = true;
                    }
                    // fin de while1
                }
                return par;
            }
            else
            {
                return null;
            }
        }

        public bool verificar(Equipo equi, int id)
        {
            if (equi.contra.Contains(id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void numPartidos()
        {
            int i = equipos.Count -1;
            int suma = 0;
            while (i != 0)
            {
                suma += i;
                i--;
            }
            NUM_PAR = suma;
        }

        public bool revisarNumPar()
        {
            if (NUM_PAR == partidos.Count)
            {
                foreach (Equipo item in equipos)
                {
                    item.contra.Clear();
                    Console.WriteLine("Limpio partidos");
                }
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public bool revisarNumParFinal()
        {
            if ((NUM_PAR * 2) == (partidos.Count ))
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public void terminarPartido(int idp)
        {
            Partido par = partidos.Find(x => x.IDp == idp);
            par.activo = false;

            par.eq1.disponible = true;
            par.eq1.parJugados++;

            par.eq2.disponible = true;
            par.eq2.parJugados++;
           


        }

        public void resultadosPartido(int idp, int golesE1, int golesE2)
        {
            Partido par = partidos.Find(x => x.IDp == idp);
            par.golesE1 = golesE1;
            par.golesE2 = golesE2;

            par.eq1.golesF += golesE1;
            par.eq1.golesC += golesE2;
            par.eq1.DFgoles += golesE1 - golesE2;

            par.eq2.golesF+= golesE2;
            par.eq2.golesC += golesE1;
            par.eq2.DFgoles += golesE2 - golesE1;

            if (golesE1 > golesE2)
            {
                par.ganadorID = par.equi1;
                par.eq1.puntos += 3;
                par.eq1.pGanados += 1;
                par.eq2.pPerdidos += 1;
            }
            else
            {
                if (golesE2 > golesE1)
                {
                    par.ganadorID = par.equi2;
                    par.eq2.puntos += 3;
                    par.eq2.pGanados += 1;
                    par.eq1.pPerdidos += 1;
                }
            }

            if (golesE1 == golesE2)
            {
                par.ganadorID = -1;
                par.eq1.puntos += 1;
                par.eq2.puntos += 1;
                par.eq1.pEmpatados += 1;
                par.eq2.pEmpatados += 1;
            }
        }
        public void ingresarTargeta(int num, string nombre12, string tipo, int idEqui)
        {
            Jugador jug = new Jugador(num,nombre12,tipo);
            Console.WriteLine("{0}_{1}_{2}", num, nombre12, tipo);
            Equipo equi = equipos.Find(x => x.IDe == idEqui);
            if (tipo == "amarilla")
            {
                Jugador jug1 = equi.amarillas.Find(x => x.numeroJ == num);
                if (jug1 != null)
                {
                    equi.amarillas.Remove(jug1);
                    jug1.mensaje = "ACUMULACION DE AMARILAS";
                    jug1.restante = Jugador.fechaRoj;
                    equi.rojas.Add(jug1);
                }
                else
                {
                    jug.mensaje = "El jugador tiene una amarilla";
                    equi.amarillas.Add(jug);
                    Console.WriteLine(jug.ToString());
                }
            }
            else
            {
                jug.mensaje = "EL JUGADOR TIENE ROJA";
                equi.rojas.Add(jug);
            }

        }

        public void restarFechaTar(int IDe)
        {
            Equipo equi = equipos.Find(x => x.IDe == IDe);
            List<Jugador> jugadores = new List<Jugador>();

            if (equi.amarillas.Count != 0)
            {
                foreach (Jugador jug in equi.amarillas)
                {
                    if (jug.restante > 0)
                    {
                        jugadores.Add(jug);
                    }
                }

                equi.amarillas = jugadores;
                foreach (Jugador jug in equi.amarillas)
                {
                    jug.restante += -1;
                }
            }


            if (equi.rojas.Count != 0)
            {
                jugadores = new List<Jugador>();
                foreach (Jugador jug in equi.rojas)
                {
                    if (jug.restante > 0)
                    {
                        jugadores.Add(jug);
                    }
                }
                equi.rojas = jugadores;
                foreach (Jugador jug in equi.rojas)
                {
                    jug.restante += -1;
                }
            }
        }

        public List<Equipo> ordenarPuntos()
        {
            List<Equipo> equiposOr = equipos;
            equiposOr.Sort();
            equiposOr.Reverse();
           /* IEnumerable<Equipo> orden = equiposOr.OrderByDescending(x => x.puntos);
            List<Equipo> dispo = new List<Equipo>();
            foreach (Equipo item in orden)
            {
                dispo.Add(item);


            }*/

            return equiposOr;
        }

        /* public List<Jugador> revisarJugador(int IDe)
         {
             Equipo equi = equipos.Find(x => x.IDe == IDe);
             int cont = 0;
             Jugador jug1, jug2;
             for (int i = 0; i < equi.amarillas.Count; i++)
             {
                 jug1 = equi.amarillas[i];
                 for (int j = 0; j < equi.amarillas.Count; j++)
                 {

                     if (i == j)
                     {
                         j++;
                     }
                     jug2 = equi.amarillas[j];
                     if (jug1.numeroJ == jug2.numeroJ)
                     {

                     }

                 }
             }
         }*/


        public int golesMarcados()
        {
            int goles = 0;
            foreach (Equipo item in equipos)
            {
                goles += item.golesF;
            }

            return goles;
        }

        public float PromedioGoles()
        {
            float goles = 0;
            float promedio = 0;
            goles = golesMarcados();
            if (partidos.Count != 0)
            {
                promedio = (float)goles / (float)partidos.Count;
            }
            else
            {
                promedio = -1;
            }
            return promedio;
        }

        public Equipo maxNumG()
        {
            int max = 0;
            Equipo equi = null;
            foreach (Equipo item in equipos)
            {
                if (item.golesF > max)
                {
                    max = item.golesF;
                    equi = item;
                }
            }
            return equi;
        }
        public Equipo minNumGC()
        {
            int min = 500;
            Equipo equi = null;
            foreach (Equipo item in equipos)
            {
                if (item.golesC < min)
                {
                    min = item.golesC;
                    equi = item;
                }
            }

            return equi;
        }
        
    }
}
