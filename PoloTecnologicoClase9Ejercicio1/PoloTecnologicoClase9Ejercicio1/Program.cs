// Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

// 1)      Pedir al usuario la longitud de un vector
// 2)      Crear el vector del tamaño ingresado.
// 3)      Llenar el mismo con datos aleatorios
// 4)      Mostrar el vector por pantalla
// 5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente.
//        En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.
//        Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
//        Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
// 6)      Mostrar el vector nuevamente.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloTecnologicoClase9Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamañoVector = 0;
            int aux;


            Console.WriteLine("Ingresar tamaño del vector");
            tamañoVector = int.Parse(Console.ReadLine());

            int[] miVector = new int[tamañoVector];

            Random numeroAleatorio = new Random();

            for (int i = 0; i < miVector.Length; i++)
            {
                miVector[i] = numeroAleatorio.Next(100);
            }

            //Mostrar datos del vector
            foreach (int i in miVector)
            {
                Console.WriteLine(i);
            }


            //invertir vector

            for (int i = 0; i < tamañoVector / 2; i++)
            {
                aux = miVector[i];
                miVector[i] = miVector[tamañoVector - 1 - i];
                miVector[tamañoVector - 1 - i] = aux;
            }

            Console.WriteLine();
            Console.WriteLine("Vector invertido");

            foreach (int i in miVector)
            {

                Console.WriteLine(i);
            }






            Console.ReadLine();
        }
    }
}

