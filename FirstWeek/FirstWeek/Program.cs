using System;
using System.Collections.Generic;

namespace FirstWeek
{
    class MainClass
    {
        public static void DisplaySeries(List<int> series){
            Console.WriteLine("Fabonacci Series ::");
            foreach (var num in series)
                Console.WriteLine(num);
        }

        public static void Main(string[] args)
        {
            //var number = new Fabonacci().Number(8);

            var series = new List<int> { };

            Console.WriteLine("Enter your choice :");
            Console.WriteLine("1: Add two numbers");
            Console.WriteLine("2: nth number of Fabonacci series");
            Console.WriteLine("3: Fabonacci series unitl the nth number");
            Console.WriteLine("4: Fabonacci series based on user input");

            var input = Convert.ToInt32(Console.ReadLine());

            switch(input) {
                case 1:
                    Addition.Add(43, 56);
                    break;
                case 2:
                    series = new Fabonacci().Number(8);
                    Console.WriteLine("{0}th number of series :{1}", 8, series[7]);
                    break;
                case 3:
                    series = new Fabonacci().Number(8);
                    DisplaySeries(series);
                    break;
                case 4:
                    Console.WriteLine("Enter the number to get Fabonacci Series :");
                    var number = Convert.ToInt32(Console.ReadLine());
                    series = new Fabonacci().Number(number);
                    DisplaySeries(series);
                    break;
                default:
                    break;

            }
        }
    }
}

