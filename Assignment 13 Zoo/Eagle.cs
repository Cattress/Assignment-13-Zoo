using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Eagle : Animal
    {
        public Eagle(string Name, string Species, int Age, int LegNum)
        {
            this.Name = EagleName;
            this.Species = EagleSpecies;
            this.Age = EagleAge;

        }

        public void fly()
        {
            Console.WriteLine("I can fly");
        }

        public override void Speak()
        {
            Console.WriteLine("aa");
        }
    }
}
