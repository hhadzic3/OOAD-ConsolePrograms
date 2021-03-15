using System;

namespace FirstApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 6 cijelih brojeva: ");
            string ulaz = Console.ReadLine();
            
            // razdvajanje unosa na pojedinačne brojeve
            string[] pojedinacniUlazi = ulaz.Split(",");

            // pretvaranje string brojeva u cijele brojeve (int)
            int[] brojevi = new int[6];
            
            for (int i = 0; i < 6; i++)
                brojevi[i] = Int32.Parse(pojedinacniUlazi[i]);


            for (int i = 0; i < 6; i++)
                Console.WriteLine(brojevi[i]);

        }
    }
}
