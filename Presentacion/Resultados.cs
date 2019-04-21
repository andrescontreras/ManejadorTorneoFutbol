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
    public partial class Resultados : UserControl
    {
        Sistema sis;
        Partido par;
        AgregarPartido agregar;
        List<Jugador> jugadores;
        public Resultados( Sistema sistema , Partido par, AgregarPartido agregar)
        {
            InitializeComponent();
            jugadores = new List<Jugador>();
            this.sis = sistema;
            this.par = par;
            this.agregar = agregar;
            ponerEquipos();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            int num;
            bool canConvert = int.TryParse(TB_E1.Text, out num);
            if (int.TryParse(TB_E1.Text, out num) && int.TryParse(TB_E2.Text, out num))
            {
                agregar.activar();
                sis.resultadosPartido(par.IDp, Convert.ToInt32(TB_E1.Text), Convert.ToInt32(TB_E2.Text));
                MessageBox.Show("Se han guardados los datos y terminado partido", "Finalizar partido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Se han ingresado datos incorrectos", "Finalizar partido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ponerEquipos()
        {
            string Equi;
            LA_EQ1.Text = par.eq1.nombreEq;
            Equi = par.eq1.nombreEq;
            this.CB_equipoA.Items.AddRange(new object[] {
            Equi});

            this.CB_equipor.Items.AddRange(new object[] {
            Equi});
            switch (par.eq1.color)
            {
                case "Rojo":
                    LA_EQ1.BackColor = System.Drawing.Color.Red;

                    break;

                case "Blanco":
                    LA_EQ1.BackColor = System.Drawing.Color.White;

                    break;

                case "Azul":
                    LA_EQ1.BackColor = System.Drawing.Color.Blue;
                    break;

                case "Amarillo":
                    LA_EQ1.BackColor = System.Drawing.Color.Yellow;
                    break;

                case "Naranja":
                    LA_EQ1.BackColor = System.Drawing.Color.Orange;
                    break;

                case "Verde":
                    LA_EQ1.BackColor = System.Drawing.Color.Green;
                    break;

                case "Cyan":
                    LA_EQ1.BackColor = System.Drawing.Color.Cyan;
                    break;

                case "Morado":
                    LA_EQ1.BackColor = System.Drawing.Color.Purple;
                    break;

                default:

                    break;
            }
            LA_EQ2.Text = par.eq2.nombreEq;
            Equi = par.eq2.nombreEq;
            this.CB_equipoA.Items.AddRange(new object[] {
            Equi});

            this.CB_equipor.Items.AddRange(new object[] {
            Equi});
            switch (par.eq2.color)
            {
                case "Rojo":
                    LA_EQ2.BackColor = System.Drawing.Color.Red;

                    break;

                case "Blanco":
                    LA_EQ2.BackColor = System.Drawing.Color.White;

                    break;

                case "Azul":
                    LA_EQ2.BackColor = System.Drawing.Color.Blue;
                    break;

                case "Amarillo":
                    LA_EQ2.BackColor = System.Drawing.Color.Yellow;
                    break;

                case "Naranja":
                    LA_EQ2.BackColor = System.Drawing.Color.Orange;
                    break;

                case "Verde":
                    LA_EQ2.BackColor = System.Drawing.Color.Green;
                    break;

                case "Cyan":
                    LA_EQ2.BackColor = System.Drawing.Color.Cyan;
                    break;

                case "Morado":
                    LA_EQ2.BackColor = System.Drawing.Color.Purple;
                    break;

                default:

                    break;
            }
        }

        private void BT_amarilla_Click(object sender, EventArgs e)
        {
            int IDe = sis.equipos.Find(x => x.nombreEq == CB_equipoA.Text).IDe;
            sis.ingresarTargeta(Convert.ToInt32(TB_numeroJA.Text),TB_nombreJA.Text,"amarilla",IDe);
            TB_nombreJA.Clear();
            TB_numeroJA.Clear();
        }

        private void BT_roja_Click(object sender, EventArgs e)
        {
            int IDe = sis.equipos.Find(x => x.nombreEq == CB_equipor.Text).IDe;
            sis.ingresarTargeta(Convert.ToInt32(TB_numeroJR.Text), TB_nombreJR.Text, "roja", IDe);
            TB_nombreJR.Clear();
            TB_numeroJR.Clear();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {

        }
    }
}
