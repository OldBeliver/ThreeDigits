using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 1;
            int maxValue = 27;
            int min3DigitsNumber = 100;
            int max3DigitsNumber = 999;

            Random rand = new Random();
            int number = rand.Next(minValue, maxValue + 1);
            
            int result = 0;
            int i = 1;
            int quantity = 0;
            string line = "";

            while (result <= max3DigitsNumber)
            {
                result = i * number;

                if (result >= min3DigitsNumber && result <= max3DigitsNumber)
                {
                    quantity++;
                    line += result + " ";
                }
                i++;
            }
            Console.WriteLine($"число {number}\nчисловой ряд: {line}\nколичество чисел: {quantity}");
        }
    }
}
