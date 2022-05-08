using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            double square = Math.Sqrt(N);
            double power = Math.Pow(N, 2);
            Console.WriteLine("Squarad number: " + square);
            Console.WriteLine("Number to the power of two: " + power);
            Console.ReadKey();
        }
    }
}
