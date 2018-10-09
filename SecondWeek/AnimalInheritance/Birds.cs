using System;
namespace AnimalInheritance
{
    public class Birds
    {
        public Birds()
        {
        }

        public string Name { get; set; }
        public string Sound { get; set; }
        public int Legs { get; set; } = 0;

        public void MakeANoise()
        {
            Console.WriteLine($"{Name} can make sound like {Sound}");
        }
        public void ICanReproduce()
        {
            Console.WriteLine($"{Name} can reproduce");
        }
        public void ICanFly()
        {
            Console.WriteLine($"{Name} can fay and has {Legs} legs");
        }
        public void ICanGiveEggs()
        {
            Console.WriteLine($"{Name} can give milks");
        }
    }
}
