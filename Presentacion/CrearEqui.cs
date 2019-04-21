using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class CrearEqui : Form
    {
        Sistema sis;
        public CrearEqui(Sistema sistema)
        {
            InitializeComponent();
            sis = sistema;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarEqui();
            TB_nEquipo.Clear();
            TB_nJugador.Clear();
            
        }
        private void agregarEqui()
        {
            string r1 = "se agrego correctamente";
            string r2 = "el nombre de la persona ya esta en el sistema";
            string r3 = "el color diferenciador ya esta en uso";
            string nPer = TB_nJugador.Text;
            string nEqu = TB_nEquipo.Text;
            string color = CB_color.Text;
            string respuesta;
            respuesta = sis.crearEquipo(nEqu, nPer, color);
            LA_exepcionn.Text = respuesta;
            if (respuesta == r1)
            {
                pictureBox1.Image = global::Presentacion.Properties.Resources.correcto;
            }
            if (respuesta != r1)
            {
                pictureBox1.Image = global::Presentacion.Properties.Resources.exclamation;
            }


            if (respuesta == r1)
            {
                ListViewItem lista = new ListViewItem(nEqu);
                lista.SubItems.Add(nPer);
                lista.SubItems.Add(color);
                switch (color)
                {
                    case "Rojo":
                        lista.ForeColor = System.Drawing.Color.Red;
                       
                        break;

                    case "Blanco":
                        lista.ForeColor = System.Drawing.Color.White;
                        lista.BackColor = System.Drawing.Color.Gray;
                        break;

                    case "Azul":
                        lista.ForeColor = System.Drawing.Color.Blue;
                        break;

                    case "Amarillo":
                        lista.ForeColor = System.Drawing.Color.Yellow;
                        break;

                    case "Naranja":
                        lista.ForeColor = System.Drawing.Color.Orange;
                        break;

                    case "Verde":
                        lista.ForeColor = System.Drawing.Color.Green;
                        break;

                    case "Cyan":
                        lista.ForeColor = System.Drawing.Color.Cyan;
                        break;

                    case "Morado":
                        lista.ForeColor = System.Drawing.Color.Purple;
                        break;

                    default:

                        break;
                }
                lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                listView1.Items.Add(lista);

                
            }
           


            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (CB_amarilla.Text == "" || CB_roja.Text == "")
                {
                    MessageBox.Show("Introdusca valores correctos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Jugador.fechaAma = Convert.ToInt32(CB_amarilla.Text);
                    Jugador.fechaRoj = Convert.ToInt32(CB_roja.Text);
                    sis.numPartidos();
                    Principal princi = new Principal(sis);
                    princi.Show();
                    this.Visible = false;
                }
           
        }

        private void CrearEqui_Load(object sender, EventArgs e)
        {

        }
    }
}
