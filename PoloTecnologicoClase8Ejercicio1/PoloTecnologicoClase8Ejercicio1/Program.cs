// Ejercicio

// Crear un programa que cumpla con los siguientes pasos

// 1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
// 2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
// 3) Declarar un vector de tipo double llamado promedios
// 4) Recorrer la matriz para su carga con elementos de tipo int
// 5) Recorrer la matriz para mostrar cada valor de la matriz
// 6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
// 7) Mostrar los promedios recorriendo el vector promedios

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloTecnologicoClase8Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumaNumerosColumna = 0;


            Console.WriteLine("Ingrese cantidad de columnas");
            int columna = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de filas");
            int fila = int.Parse(Console.ReadLine());

            int[,] numeros = new int[fila, columna];

            double[] promedio = new double[columna];


            //Cargamos datos de la matriz
            for (int i = 0; i < columna; i++)
            {

                Console.WriteLine();
                Console.WriteLine("Numeros de la columna N°: " + i);


                for (int j = 0; j < fila; j++)
                {
                    Console.WriteLine("Cargue los numeros de la fila N°: " + j);
                    numeros[i, j] = int.Parse(Console.ReadLine());



                }
            }

            ////Mostramos datos de la matriz
            for (int i = 0; i < columna; i++)
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                //Console.WriteLine("valor de la columna: " + i);

                for (int j = 0; j < fila; j++)
                {
                    Console.Write("valor de la matriz en: " + "[" + i + "] " + "[" + j + "] = ");
                    Console.WriteLine(numeros[i, j]);
                }
            }
            Console.WriteLine("----");




            Console.ReadKey();

        }

    }
}
