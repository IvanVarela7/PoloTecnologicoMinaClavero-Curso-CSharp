//Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

//Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19,
//      la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
//7)    Mostrar el carton por pantalla
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloTecnologicoClase9Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();

            int fila = 3;
            int columna = 9;

            int[,] cartonBingo = new int[fila, columna];


            //Llenar carton de bingo

            for (int i = 0; i < fila; i++)
            {

                for (int j = 0; j < columna; j++)
                {
                    switch (j)
                    {
                        case 0:
                            cartonBingo[i, j] = random.Next(1, 9);
                            break;

                        case 1:
                            cartonBingo[i, j] = random.Next(10, 19);
                            break;

                        case 2:
                            cartonBingo[i, j] = random.Next(20, 29);
                            break;

                        case 3:
                            cartonBingo[i, j] = random.Next(30, 39);
                            break;

                        case 4:
                            cartonBingo[i, j] = random.Next(40, 49);
                            break;

                        case 5:
                            cartonBingo[i, j] = random.Next(50, 59);
                            break;

                        case 6:
                            cartonBingo[i, j] = random.Next(60, 69);
                            break;

                        case 7:
                            cartonBingo[i, j] = random.Next(70, 79);
                            break;

                        case 8:
                            cartonBingo[i, j] = random.Next(80, 89);
                            break;

                    }



                }
            }


            //Muestra de valores
            for (int i = 0; i < fila; i++)
            {

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                for (int j = 0; j < columna; j++)
                {
                    Console.Write("  |  ");
                    Console.Write(cartonBingo[i, j]);
                    Console.Write(" ");
                }
            }

            Console.ReadLine();



        }
    }
}
