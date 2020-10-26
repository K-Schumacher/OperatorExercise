using System;
using System.IO;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine($"{a}*{b} is {product}");
            Console.WriteLine($"{a}+{b} is {sum}");
            Console.WriteLine($"{a}-{b} is {difference}");
            Console.WriteLine("Press enter to continue.");

            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Enter radius.");

            double pi = 3.14159;
            double r = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(pi, r);

            Console.Clear();

            Console.WriteLine($"The area of your cirlce is {area} square feet.");
        }

        public static double AreaOfCircle(double pi, double r)
        {
            return pi * (r * r);
        }


    }
}
