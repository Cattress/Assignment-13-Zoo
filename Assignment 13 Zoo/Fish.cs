using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Fish : Animal
    {
        public Fish(string Name, string Species, int Age, int LegNum)
        {
            this.Name = name;
            this.Species = species;
            this.Age = age;

        }

        public void swim()
        {
            Console.WriteLine("I can swim");
        }

        public override void Speak()
        {
            Console.WriteLine("bork");
        }
    }
}
