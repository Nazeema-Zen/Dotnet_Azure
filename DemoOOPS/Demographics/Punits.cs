// using System;

// namespace DemoOOP.Demographics
// {
//     class Program
//     {
//         static void Main()
//         {
//             Point p = new Point(10, 20);

//             Console.WriteLine($"X = {p.X}");
//             Console.WriteLine($"Y = {p.Y}");
//         }
//     }
// }

using System;

namespace DemoOOP.Demographics
{
    internal class Person
    {
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "Nazeema", 30);
            person.Display();
        }
    }
}