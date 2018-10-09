using System;

namespace AnimalInheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("----------- Mammals -----------\n");
            Cat cat = new Cat();
            cat.Legs = 4;
            cat.Name = "catter";
            cat.Sound = "meaou";
            cat.MakeANoise();

            Dog dog = new Dog();
            dog.Sound = "Bhau-Bhau";
            dog.Sound2 = "grrrr";
            dog.MakeANoise();
            dog.ICanMove();

            Console.Write("----------- Birds -----------\n");
            Pigeon pigeon = new Pigeon();
            pigeon.ICanGiveEggs();
            pigeon.ICanFly();
        }
    }
}

