// Escribe un programa que:

// 1) Pida 10 números al usuario.
// 2) Obtener la suma de todos los números ingresados.
// 3) Obtener cual es el mayor de todos los números.
// 4) Obtener cual es el menor de todos los números.
// 5) Obtener el promedio de todos los números.
// 6) Mostrar todos los números ingresados por pantalla.
// 7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

// Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
// Pueden adjuntarnos el archivo .cs, o el codigo como texto.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloTecnologicoClase7Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sumaNumeros = 0;
            int numeroMayor = 0;
            int numeroMenor = 0;
            int promedioNumeros = 0;

            int[] numero = new int[10];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Ingrese un numero entero");
                numero[i] = int.Parse(Console.ReadLine());

                sumaNumeros = sumaNumeros + numero[i];

                if (numero[i] > numeroMayor)
                {
                    numeroMayor = numero[i];
                }

                if (numero[i] < numeroMenor)
                {
                    numeroMenor = numero[i];
                }

                promedioNumeros = sumaNumeros / numero.Length;

            }

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Valor de la posicion " + i + " es: " + numero[i]);
            }


            Console.WriteLine("La suma de todos los numeros ingresados es: " + sumaNumeros);
            Console.WriteLine("El mayor de todos los numeros ingresados es: " + numeroMayor);
            Console.WriteLine("El menor de todos los numeros ingresados es: " + numeroMenor);
            Console.WriteLine("El promedio de todos los numeros ingresados es: " + promedioNumeros);



            Console.ReadLine();
        }
    }
}
