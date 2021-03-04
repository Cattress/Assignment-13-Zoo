using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Animal
    {
        protected string Name;
        protected string Species;
        protected int Age;
        protected int LegNum;

        public string GetName()
        {
            return Name;
        }

        public string GetSpecies()
        {
            return Species;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetLegNum()
        {
            return LegNum;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
