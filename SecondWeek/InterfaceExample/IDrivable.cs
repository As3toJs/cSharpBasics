using System;
namespace InterfaceExample
{
    public interface IDrivable
    {
        int Speed { get; set; }
        int Wheels { get; set; }

        void Move();
        void Stop();
    }
}
