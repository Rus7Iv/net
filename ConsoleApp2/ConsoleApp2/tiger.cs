using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Tiger : Animal
    {
        public Tiger(string name):base(name)
        {
            _name = name;
            Name = "Tigril";
            Weight = 160;
            Age = 16; 
        }
        public override void Option()
        {
            Console.WriteLine($"{Name} весит {Weight} килограммов и ему {Age} лет");
            Console.WriteLine($"{Name} очень быстро бегает");
        }

      
        
    }
}
