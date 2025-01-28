using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 2 - Implement a random number generator
            // T2.2 - Modify the Main method to call
            // GenerateRandomIntegers and display each number in the console.
            int[] random_num_array = GenerateRandomIntegers(100, 1, 1000);
            foreach (int num in random_num_array)
            {
                Console.WriteLine(num);
            }

        }

        // T2.1 - Implement a method called GenerateRandomInteger
        // that returns an array of 100 random integers between 1 and 1000.
        static int[] GenerateRandomIntegers(int length, int min, int max)
        {
            int[] new_random_array = new int[length];

            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                new_random_array[i] = rnd.Next(min, max);
            }

            return new_random_array;
        }
    }
}
