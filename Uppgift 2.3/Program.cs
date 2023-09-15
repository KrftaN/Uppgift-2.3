using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du hyra bilen?");
            int antalDagar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur många kilometer ska du köra?");
            int antalKM = Convert.ToInt32(Console.ReadLine());
            int summa = (300 + antalKM + antalDagar * 500);

            Console.WriteLine(
                "Det kommer att kosta: "
                    + summa
                    + "kr för att hyra bilen i "
                    + antalDagar
                    + " dagar och köra "
                    + antalKM
                    + "KM."
            );
            Console.ReadKey();
        }
    }
}
