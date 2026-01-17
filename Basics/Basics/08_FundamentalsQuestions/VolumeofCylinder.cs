using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._08_FundamentalsQuestions
{
    internal class VolumeofCylinder
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the cylinder:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the cylinder:");
            double height = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;

            Console.WriteLine("Volume of the cylinder = " + volume);
        }
    }
}
