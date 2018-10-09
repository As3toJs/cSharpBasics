using System;

namespace SecondWeek
{
    public class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public void MakeANoise()
        {
            Console.WriteLine($"{Name} can make sound like {Sound}");
        }


    }
}
