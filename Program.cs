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

            // Task 3 - Compute and display the sum
            // T3.2 - In the Main method, display the sum of the generated
            // numbers.
            int array_sum = ComputeSum(random_num_array);
            Console.WriteLine("\n\nSum: " + array_sum);

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

        // T3.1 - Write a method named ComputeSum that takes an array
        // of integers as input and returns their sum.
        static int ComputeSum(int[] generated_array)
        {
            int sum = 0;
            foreach (int num in generated_array)
            {
                sum += num;
            }
            
            return sum;
        }
    }
}
