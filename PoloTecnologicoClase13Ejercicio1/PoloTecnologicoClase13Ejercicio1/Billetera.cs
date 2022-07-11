using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloTecnologicoClase13Ejercicio1
{
    public class Billetera
    {
        //Propiedades

        public int BilletesDe10;
        public int BilletesDe20;
        public int BilletesDe50;
        public int BilletesDe100;
        public int BilletesDe200;
        public int BilletesDe500;
        public int BilletesDe1000;


        public void Total()
        {
            int importeTotal;

            int importeBilleteDe10 = BilletesDe10 * 10;
            int importeBilleteDe20 = BilletesDe20 * 20;
            int importeBilleteDe50 = BilletesDe50 * 50;
            int importeBilleteDe100 = BilletesDe100 * 100;
            int importeBilleteDe200 = BilletesDe200 * 200;
            int importeBilleteDe500 = BilletesDe500 * 500;
            int importeBilleteDe1000 = BilletesDe1000 * 1000;

            importeTotal = importeBilleteDe10 + importeBilleteDe20 + importeBilleteDe50 + importeBilleteDe100 + importeBilleteDe200 + importeBilleteDe500 + importeBilleteDe1000;

            Console.WriteLine("El importe total de la billetera: $" + importeTotal);

        }
    }
}
