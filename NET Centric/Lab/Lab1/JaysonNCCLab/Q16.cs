using System;

namespace JaysonNCCLab
{
    class SampleAttribute : Attribute
    {
        public string Title { get; }
        public SampleAttribute(string title) => Title = title;
    }

    [Sample("Lab 16 Demo")]
    class Q16
    {
        [Obsolete("This method is outdated.")]
        static void LegacyFeature() => Console.WriteLine("Running legacy feature.");

        static void Main()
        {
            #pragma warning disable CS0618 // dont copy this
            LegacyFeature();
            #pragma warning restore CS0618 // dont copy this

            object[] attrs = typeof(Q16).GetCustomAttributes(typeof(SampleAttribute), false);
            SampleAttribute attr = (SampleAttribute)attrs[0];
            Console.WriteLine("Custom Attribute Title: " + attr.Title);

            Console.WriteLine("\nLab No: 16");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}