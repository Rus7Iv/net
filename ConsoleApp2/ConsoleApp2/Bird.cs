using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Bird : Animal, InterfaceAge
    {
        public string Vid;
        public Bird(string name) : base(name)
        {
            _name = name;
            Name = "Mediv";
            Vid = "Орел";
            Weight = 66;
            Age = 16;
        }

        public void Liv()
        {
            Age = 2000;
        }

        public virtual void War()
        {

            Console.WriteLine($"{Vid} {Name} весит {Weight} килограммов и ему {Age} лет");
            Console.WriteLine($"{Vid} {Name} очень мудрый и быстрый");
        }
    }
}
