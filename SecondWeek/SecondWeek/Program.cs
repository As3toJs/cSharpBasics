namespace SecondWeek
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Sound = "Meaou";
            cat.MakeANoise();

            var dog = new Dog("woof-woof");
            dog.MakeANoise();

            var car = new Car();
            car.Name = "BMW";
            car.Sound = "grrrr";
            car.MakeANoise();
        }
    }
}

