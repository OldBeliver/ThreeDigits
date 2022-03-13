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
            int minDigitsNumber = 100;
            int maxDigitsNumber = 999;

            Random rand = new Random();
            int number = rand.Next(minValue, maxValue + 1);
            
            int result = 0;
            int index = 1;
            int quantity = 0;
            string line = "";

            while (result <= maxDigitsNumber)
            {
                result = index * number;

                if (result >= minDigitsNumber && result <= maxDigitsNumber)
                {
                    quantity++;
                    line += result + " ";
                }
                index++;
            }
            Console.WriteLine($"число {number}\nчисловой ряд: {line}\nколичество чисел: {quantity}");
        }
    }
}
