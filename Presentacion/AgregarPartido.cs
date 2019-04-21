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
    public partial class AgregarPartido : UserControl
    {
        Sistema sis;
        int cont = 0;
        bool P1 = false;
        bool P2 = false;
        Partido pa;
       // Resultados resul = new Resultados(sis ,null,this);
        public AgregarPartido(Sistema sis)
        {
            InitializeComponent();
            this.sis = sis;
        }

        private void BT_agregarP_Click(object sender, EventArgs e)
        {
            Partido par= null;
            if (P1 != true || P2 != true)
            {
                par = sis.generarPartido();
                pa = par;
            }
            else
            {
                MessageBox.Show("no hay espacio para partido...");
            }
            if (par != null)
            {



                if (P1 == false)
                {
                    LA_P1E1.Text = par.eq1.nombreEq;
                    switch (par.eq1.color)
                    {
                        case "Rojo":
                            LA_P1E1.BackColor = System.Drawing.Color.Red;

                            break;

                        case "Blanco":
                            LA_P1E1.BackColor = System.Drawing.Color.White;

                            break;

                        case "Azul":
                            LA_P1E1.BackColor = System.Drawing.Color.Blue;
                            break;

                        case "Amarillo":
                            LA_P1E1.BackColor = System.Drawing.Color.Yellow;
                            break;

                        case "Naranja":
                            LA_P1E1.BackColor = System.Drawing.Color.Orange;
                            break;

                        case "Verde":
                            LA_P1E1.BackColor = System.Drawing.Color.Green;
                            break;

                        case "Cyan":
                            LA_P1E1.BackColor = System.Drawing.Color.Cyan;
                            break;

                        case "Morado":
                            LA_P1E1.BackColor = System.Drawing.Color.Purple;
                            break;

                        default:

                            break;
                    }
                    LA_P1E2.Text = par.eq2.nombreEq;
                    switch (par.eq2.color)
                    {
                        case "Rojo":
                            LA_P1E2.BackColor = System.Drawing.Color.Red;

                            break;

                        case "Blanco":
                            LA_P1E2.BackColor = System.Drawing.Color.White;

                            break;

                        case "Azul":
                            LA_P1E2.BackColor = System.Drawing.Color.Blue;
                            break;

                        case "Amarillo":
                            LA_P1E2.BackColor = System.Drawing.Color.Yellow;
                            break;

                        case "Naranja":
                            LA_P1E2.BackColor = System.Drawing.Color.Orange;
                            break;

                        case "Verde":
                            LA_P1E2.BackColor = System.Drawing.Color.Green;
                            break;

                        case "Cyan":
                            LA_P1E2.BackColor = System.Drawing.Color.Cyan;
                            break;

                        case "Morado":
                            LA_P1E2.BackColor = System.Drawing.Color.Purple;
                            break;

                        default:

                            break;
                    }
                    cont++;
                    P1 = true;
                    this.CB_terminar.Items.AddRange(new object[] {
                            par.ToString()});

                }
                else
                {

                    if (P2 == false)

                    {
                        LA_P2E1.Text = par.eq1.nombreEq;
                        switch (par.eq1.color)
                        {
                            case "Rojo":
                                LA_P2E1.BackColor = System.Drawing.Color.Red;

                                break;

                            case "Blanco":
                                LA_P2E1.BackColor = System.Drawing.Color.White;

                                break;

                            case "Azul":
                                LA_P2E1.BackColor = System.Drawing.Color.Blue;
                                break;

                            case "Amarillo":
                                LA_P2E1.BackColor = System.Drawing.Color.Yellow;
                                break;

                            case "Naranja":
                                LA_P2E1.BackColor = System.Drawing.Color.Orange;
                                break;

                            case "Verde":
                                LA_P1E1.BackColor = System.Drawing.Color.Green;
                                break;

                            case "Cyan":
                                LA_P2E1.BackColor = System.Drawing.Color.Cyan;
                                break;

                            case "Morado":
                                LA_P2E1.BackColor = System.Drawing.Color.Purple;
                                break;

                            default:

                                break;
                        }
                        LA_P2E2.Text = par.eq2.nombreEq;
                        switch (par.eq2.color)
                        {
                            case "Rojo":
                                LA_P2E2.BackColor = System.Drawing.Color.Red;

                                break;

                            case "Blanco":
                                LA_P2E2.BackColor = System.Drawing.Color.White;

                                break;

                            case "Azul":
                                LA_P2E2.BackColor = System.Drawing.Color.Blue;
                                break;

                            case "Amarillo":
                                LA_P2E2.BackColor = System.Drawing.Color.Yellow;
                                break;

                            case "Naranja":
                                LA_P2E2.BackColor = System.Drawing.Color.Orange;
                                break;

                            case "Verde":
                                LA_P2E2.BackColor = System.Drawing.Color.Green;
                                break;

                            case "Cyan":
                                LA_P2E2.BackColor = System.Drawing.Color.Cyan;
                                break;

                            case "Morado":
                                LA_P2E2.BackColor = System.Drawing.Color.Purple;
                                break;

                            default:

                                break;
                        }
                        cont++;
                        P2 = true;
                        this.CB_terminar.Items.AddRange(new object[] {
                            par.ToString()});
                    }
                    else
                    {

                        MessageBox.Show("no hay espacio para partido");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay mas partidos", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (sis.revisarNumPar() == true)
            {
                MessageBox.Show("Se han terminado los partidos de IDA ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            if (sis.revisarNumParFinal() == true)
            {
                MessageBox.Show("Se han completado todos los partidos de fase de grupos ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LA_titulo.Text = "FASE DE TODOS CONTRA TODOS TERMINADA";
                LA_titulo.BackColor = System.Drawing.Color.IndianRed;
                BT_agregarP.Enabled = false;
            }
            
            Console.WriteLine("FINAL AGREGAR");
            llenarListView();
        }

        private void llenarListView()
        {
            listView1.Items.Clear();
            Console.WriteLine("ENTRO LLENAR");
            if (pa != null)
            {
                List<Jugador> jugadores = pa.eq1.amarillas;

                foreach (Jugador item in jugadores)
                {
                    Console.WriteLine(item.ToString());
                    ListViewItem lista = new ListViewItem(item.nombreJ);
                    lista.SubItems.Add(Convert.ToString(item.numeroJ));
                    lista.SubItems.Add(pa.eq1.nombreEq);
                    lista.SubItems.Add(item.mensaje);

                    lista.BackColor = System.Drawing.Color.Yellow;
                    listView1.Items.Add(lista);
                }

                jugadores = pa.eq1.rojas;
                foreach (Jugador item in jugadores)
                {
                    Console.WriteLine(item.ToString());
                    ListViewItem lista = new ListViewItem(item.nombreJ);
                    lista.SubItems.Add(Convert.ToString(item.numeroJ));
                    lista.SubItems.Add(pa.eq1.nombreEq);
                    lista.SubItems.Add(item.mensaje);

                    lista.BackColor = System.Drawing.Color.IndianRed;
                    listView1.Items.Add(lista);
                }

                jugadores = pa.eq2.amarillas;
                foreach (Jugador item in jugadores)
                {
                    Console.WriteLine(item.ToString());
                    ListViewItem lista = new ListViewItem(item.nombreJ);
                    lista.SubItems.Add(Convert.ToString(item.numeroJ));
                    lista.SubItems.Add(pa.eq2.nombreEq);
                    lista.SubItems.Add(item.mensaje);
                    lista.BackColor = System.Drawing.Color.Yellow;
                    listView1.Items.Add(lista);
                }

                jugadores = pa.eq2.rojas;
                foreach (Jugador item in jugadores)
                {
                    Console.WriteLine(item.ToString());
                    ListViewItem lista = new ListViewItem(item.nombreJ);
                    lista.SubItems.Add(Convert.ToString(item.numeroJ));
                    lista.SubItems.Add(pa.eq2.nombreEq);
                    lista.SubItems.Add(item.mensaje);
                    lista.BackColor = System.Drawing.Color.IndianRed;
                    listView1.Items.Add(lista);
                }

            }

        }
       

        private void BT_terminarPar_Click_1(object sender, EventArgs e)
        {
            int idP = -1;
            Resultados rel;
            if (CB_terminar.Text == "")
            {
                MessageBox.Show("Seleccione un partido", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (Partido par in sis.partidos)
                {
                    if (par.activo == true && par.ToString() == CB_terminar.Text)
                    {
                        idP = par.IDp;
                        rel = new Resultados(sis, par, this);
                        PA_resultados.Controls.Clear();
                        PA_resultados.Controls.Add(rel);

                        if (LA_P1E1.Text == par.eq1.nombreEq || LA_P1E2.Text == par.eq1.nombreEq)
                        {
                            LA_P1E1.Text = "";
                            LA_P1E1.BackColor = System.Drawing.Color.Gray;

                            LA_P1E2.Text = "";
                            LA_P1E2.BackColor = System.Drawing.Color.Gray;
                            P1 = false;
                        }
                        else
                        {
                            if (LA_P2E1.Text == par.eq1.nombreEq || LA_P2E2.Text == par.eq1.nombreEq)
                            {
                                LA_P2E1.Text = "";
                                LA_P2E1.BackColor = System.Drawing.Color.Gray;

                                LA_P2E2.Text = "";
                                LA_P2E2.BackColor = System.Drawing.Color.Gray;
                                P2 = false;
                            }
                        }
                    }
                }
                if (idP != -1)
                {
                    sis.terminarPartido(idP);
                    this.CB_terminar.Items.Remove(CB_terminar.Text);
                    BT_terminarPar.Enabled = false;


                }
               
                else
                {
                    MessageBox.Show("No se encontro el partido", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }
        public void activar()
        {
            Console.WriteLine("ACTIVO BOTON");
            BT_terminarPar.Enabled = true;
        }
    }
    }
