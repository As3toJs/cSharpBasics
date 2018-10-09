using System;

namespace InterfaceExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var vehicle = new Vehicle("vehic", 50, 4);

            //if(vehicle is IDrivable) {

            vehicle.Move();
            vehicle.Stop();

            /*}else{
                Console.WriteLine("Vehicle {0} is not Drivable", vehicle.Brand);
            }*/
        }
    }
}
