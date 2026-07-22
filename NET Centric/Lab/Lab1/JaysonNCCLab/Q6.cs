using System;

namespace JaysonNCCLab
{
    class Q6Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Base show method for overriding");
        }

        public void Display()
        {
            Console.WriteLine("Base display method for hiding");
        }
    }

    class Q6Child : Q6Parent
    {
        public override void Show()
        {
            Console.WriteLine("Overridden show method");
        }

        public new void Display()
        {
            Console.WriteLine("Hidden display method");
        }
    }

    class Q6
    {
        static void Main(string[] args)
        {
            Q6Parent obj1 = new Q6Child();
            obj1.Show();

            obj1.Display();

            Q6Child obj2 = new Q6Child();
            obj2.Display();

            Console.WriteLine("\nLab No: 6");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}