using System;

namespace JaysonNCCLab
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }

    interface IRunner
    {
        void Run();
    }

    interface ISwimmer
    {
        void Swim();
    }

    class Dog : Animal, IRunner, ISwimmer
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }

        public void Run()
        {
            Console.WriteLine("Dog runs on land.");
        }

        public void Swim()
        {
            Console.WriteLine("Dog swims in water.");
        }
    }

    class Q7
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.MakeSound();
            dog.Run();
            dog.Swim();

            Console.WriteLine("\nLab No: 7");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}