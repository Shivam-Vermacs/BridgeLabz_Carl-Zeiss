using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._08_FundamentalsQuestions
{
    internal class CelsiustoFahrenheit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Temperature in Celsius");
            double temperatureInCelsius = Convert.ToDouble(Console.ReadLine());

            double temperatureInFahrenheit = (temperatureInCelsius  )*(9.0 / 5.0) + 32;

            Console.WriteLine("Temperature in Fahrenheit = " + temperatureInFahrenheit);

        }
    }
}
