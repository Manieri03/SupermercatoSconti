using System;

namespace SupermercatoSconti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci l'importo che hai speso:  ");
            double spesa = double.Parse(Console.ReadLine());
            if (spesa > 100)
            {
                double sconto = (spesa / 100) * 20;
                double spesascont = spesa - sconto;
                Console.WriteLine($"Hai diritto allo sconto del 20%, il totale della spesa è quindi {spesascont} euro");

            }
            else Console.WriteLine($"Mi dispiace non hai diritto allo sconto, Il totale della spesa rimane {spesa} euro");
            Console.ReadLine();

        }
    }
}
