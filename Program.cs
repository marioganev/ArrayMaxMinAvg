using System;

namespace ArrayMaxMinAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            
            double[] numbers = new double[n];
            double sum = 0;
            decimal average;


            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(numbers);

            //Calculates sum
            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];

            }

            average = ((decimal)sum / n);

            //Answers
            Console.Write("Min: ");
            Console.WriteLine(numbers[0]);

            Console.Write("Max: ");
            Console.WriteLine(numbers[n - 1]);

            Console.Write("Average: ");
            Console.WriteLine(Math.Round(average, 2));
        }
    }
}
    
