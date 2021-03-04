using System;

namespace Assignment_13_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[3];
            zoo[0] = new Lion("bobby", "lion", 4, 2);
            zoo[1] = new Fish("bobbert", "fish two", 14, 21);
            zoo[2] = new Eagle("bob", "eagle", 1, 0);
            int i;
            for(i = 0; i <zoo.Length; i++)
            {
                zoo[i].Speak;

            }
            
        }
    }
}
