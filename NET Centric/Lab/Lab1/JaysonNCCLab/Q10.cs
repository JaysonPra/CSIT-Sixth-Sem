using System;
using System.Collections;
using System.Collections.Generic;

namespace JaysonNCCLab
{
    class Q10
    {
        static void Main(string[] args)
        {
            ArrayList nonGenericList = new ArrayList();
            nonGenericList.Add("Apple");
            nonGenericList.Add(100);
            nonGenericList.Add(true);

            Console.WriteLine("Non-Generic Collection (ArrayList):");
            foreach (var item in nonGenericList)
            {
                Console.WriteLine(item);
            }

            List<string> genericList = new List<string>();
            genericList.Add("Banana");
            genericList.Add("Cherry");
            genericList.Add("Date");

            Console.WriteLine("\nGeneric Collection (List<string>):");
            foreach (string item in genericList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLab No: 10");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}