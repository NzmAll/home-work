using System;

namespace lab_day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal total = 0;
            bool isNegative = false;

            Console.Write("1-ci ededi daxil edin: ");
            decimal number1 = decimal.Parse(Console.ReadLine()!);

            Console.Write("2-ci ededi daxil edin: ");
            decimal number2 = decimal.Parse(Console.ReadLine()!);

            if ((number1 < 0 && number2 > 0) || (number1 > 0 && number2 < 0))
            {
                isNegative = true;
            }

            if (number1 < 0)
            {
                number1 = -number1;
            }

            if (number2 < 0)
            {
                number2 = -number2;
            }

            for (int i = 0; i < number2; i++)
            {
                total += number1;
            }

            if (isNegative)
            {
                total = -total;
            }

            Console.WriteLine("Netice: " + total);
        }
    }
}
