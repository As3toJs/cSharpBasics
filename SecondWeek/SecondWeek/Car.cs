using System;

namespace SecondWeek
{
    public class Car: ICanMakeNoise    {
        public Car()
        {
        }

        public string Sound { get; set; }
        public string Name { get; set; } = "Car";

        public void MakeANoise()
        {
            Console.WriteLine($"{Name} can make a noice {Sound}");
        }
    }
}
