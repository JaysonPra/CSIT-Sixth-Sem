namespace Practice;

class Employee
{
    int id;
    string name;
    char gender;
    double salary;

    public Employee(int id, string name, char gender, double salary)
    {
        this.id = id;
        this.name = name;
        this.gender = gender;
        this.salary = salary;
    }

    // Indexer
    public object this[int index]
    {
        get
        {
            if (index == 0)
            {
                return this.id;
            }
            else if (index == 1)
            {
                return this.name;
            }
            else if (index == 2)
            {
                return this.gender;
            }
            else if (index == 3)
            {
                return this.salary;
            }
            else
            {
                return null;
            }
        }

        set
        {
            if (index == 0)
            {
                this.id = (int)value;
            }
            else if (index == 1)
            {
                this.name = (string)value;
            }
            else if (index == 2)
            {
                this.gender = (char)value;
            }
            else if (index == 3)
            {
                this.salary = (double)value;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }
    }
}

internal class IndexerDemo
{
    static void Main()
    {
        Employee emp = new(101, "Julen", 'M', 15000.00);
        Console.WriteLine(emp[2]);
    }
}