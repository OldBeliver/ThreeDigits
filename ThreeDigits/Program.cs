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
            
            int quantity = 0;
            string line = "";

            for (int i = 0; i < maxDigitsNumber; i+=number)
            {   
                if (i >= minDigitsNumber && i <= maxDigitsNumber)
                {
                    quantity++;
                    line += i + " ";
                }
            }            
            Console.WriteLine($"число {number}\nчисловой ряд: {line}\nколичество чисел: {quantity}");
        }
    }
}
