using System;
namespace InlämningsUpgift_3._4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange låtens längd i minuter och sekunder: ");
            Console.Write("Minuter: ");
            int minuter = int.Parse(Console.ReadLine());
            Console.Write("Sekunder: ");
            int sekunder = int.Parse(Console.ReadLine());

            int totSekunder = minuter * 60 + sekunder;
            int minSekunder = 165;
            int maxSekunder = 260;

            if (totSekunder >= minSekunder && totSekunder <= maxSekunder)
            {
                Console.WriteLine("Låten får spelas på radiostationen.");
            }
            else
            {
                Console.WriteLine("Låten får INTE spelas på radiostationen.");
            }
        }
    }
}