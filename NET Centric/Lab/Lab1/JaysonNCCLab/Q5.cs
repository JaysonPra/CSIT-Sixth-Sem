using System;

namespace JaysonNCCLab
{
    class Parent
    {
        public string message = "Parent Field Value";

        public Parent()
        {
            Console.WriteLine("Base Constructor Called");
        }

        public void Display()
        {
            Console.WriteLine("Base Method Called");
        }
    }

    class Child : Parent
    {
        public Child() : base()
        {
        }

        public void ShowDemo()
        {
            Console.WriteLine("Accessing Field: " + base.message);

            base.Display();
        }
    }

    class Q5
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.ShowDemo();

            Console.WriteLine("\nLab No: 5");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}