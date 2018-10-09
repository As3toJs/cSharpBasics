using System;
namespace SecondWeek
{
    public interface ICanMakeNoise
    {
        string Sound { get; set; }
        void MakeANoise();
    }
}
