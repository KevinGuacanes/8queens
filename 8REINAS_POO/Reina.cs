using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8REINAS_POO
{
    internal class Reina
    {

        private int[] reinas; // representa la posición de las reinas en el tablero
        private int soluciones;
        public int[][] arreglosol;


        public Reina(int n)
        {
            this.reinas = new int[n];
           
            this.soluciones = 0;


            Console.WriteLine(reinas.Length);
            ImprimirSolucion();

            arreglosol = new int[93][];
            for (int i = 0; i < arreglosol.Length; i++)
            {
                arreglosol[i] = new int[8];
            }

        }

        public int GetSoluciones()
        {
            return soluciones;
        }

        public void ColocarReinas(int filaObjetivo)

        {

            if (filaObjetivo == reinas.Length) // si se han colocado 8 reinas en el tablero
            {
                if (soluciones >=1&& soluciones<=93)
                {

                    arreglosol[(soluciones-1)] = (int[])reinas.Clone();
                 
                }
                
                soluciones++;

            }

            for (int columna = 0; columna < reinas.Length; columna++)
            {
                if (EsLugarValido(filaObjetivo, columna))
                {
                    reinas[filaObjetivo] = columna; // se coloca reina en el tablero

                    ColocarReinas(filaObjetivo + 1);
                }
            }
        }


        public bool EsLugarValido(int filasOcupadas, int columna)
        {
            for (int i = 0; i < filasOcupadas; i++) // se verifica si alguna reina se encuentra en la misma columna o en la misma diagonal
            {
                if (reinas[i] == columna || // misma columna
                    reinas[i] - i == columna - filasOcupadas || // misma diagonal izquierda-derecha
                    reinas[i] + i == columna + filasOcupadas)   // misma diagonal derecha-izquierda
                {
                    return false;
                }
            }
            return true;
        }

        public void ImprimirSolucion()
        {
            soluciones++;
            for (int fila = 0; fila < reinas.Length; fila++)
            {
                for (int columna = 0; columna < reinas.Length; columna++)
                {
                    if (reinas[fila] == columna)
                    {
                        Console.Write("|Q");
                    }
                    else
                    {
                        Console.Write("|_");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }


        public void Imprimir()
        {
           
            char vocal;
            
            for (int i = 0; i < 92; i++)
            {
                
                vocal = 'A';
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine( arreglosol[i][j] + " "+vocal);
                    vocal++;
                }
                
                
                Console.WriteLine();
            }

        }

    }
}

