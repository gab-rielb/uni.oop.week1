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

            // Task 4 - Compute and display the histogram
            int[,] histogram = ComputeHistogram(random_num_array);
            DisplayHistogram(histogram, random_num_array);

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

        // T4.1 - Write a method called ComputeHistogram that
        // computes the frequency of each number and stores it in an array.
        static int[,] ComputeHistogram(int[] generated_array)
        {
            int unique_num_count = generated_array.Distinct().Count(); // Gets the amount of unique numbers in the array
            int[,] histogram = new int[unique_num_count, 1]; // Generates a 2D array for each unique number in the format (number, frequency)
            

            foreach (int num in generated_array)
            {
                int index = Array.IndexOf(generated_array.Distinct().ToArray(), num); // Finds the correct index to increment
                histogram[index, 0]++; // Increments the frequency
            }

            return histogram;
        }

        // T4.2 - Implement a method named DisplayHistogram to print
        // out the frequency of each number.
        static void DisplayHistogram(int[,] histogram, int[] generated_array)
        {
            Console.WriteLine("\n\nHistogram:");
            for (int i = 0; i < histogram.GetLength(0); i++)
            {
                Console.WriteLine($"Number: {generated_array.Distinct().ToArray()[i]}, Frequency: {histogram[i, 0]}");
            }
        }
    }
}
