using System;

namespace JaysonNCCLab
{
    class Q3
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[3];

            jaggedArray[0][0] = 10;
            jaggedArray[0][1] = 20;

            jaggedArray[1][0] = 30;
            jaggedArray[1][1] = 40;
            jaggedArray[1][2] = 50;
            jaggedArray[1][3] = 60;

            jaggedArray[2][0] = 70;
            jaggedArray[2][1] = 80;
            jaggedArray[2][2] = 90;

            Console.WriteLine("Question 3 Output:\n");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nLab No: 3");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}