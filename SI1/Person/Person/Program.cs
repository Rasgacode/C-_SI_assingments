using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "nORBI";
            person.BirthDate = new DateTime(1993, 6, 21);
            Console.WriteLine(person); 
        }
    }
}
