using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp2
{
    public class Fish : Animal
    {
        /// <summary>
        /// Class of Fish
        /// </summary>
        public string Color;
        public Fish(string name) : base(name)
        {
            _name = name;
            Name = "Karp";
            Weight = 16;
            Age = 6;
            Color = "Zerkalnyi";
        }
        public virtual void Fisher()
        {

            Console.WriteLine($"{Color} {Name} весит {Weight} килограммов и ему {Age} лет");
            Console.WriteLine($"{Color} {Name} очень вкусный и довольно редкий");
        }
        /// <summary>
        /// Transform Fish characteristics to string
        /// </summary>
        /// <returns>String like "Name:{Color} {Name}, age: {Age}, weight: {Weight}";"</returns>
        public override string ToString()
        {
            return $"Name:{Color} {Name}, age: {Age}, weight: {Weight}.";
        }


    }
}
