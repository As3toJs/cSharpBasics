using System;
namespace AnimalInheritance
{
    public class Dog : Mammals
    {
        public Dog()
        {
            Name = "Dog";
            Legs = 4;
        }
        public string Sound2 { get; set; }
        public new void MakeANoise()
        {
            Console.WriteLine($"{Name} can makes {Sound} and {Sound2}");
        }
    }
}
