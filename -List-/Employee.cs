using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _List_
{
    public class Employee : IComparable<Employee>
    {
        public Employee(int ıd, string name, string surname)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int CompareTo(Employee? other)
        {
            if (this.Id < other.Id)
            {
                return -1;
            }
            else if (this.Id == other.Id)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string? ToString()
        {
            return $"{Id} {Name} {Surname}";
        }
    }
}
