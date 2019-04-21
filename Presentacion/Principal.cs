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
    public partial class Principal : Form
    {
        Sistema sis;
        AgregarPartido agre;
        ListaPartidos list;
        InformacionEquipo info;
        Targetas tage;
        
        public Principal(Sistema sis)
        {
            InitializeComponent();
            this.sis = sis;
            AgregarPartido agre = new AgregarPartido(sis);
           this.agre = agre;

            ListaPartidos list = new ListaPartidos(sis);
            this.list = list;

            InformacionEquipo info = new InformacionEquipo(sis);
            this.info = info;

            Targetas tage = new Targetas(sis);
            this.tage = tage;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PA_principal.Controls.Clear();                 
            PA_principal.Controls.Add(agre);
        }

        

        private void BT_partiJ_Click(object sender, EventArgs e)
        {
            PA_principal.Controls.Clear();
            list.updateList();
            PA_principal.Controls.Add(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_infoEq_Click(object sender, EventArgs e)
        {
            PA_principal.Controls.Clear();
            info.ordenPuntos();
            info.updateEstadistica();
            PA_principal.Controls.Add(info);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PA_principal.Controls.Clear();
            PA_principal.Controls.Add(tage);
            tage.updateList(); 
        }

        private void PA_principal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
