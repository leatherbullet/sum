using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 0;
            int maxValue = 101;
            int firstDivisor = 3;
            int secondDivisor = 5;
            int randomNumber = random.Next(minValue,maxValue);
            int sum = 0;

            Console.WriteLine("Случайное число: " + randomNumber);

            for (int i = 0; i <= randomNumber; i++)
            {
                if (i % firstDivisor == 0 || i % secondDivisor == 0)
                {
                    sum += i;

                    Console.WriteLine($"Числа кратные {firstDivisor} и {secondDivisor}:{i}\nСумма чисел:{sum}");
                }
            }
        }
    }
}
