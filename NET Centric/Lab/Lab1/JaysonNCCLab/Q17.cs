using System;
using System.Threading.Tasks;

namespace JaysonNCCLab
{
    class Q17
    {
        static async Task FetchDataAsync()
        {
            Console.WriteLine("Fetching data...");
            await Task.Delay(2000);
            Console.WriteLine("Data retrieved successfully.");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Process started.");
            
            await FetchDataAsync();

            Console.WriteLine("Process completed.");

            Console.WriteLine("\nLab No: 17");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}