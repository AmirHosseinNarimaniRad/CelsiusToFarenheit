using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in Celsius :");
            double TempC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("in Farenheit : ");


            double TempF = CelsiusToFahrenheit(TempC);
            Console.WriteLine("In Fahrenheit : " + TempF);

            Console.ReadLine();
        }

        //Method for Calculating the Fahrenheit Value.
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        
    }
}
