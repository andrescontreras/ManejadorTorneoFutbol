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
    public partial class ListaPartidos : UserControl
    {
        Sistema sis;
        public ListaPartidos(Sistema sis)
        {
            InitializeComponent();
            this.sis = sis;
           
        }

        public void ListaPartidos_Load(object sender, EventArgs e)
        {
            updateList();
             foreach (var item in sis.equipos)
            {
                this.CB_nombreEq.Items.AddRange(new object[] {
            item.nombreEq});
            }
        }
        public void updateList()
        {
            LV_partidos.Items.Clear();
            string estado;
            foreach (Partido item in sis.partidos)
            {
                ListViewItem lista = new ListViewItem(item.eq1.nombreEq);
                lista.SubItems.Add(item.eq2.nombreEq);
                lista.SubItems.Add(Convert.ToString(item.golesE1));
                lista.SubItems.Add(Convert.ToString(item.golesE2));
                if (item.activo == true)
                {
                    estado = "En juego";
                }
                else
                {
                    estado = "Terminaod";
                }
                lista.SubItems.Add(estado);
                LV_partidos.Items.Add(lista);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombreEq = CB_nombreEq.Text;
            List<Partido> partidos = new List<Partido>();
            foreach (Partido item in sis.partidos)
            {
                if (item.eq1.nombreEq == nombreEq || item.eq2.nombreEq == nombreEq)
                {
                    partidos.Add(item);
                    Console.WriteLine("BUSQUEDA PAR"+item.ToString());
                }
            }
            LV_partidos.Items.Clear();
            string estado;
            foreach (Partido item in partidos)
            {
                ListViewItem lista = new ListViewItem(item.eq1.nombreEq);
                lista.SubItems.Add(item.eq2.nombreEq);
                lista.SubItems.Add(Convert.ToString(item.golesE1));
                lista.SubItems.Add(Convert.ToString(item.golesE2));
                if (item.activo == true)
                {
                    estado = "En juego";
                }
                else
                {
                    estado = "Terminaod";
                }
                lista.SubItems.Add(estado);
                lista.BackColor = System.Drawing.Color.LightGreen;
                
                LV_partidos.Items.Add(lista);
            }
        }
    }
}
