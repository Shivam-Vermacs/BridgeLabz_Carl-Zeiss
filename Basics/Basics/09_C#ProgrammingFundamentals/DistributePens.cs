using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._09_C_ProgrammingFundamentals
{
    internal class DistributePens
    {
        public static void Main(string[] args)
        {
            int totalPens = 14;
            int students = 3;
            int pensPerStudent = totalPens / students;
            int remainingPens = totalPens % students;
            Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}");
        }
    }
}
