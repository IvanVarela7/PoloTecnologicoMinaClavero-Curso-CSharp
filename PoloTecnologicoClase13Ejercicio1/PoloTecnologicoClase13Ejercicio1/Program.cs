//Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

//BilletesDe10
//BilletesDe20
//BilletesDe50
//BilletesDe100
//BilletesDe200
//BilletesDe500
//BilletesDe1000

//Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

//Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
//Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloTecnologicoClase13Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Billetera 1
            var miBilletera = new Billetera();

            miBilletera.BilletesDe10 = 10;
            miBilletera.BilletesDe20 = 5;
            miBilletera.BilletesDe50 = 2;
            miBilletera.BilletesDe100 = 1;
            miBilletera.BilletesDe200 = 1;
            miBilletera.BilletesDe500 = 1;
            miBilletera.BilletesDe1000 = 1;

            miBilletera.Total();

            //Billetera2

            var miBilletera2 = new Billetera();



            Console.ReadLine();

        }
    }
}



