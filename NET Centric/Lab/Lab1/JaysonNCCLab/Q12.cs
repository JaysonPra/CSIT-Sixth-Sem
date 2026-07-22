using System;
using System.IO;

namespace JaysonNCCLab
{
    class Q12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text to write to file: ");
            string userInput = Console.ReadLine() ?? "";

            string filePath = "output.txt";
            File.WriteAllText(filePath, userInput);

            Console.WriteLine("Data written to " + filePath + " successfully.");

            Console.WriteLine("\nLab No: 12");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}