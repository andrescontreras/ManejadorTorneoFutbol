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
    public partial class Targetas : UserControl
    {
        private Sistema sis;

        public Targetas( Sistema sis)
        {
            InitializeComponent();
            this.sis = sis;
        }

        private void Targetas_Load(object sender, EventArgs e)
        {
            
            foreach (var item in sis.equipos)
            {
                this.CB_nombreE.Items.AddRange(new object[] {
            item.nombreEq});
            }
        }
        public void updateList()
        {
            listView1.Items.Clear();
            foreach (Equipo item in sis.equipos)
            {
                foreach (Jugador item1 in item.amarillas)
                {
                    ListViewItem lista = new ListViewItem(Convert.ToString( item1.numeroJ));
                    lista.SubItems.Add(item1.nombreJ);
                    lista.SubItems.Add(item.nombreEq);
                    lista.SubItems.Add(Convert.ToString( item1.restante));
                    lista.SubItems.Add(item1.mensaje);
                    lista.BackColor = Color.FromArgb(255, 255, 51);
                    listView1.Items.Add(lista);
                }

                foreach (Jugador item1 in item.rojas)
                {
                    ListViewItem lista = new ListViewItem(Convert.ToString(item1.numeroJ));
                    lista.SubItems.Add(item1.nombreJ);
                    lista.SubItems.Add(item.nombreEq);
                    lista.SubItems.Add(Convert.ToString(item1.restante));
                    lista.SubItems.Add(item1.mensaje);
                    lista.BackColor = Color.FromArgb(255, 71, 71);
                    listView1.Items.Add(lista);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CB_nombreE.Text != "")
            {
                Equipo equi = sis.equipos.Find(x => x.nombreEq == CB_nombreE.Text);
                LA_numA.Text = Convert.ToString(equi.amarillas.Count);
                LA_numR.Text = Convert.ToString(equi.rojas.Count);
                listView1.Items.Clear();
                foreach (Jugador item1 in equi.amarillas)
                {
                    ListViewItem lista = new ListViewItem(Convert.ToString(item1.numeroJ));
                    lista.SubItems.Add(item1.nombreJ);
                    lista.SubItems.Add(equi.nombreEq);
                    lista.SubItems.Add(Convert.ToString(item1.restante));
                    lista.SubItems.Add(item1.mensaje);
                    lista.BackColor = Color.FromArgb(255, 255, 51);
                    listView1.Items.Add(lista);
                }

                foreach (Jugador item1 in equi.rojas)
                {
                    ListViewItem lista = new ListViewItem(Convert.ToString(item1.numeroJ));
                    lista.SubItems.Add(item1.nombreJ);
                    lista.SubItems.Add(equi.nombreEq);
                    lista.SubItems.Add(Convert.ToString(item1.restante));
                    lista.SubItems.Add(item1.mensaje);
                    lista.BackColor = Color.FromArgb(255, 71, 71);
                    listView1.Items.Add(lista);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un equipo", "Informacion Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
