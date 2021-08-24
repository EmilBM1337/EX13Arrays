using System;

namespace EX13Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[5];
            ages[0] = 25;
            ages[1] = 28;
            ages[2] = 15;
            ages[3] = 35;
            ages[4] = 14;

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
        }
    }
}
