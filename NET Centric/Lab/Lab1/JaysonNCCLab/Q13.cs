using System;
using System.Collections.Generic;
using System.Linq;

namespace JaysonNCCLab
{
    class Q13
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 12, 3, 20, 8, 15, 1 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              orderby num
                              select num;

            Console.WriteLine("Even numbers (Query Syntax):");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            var greaterThanTen = numbers.Where(n => n > 10).OrderByDescending(n => n);

            Console.WriteLine("\nNumbers > 10 (Method Syntax):");
            foreach (var num in greaterThanTen)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nLab No: 13");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}