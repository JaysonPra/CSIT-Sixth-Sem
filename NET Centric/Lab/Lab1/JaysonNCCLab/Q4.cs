using System;

namespace JaysonNCCLab
{
    class Q4Employee
    {
        int id;
        string name;
        char gender;

        public Q4Employee(int id, string name, char gender)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
        }

        public object? this[int index]
        {
            get
            {
                if (index == 0) return this.id;
                else if (index == 1) return this.name;
                else if (index == 2) return this.gender;
                return null;
            }
            set
            {
                if (index == 0 && value is int intVal) this.id = intVal;
                else if (index == 1 && value is string strVal) this.name = strVal;
                else if (index == 2 && value is char charVal) this.gender = charVal;
            }
        }

        public object? this[string name]
        {
            get
            {
                if (name == "id") return this.id;
                else if (name == "name") return this.name;
                else if (name == "gender") return this.gender;
                return null;
            }
            set
            {
                if (name == "id" && value is int intVal) this.id = intVal;
                else if (name == "name" && value is string strVal) this.name = strVal;
                else if (name == "gender" && value is char charVal) this.gender = charVal;
            }
        }
    }

    class Q4
    {
        static void Main(string[] args)
        {
            Q4Employee emp = new Q4Employee(101, "Julen", 'M');

            Console.WriteLine("Int Index 1: " + emp[1]);
            emp[1] = "Jayson";
            Console.WriteLine("Int Index 1 (updated): " + emp[1]);

            Console.WriteLine("String Index 'gender': " + emp["gender"]);
            emp["gender"] = 'F';
            Console.WriteLine("String Index 'gender' (updated): " + emp["gender"]);

            Console.WriteLine("\nLab No: 4");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}