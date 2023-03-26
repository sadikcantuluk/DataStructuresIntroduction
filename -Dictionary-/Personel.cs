using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Dictionary_
{
    public class Personel
    {
        public Personel(string name, string surname, decimal price)
        {
            Name = name;
            Surname = surname;
            Price = price;
        }

        public int SicilNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {Price}";
        }
    }
}
