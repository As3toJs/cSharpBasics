using System;
using System.Collections.Generic;

namespace FirstWeek
{
    public class Fabonacci
    {
        public List<int> Number(int number)
        {
            var first = 0;
            var second = 1;
            var next = 0;

            var fabonacciNumbers = new List<int> {first, second};
           
            for (int i = 0; i < (number - 2); i++)
            {
                next = first + second;
                fabonacciNumbers.Add(next);
                first = second;
                second = next;
            }

             return fabonacciNumbers;
        }
    }
}
