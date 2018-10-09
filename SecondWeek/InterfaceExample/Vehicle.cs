using System;
namespace InterfaceExample
{
    public class Vehicle : IDrivable
    {
        public Vehicle(string brand, int speed, int wheels){
            Brand = brand;
            Speed = speed;
            Wheels = wheels;
        }

        public int Speed { get; set; }
        public int Wheels { get; set; }
        public string Brand { get; set; }

        public void Move()
        {
            Console.WriteLine("the {0} moves with {1}Kmph", Brand, Speed);
        }

        public void Stop()
        {
            Console.WriteLine("The {0} stopped", Brand);
            Speed = 0;
        }
    }
}
