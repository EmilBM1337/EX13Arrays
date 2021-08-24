using System;

namespace Opgave_13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };

            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
