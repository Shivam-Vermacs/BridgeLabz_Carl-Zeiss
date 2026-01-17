using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._09_C_ProgrammingFundamentals
{
    internal class ProfitLoss
    {
        public static void Main(string[] args)
        {
            int costPrice = 129;
            int sellingPrice = 191;
            int profit = sellingPrice - costPrice;
            double profitPercentage = (double)profit / costPrice * 100;
            Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\nThe Profit is INR {profit} and the Profit Percentage is {profitPercentage}");
        }
    }
}
