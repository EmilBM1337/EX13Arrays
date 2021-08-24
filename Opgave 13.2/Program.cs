using System;

namespace Opgave_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Anders", "Ulrik", "Nicolai", "Nikolaj", "Kasper", "Daniel" };
            
            names[5] = "Kong Daniel";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
