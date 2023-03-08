using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _8REINAS_POO
{
    internal class Backtracking
    {

        public int[,] tablero;
        public int reinasColocadas;


        public Backtracking(int[,] tablero)
        {
            this.tablero = tablero;      
            this.reinasColocadas = 0;
        }

        public bool EsValida(int fila, int columna)
        {
            // Verificar si hay otra reina en la misma fila
            for (int i = 0; i < 8; i++)
            {
                if (this.tablero[fila, i] == 1)
                {
                    return false;
                }
            }

            // Verificar si hay otra reina en la misma columna
            for (int i = 0; i < 8; i++)
            {
                if (this.tablero[i, columna] == 1)
                {
                    return false;
                }
            }

            // Verificar si hay otra reina en la misma diagonal
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Math.Abs(i - fila) == Math.Abs(j - columna) && this.tablero[i, j] == 1)
                    {
                        return false;
                    }
                }
            }

            // Si no hay ninguna otra reina en la misma fila, columna o diagonal, la posición es valida
            return true;
        }

        public bool resolver()
        {
            for (int fila = 0; fila < 8; fila++)
            {
                for (int columna = 0; columna < 8; columna++)
                {
                    if (EsValida(fila, columna))
                    {
                        this.tablero[fila, columna] = 1;
                        this.reinasColocadas++;
                        if (this.reinasColocadas == 8)
                        {
                            return true;
                        }
                        if (resolver())
                        {
                            return true;
                        }
                        this.reinasColocadas--;
                        this.tablero[fila, columna] = 0;
                    }
                }
            }
            
            return false;
        }

        public void InicializarTablero()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.tablero[i, j] = 0;
                }
            }
            this.reinasColocadas = 0;
        }
       
    }

}
