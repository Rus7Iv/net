﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Tiger : Animal
    {
        /// <summary>
        /// Class of Tiger
        /// </summary>
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

        /// <summary>
        /// Transform Tiger characteristics to string
        /// </summary>
        /// <returns>String like "Name: {Name}, age: {Age}, weight: {Weight}.";"</returns>
        public override string ToString()
        {
            return $"Name: {Name}, age: {Age}, weight: {Weight}.";
        }

    }
}
