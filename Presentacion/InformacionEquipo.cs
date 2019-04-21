using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class InformacionEquipo : UserControl
    {
        Sistema sis;
        public InformacionEquipo(Sistema sis)
        {
            InitializeComponent();
            this.sis = sis;
        }

        private void InformacionEquipo_Load(object sender, EventArgs e)
        {
            ordenPuntos();
        }
        public void ordenPuntos()
        {
            listView1.Items.Clear();
            List<Equipo> ordenPuntos = sis.ordenarPuntos();

            int cont = 0;
            foreach (Equipo item in ordenPuntos)
            {
                ListViewItem lista = new ListViewItem(Convert.ToString(cont++));
                lista.SubItems.Add(item.nombreEq);
                lista.SubItems.Add(item.nombrePe);
                lista.SubItems.Add(Convert.ToString(item.parJugados));
                lista.SubItems.Add(Convert.ToString(item.pGanados));
                lista.SubItems.Add(Convert.ToString(item.pEmpatados));
                lista.SubItems.Add(Convert.ToString(item.pPerdidos));
                lista.SubItems.Add(Convert.ToString(item.golesF));
                lista.SubItems.Add(Convert.ToString(item.golesC));
                lista.SubItems.Add(Convert.ToString(item.DFgoles));
                lista.SubItems.Add(Convert.ToString(item.puntos));
                lista.BackColor = System.Drawing.Color.FromArgb(setColor(item.color).ToArgb());
                listView1.Items.Add(lista);

            }
        }

        private void ordenarGoles()
        {
            listView1.Items.Clear();
            IEnumerable<Equipo> ordenGoles = sis.equipos.OrderByDescending(x => x.golesF);
            int cont = 0;
            foreach (Equipo item in ordenGoles)
            {
                ListViewItem lista = new ListViewItem(Convert.ToString(cont++));
                lista.SubItems.Add(item.nombreEq);
                lista.SubItems.Add(item.nombrePe);
                lista.SubItems.Add(Convert.ToString(item.parJugados));
                lista.SubItems.Add(Convert.ToString(item.pGanados));
                lista.SubItems.Add(Convert.ToString(item.pEmpatados));
                lista.SubItems.Add(Convert.ToString(item.pPerdidos));
                lista.SubItems.Add(Convert.ToString(item.golesF));
                lista.SubItems.Add(Convert.ToString(item.golesC));
                lista.SubItems.Add(Convert.ToString(item.DFgoles));
                lista.SubItems.Add(Convert.ToString(item.puntos));
                lista.BackColor = System.Drawing.Color.FromArgb(setColor(item.color).ToArgb());
                listView1.Items.Add(lista);

            }
        }

        private void ordenarDF()
        {
            listView1.Items.Clear();
            IEnumerable<Equipo> ordenGoles = sis.equipos.OrderByDescending(x => x.DFgoles);
            int cont = 0;
            foreach (Equipo item in ordenGoles)
            {
                ListViewItem lista = new ListViewItem(Convert.ToString(cont++));
                lista.SubItems.Add(item.nombreEq);
                lista.SubItems.Add(item.nombrePe);
                lista.SubItems.Add(Convert.ToString(item.parJugados));
                lista.SubItems.Add(Convert.ToString(item.pGanados));
                lista.SubItems.Add(Convert.ToString(item.pEmpatados));
                lista.SubItems.Add(Convert.ToString(item.pPerdidos));
                lista.SubItems.Add(Convert.ToString(item.golesF));
                lista.SubItems.Add(Convert.ToString(item.golesC));
                lista.SubItems.Add(Convert.ToString(item.DFgoles));
                lista.SubItems.Add(Convert.ToString(item.puntos));
                lista.BackColor = System.Drawing.Color.FromArgb(setColor(item.color).ToArgb());

                listView1.Items.Add(lista);

            }
        }

        private Color setColor(string color)
        {
            Color colorS = new Color();
            switch (color)
            {
                case "Rojo":

                    colorS = Color.FromArgb(255, 71, 71);
                    break;

                case "Blanco":

                    colorS = Color.FromArgb(255, 255, 255);
                    break;

                case "Azul":

                    colorS = Color.FromArgb(0, 204, 255);
                    break;

                case "Amarillo":

                    colorS = Color.FromArgb(255, 255, 51);
                    break;

                case "Naranja":

                    colorS = Color.FromArgb(255, 100, 61);
                    break;

                case "Verde":

                    colorS = Color.FromArgb(0, 255, 51);
                    break;

                case "Cyan":
                    colorS = Color.FromArgb(61, 216, 255);
                    break;

                case "Morado":
                    colorS = Color.FromArgb(197, 61, 255);
                    break;

                default:

                    break;
            }
            return colorS;
        }

        public void updateEstadistica()
        {
            LA_tPartidos.Text = Convert.ToString(sis.partidos.Count);
            LA_goles.Text = Convert.ToString(sis.golesMarcados());
            LA_promedio.Text = Convert.ToString(sis.PromedioGoles());
            if (sis.maxNumG() != null)
            {
                LA_maximoN.Text = Convert.ToString(sis.maxNumG().golesF);

                LA_maximoE.Text = sis.maxNumG().nombreEq;
            }
            if (sis.maxNumG() != null)
            {
                LA_porteriaN.Text = Convert.ToString(sis.maxNumG().golesC);

                LA_porteriaE.Text = sis.minNumGC().nombreEq;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordenPuntos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordenarGoles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordenarDF();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
