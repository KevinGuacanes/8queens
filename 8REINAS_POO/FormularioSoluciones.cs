using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _8REINAS_POO
{
    public partial class FormularioSoluciones : Form
    {

        Button[,] botones = new Button[8, 8];
        //Backtracking backtracking;
        Reina r;


        public FormularioSoluciones()
        {
            InitializeComponent();
            r = new Reina(8);
            r.ColocarReinas(0);
           
            Imprimir();

        }

        private void FormularioSoluciones_Load(object sender, EventArgs e)
        {
            DibujarTablero();
        }


        public void DibujarTablero()
        {
            //AQUI CREO EL TABLERO DE 8x8 CON BOTONES BLANCOS Y NEGROS


            for (int fila = 0; fila < 8; fila++)
            {
                for (int columna = 0; columna < 8; columna++)
                {
                    // Crear un nuevo botón
                    Button boton = new Button();
                    botones[fila, columna] = boton;
                    // Establecer el tamaño del botón para que se ajuste a la celda
                    boton.Dock = DockStyle.Fill;


                    // Cambia el color de fondo del botón
                    if ((fila + columna) % 2 == 0)
                    {
                        boton.BackColor = Color.White;
                    }
                    else
                    {
                        boton.BackColor = Color.Black;
                    }
                    // Agregar el botón al TableLayoutPanel
                    tableLayoutPanel1.Controls.Add(boton, columna, fila);

                }
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {


        }

        public void Imprimir()
        {
            String resp;
            char vocal;

            for (int i = 0; i < 92; i++)
            {


                resp = i + ".-";

                vocal = 'A';
                for (int j = 0; j < 8; j++)
                {
                    resp = resp + r.arreglosol[i][j] + "" + vocal + " ";
                    vocal++;
                }

                cbSoluciones.Items.Add(resp);
            }

        }
        private void cbSoluciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pintar()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    botones[i, j].Enabled = true;// para no hacer clic
                    if ((i + j) % 2 == 0)
                    {
                        botones[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        botones[i, j].BackColor = Color.Black;
                    }
                }
            }

        }
        private void btnSolucionar_Click(object sender, EventArgs e)
        {
            pintar();
            int idx;
            idx = Convert.ToInt16(cbSoluciones.SelectedIndex.ToString());

            int[] Arreglo;
            Arreglo = r.arreglosol[idx];


            for (int i = 0; i < 7; i++)
            {
                botones[i, (Arreglo[i])].BackColor = Color.Yellow;
            }

        }
    }
}