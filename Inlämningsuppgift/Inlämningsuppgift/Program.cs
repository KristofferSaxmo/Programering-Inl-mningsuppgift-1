using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Random = new Random();
            int RandomNumber = Random.Next(1, 100);
            int tal = 0;
            int försök = 0;
            Console.WriteLine("Ange ett heltal: ");
            do
            {
                försök++;
                tal = Convert.ToInt32(Console.ReadLine());
                if (tal == RandomNumber)
                    Console.WriteLine("Du har gissat rätt! Det tog dig " + försök + " försök");
                else if (tal > RandomNumber)
                    Console.WriteLine("Du har gissat för högt, förösök igen.");
                else if (tal < RandomNumber)
                    Console.WriteLine("Du har gissat för lågt. försök igen.");
            } while (tal != RandomNumber);

        }
    }
}
