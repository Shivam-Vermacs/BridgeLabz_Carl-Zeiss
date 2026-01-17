using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._09_C_ProgrammingFundamentals
{
    internal class VolumeOfEarth
    {
        public static void Main(string[] args)
        {
            double radiusKm = 6378;
            double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

            double radiusMiles = radiusKm / 1.6; // Approximate conversion
            double volumeMiles3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

            Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm3} and cubic miles is {volumeMiles3}");
        }
    }
}
