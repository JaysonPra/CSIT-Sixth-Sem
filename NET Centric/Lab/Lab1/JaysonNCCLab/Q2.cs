using System;

namespace JaysonNCCLab
{
    class Employee
    {
        public string Name { get; set; }

        public int Id { get; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 2 Output:\n");

            Employee emp = new Employee(101, "Jayson");

            Console.WriteLine("Original Name (Auto): " + emp.Name);
            emp.Name = "Julen"; 
            Console.WriteLine("Updated Name (Auto): " + emp.Name);

            Console.WriteLine("Employee ID (Read-Only): " + emp.Id);

            Console.WriteLine("\nLab No: 2");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}