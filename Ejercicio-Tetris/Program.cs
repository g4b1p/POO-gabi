using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;


namespace Ejercicio_Tetris
{
    public class Pieza
    {
        // protected para q acceda unicamente a la clase padre e hijos
        protected int[,] forma; // matriz de la pieza
        protected int X;
        protected int Y;
        protected Tablero tablero;

        public Pieza(Tablero tablero)
        {
            this.tablero = tablero; // para que la pieza pueda verificar si ha llegado al final del tablero necesita la altura del tablero
            X = 0;
            Y = 0;
        }

        public void derecha()
        {
            X++;
        }

        public void izquierda()
        {
            X--;
        }

        public void bajar()
        {
            Y++;
        }

        public void rotar()
        {
            // almacena el num de filas y columnas de la pieza [dimensión 0 = filas | dimensión 1 = columnas]
            int filas = forma.GetLength(0);
            int columnas = forma.GetLength(1);

            int[,] nuevaForma = new int[columnas, filas]; 
            // intercambio filas y columnas [filas, columnas] a [columnas, filas]

            for (int i = 0; i < filas; i++) // recorre cada fila de la pieza
            {
                for (int j = 0; j < columnas; j++) // recorre cada columnas de la pieza
                {
                    nuevaForma[j, filas - 1 - i] = forma[i, j]; // mueve cada bloque de la pieza
                }
            }
            forma = nuevaForma;
        }

        public virtual List<(int, int)> posMatriz() // para verificar que celdas están ocupadas
        {
            List<(int, int)> posOcupadas = new List<(int, int)>(); 
            // para guardar las cordenadas de una celda ocupada en el tablero por la pieza

            int filas = forma.GetLength(0);
            int columnas = forma.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (forma[i, j] != 0) // si la celda ta ocupada
                    {
                        int xTablero = X + j;
                        int yTablero = Y + i;

                        posOcupadas.Add((xTablero, yTablero));
                    }
                }
            }
            return posOcupadas;
        }
    }

    public class PiezaI : Pieza
    {
        public PiezaI(int x, int y, Tablero tablero) : base(tablero)
        {
            forma = new int[,]
            {
                { 1, 1, 1, 1 }
            };
            X = x;
            Y = y;
        }
    }

    public class Tablero
    {
        private int[,] tamaño;
        private const int ancho = 20;
        private const int altura = 20;

        public Tablero()
        {
            tamaño = new int[altura, ancho];
        }

        public void agregarPieza(Pieza pieza)
        {
            foreach (var (x, y) in pieza.posMatriz()) // devuelve lista de posiciones ocupadas por la pieza
            {
                if (x >= 0 && x < ancho && y >= 0 && y < altura) // verifico si la pieza esta dentro del limite
                {
                    tamaño[y, x] = 1; // marcada ocupada
                }
            }
        }

        public void mostrar()
        {
            for (int y = -1; y <= altura; y++)
            {
                for (int x = -1; x <= ancho; x++)
                {
                    if (y == -1 || y == altura || x == -1 || x == ancho)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(tamaño[y, x] == 0 ? " " : "@"); // si la celda esta vacia imprime " ", si la celda esta ocupada imprime "@"
                    }
                }
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Tablero tablero = new Tablero();
            Pieza pieza = new PiezaI(8, 0, tablero);

            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear(); // limpiar la consola y mostrar el tablero actualizado
                tablero = new Tablero(); // reiniciar el tablero para actualizar la posición de la pieza
                tablero.agregarPieza(pieza);
                tablero.mostrar();

                tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.LeftArrow:
                        pieza.izquierda();
                        break;
                    case ConsoleKey.RightArrow:
                        pieza.derecha();
                        break;
                    case ConsoleKey.DownArrow:
                        pieza.bajar();
                        break;
                    case ConsoleKey.UpArrow:
                        pieza.rotar();
                        break;
                }
            } while (true);
        }
    }
}