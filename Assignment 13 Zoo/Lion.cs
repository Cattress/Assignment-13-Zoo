using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Lion : Animal
    { 
        
        public Lion(string Name, string Species, int Age, int LegNum)
        {
            this.Name = LionName;
            this.Species = LionSpecies;
            this.Age = LionAge;

        }

        public void run()
        {
            Console.WriteLine("I can run");
        }

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
