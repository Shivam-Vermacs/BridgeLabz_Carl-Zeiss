using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._09_C_ProgrammingFundamentals
{
    internal class CourseFeeDiscount
    {
        public static void Main(string[] args)
        {
            double fee = 125000;
            double discountPercent = 10;
            double discountAmount = (fee * discountPercent) / 100;
            double finalFee = fee - discountAmount;
            Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {finalFee}");
        }
    }
}
