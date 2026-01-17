using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._08_FundamentalsQuestions
{
    internal class AreaofCircle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;

            Console.WriteLine("Area of the circle = " + area);
        }
    }
}
