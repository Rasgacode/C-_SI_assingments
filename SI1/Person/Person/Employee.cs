using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }

        public Room room { get; }

        public Employee(Room room)
        {
            this.room = room;
        }

        public override string ToString()
        {
            return "Person: " + Name + " " + BirthDate 
                + " " + Salary + " " + Profession + " " + room.NumberOfRoom;
        }
    }
}
