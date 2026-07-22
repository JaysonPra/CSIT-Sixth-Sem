using System;

namespace JaysonNCCLab
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class Q15
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or older.");
            }
            Console.WriteLine("Access granted.");
        }

        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception Caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine();

            try
            {
                CheckAge(15);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }

            Console.WriteLine("\nLab No: 15");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}