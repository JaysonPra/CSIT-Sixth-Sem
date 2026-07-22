using System;
using System.Collections.Generic;
using System.Linq;

namespace JaysonNCCLab
{
    class Q14
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine("Square of 5 using Lambda: " + square(5));

            List<int> numbers = new List<int> { 10, 25, 30, 45, 50, 65 };

            var filteredNumbers = numbers.Where(n => n > 30).Select(n => n * 2);

            Console.WriteLine("\nNumbers > 30 doubled using LINQ with Lambda:");
            foreach (var num in filteredNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nLab No: 14");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}