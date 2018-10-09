using System;

namespace SecondWeek
{
    public class Dog : ICanMakeNoise
    {
        public Dog(string sound){
            Sound = sound;
        }
        public string Sound { get; set; }
        public string Name { get; set; } = "Dog";

        public void MakeANoise()
        {
            Console.WriteLine($"{Name} can make a noice {Sound}");
        }
    }
}
