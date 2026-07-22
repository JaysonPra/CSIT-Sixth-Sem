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
        // c) Using base to call the base class constructor
        public Child() : base()
        {
        }

        public void ShowDemo()
        {
            // a) Using base to access base class fields
            Console.WriteLine("Accessing Field: " + base.message);

            // b) Using base to call base class methods
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