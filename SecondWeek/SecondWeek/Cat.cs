using System;

namespace SecondWeek
{
    public class Cat : ICanMakeNoise
    {
        public Cat(){
        
        }
        public string Sound { get; set; }
        public string Name { get; set; } = "Cat";

        public void MakeANoise()
        {
            Console.WriteLine($"{Name} can make a noice {Sound}");
        }
    }
}
