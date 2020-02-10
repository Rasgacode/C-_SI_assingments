using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(new Room(12));
            employee.Name = "nORBI";
            employee.BirthDate = new DateTime(1993, 6, 21);
            employee.Profession = "Made";
            employee.Salary = 10000;

            Console.WriteLine(employee); 
        }
    }
}
