using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8REINAS_POO
{
    public partial class FormularioTablero : Form
    {
        Backtracking backtracking;
        Button[,] botones = new Button[8, 8];
        int[,] tablero = new int[8, 8];
        int reinasColocadas=0;
        private int intentos = 0;
        public FormularioTablero()
        {
            InitializeComponent();
        
        }
        //AQUI CREO EL TABLERO DE 8x8 CON BOTONES BLANCOS Y NEGROS
        private void FormularioTablero_Load(object sender, EventArgs e)
        {
            backtracking = new Backtracking(tablero);
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
                    boton.Click += BotonPresionado;
                }
            }

        }


        private void BotonPresionado(object sender, EventArgs e)
        {
            // Obtener la posición del botón presionado en la matriz
            int fila = 0, columna = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (sender == botones[i, j])
                    {
                        fila = i;
                        columna = j;
                    }
                }
            }

            // Utilizar algoritmo de backtracking para determinar si la posición es valida
            if (backtracking.EsValida(fila, columna))
            {
                // Colocar reina en la posición valida
                tablero[fila, columna] = 1;
                //((Button)sender).Image = Properties.Resources.reina;
                ((Button)sender).BackColor = Color.Yellow;
                reinasColocadas++;

                // Verificar si se han colocado 8 reinas
                if (reinasColocadas == 8)
                {
                    MessageBox.Show("¡Felicidades! Has colocado 8 reinas en el tablero.");

                }
                
            }
            else
            {
                // Mostrar mensaje de error si la posición no es valida
                MessageBox.Show("La posición seleccionada no es valida para colocar una reina.");
                //Volver a colorear el boton a su color original
                if ((fila + columna) % 2 == 0)
                {
                    ((Button)sender).BackColor = Color.White;
                }
                else
                {
                    ((Button)sender).BackColor = Color.Black;
                }
                intentos++;

            }

            //textbox para que ingrese la cantidad de intentos
            int intentos1;
            intentos1 = Convert.ToInt32(txtIntentos.Text);
             
            // Verificar si el jugador ha perdido el juego
            if (intentos == intentos1 && reinasColocadas < 8)
            {
                MessageBox.Show("Ha perdido el juego.");
                // Deshabilitar todos los botones para que ya no pueda dar click
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        botones[i, j].Enabled = false;
                    }
                }
                
            }

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Reiniciar el juego
            reinasColocadas = 0;
            intentos = 0;
            backtracking.InicializarTablero();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    botones[i, j].Enabled = true;
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

        private void btnSoluciones_Click(object sender, EventArgs e)
        {
            FormularioSoluciones VentanaSoluciones = new FormularioSoluciones();
            VentanaSoluciones.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha perdido el juego.");
        }
    }
}
