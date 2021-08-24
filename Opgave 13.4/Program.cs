using System;

namespace Opgave_13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] + 5;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
