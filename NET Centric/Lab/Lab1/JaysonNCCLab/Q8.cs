using System;

namespace JaysonNCCLab
{
    enum Role
    {
        Admin,
        Developer,
        Tester
    }

    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    partial class User
    {
        public string Name { get; set; }
        public Role UserRole { get; set; }

        public User(string name, Role role)
        {
            Name = name;
            UserRole = role;
        }
    }

    partial class User
    {
        public void DisplayDetails()
        {
            Console.WriteLine("User: " + Name + ", Role: " + UserRole);
        }
    }

    class Q8
    {
        static void Main(string[] args)
        {
            Point location = new Point(10, 20);
            Console.WriteLine("Coordinates: X = " + location.X + ", Y = " + location.Y);

            User user = new User("Jayson", Role.Developer);
            user.DisplayDetails();

            Console.WriteLine("\nLab No: 8");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}