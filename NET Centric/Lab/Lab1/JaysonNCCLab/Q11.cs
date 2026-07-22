using System;

namespace JaysonNCCLab
{
    class Calculator<T>
    {
        private T value;

        public Calculator(T value)
        {
            this.value = value;
        }

        public void PrintResult<U>(U operationName, T result)
        {
            Console.WriteLine("Initial Value: " + value);
            Console.WriteLine(operationName + " Result: " + result);
        }
    }

    class Q11
    {
        static void Main(string[] args)
        {
            Calculator<int> intCalc = new Calculator<int>(10);
            intCalc.PrintResult("Addition", 10 + 20);

            Console.WriteLine();

            Calculator<double> doubleCalc = new Calculator<double>(5.5);
            doubleCalc.PrintResult("Multiplication", 5.5 * 2.0);

            Console.WriteLine("\nLab No: 11");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}