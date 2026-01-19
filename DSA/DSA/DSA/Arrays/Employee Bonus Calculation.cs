using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Employee_Bonus_Calculation
    {
        public static void Main(string[] args)
        {
            double[] salaries = new double[10];
            int[] yearsOfService = new int[10];
            for(int i = 0; i < 10; i++)
            {
                double Salary;
                int YearsService;
                while (true) // Salary Validation
                {
                    

                    Console.WriteLine("Enter the Current Salary");
                    try
                    {
                         Salary = Convert.ToInt32(Console.ReadLine());
                        if(Salary <0 )
                        {
                            Console.WriteLine("Invalid Salary Input : Re-enter the Salary");
                            continue;
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input. Please enter a valid number");
                    }
                }
                salaries[i] = Salary;

                while(true)
                {
                    Console.WriteLine("Enter the Years Of Service");
                    try
                    {
                        YearsService = Convert.ToInt32(Console.ReadLine());
                        if (YearsService < 0)
                        {
                            Console.WriteLine("Invalid Years of Service Input : Re-enter the Years of Service Again");
                            continue;
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input . Please enter a valid number");
                    }
                    
                }
                yearsOfService[i] = YearsService;
            }

            double totalOldSalary = 0;
            double bonusPayout = 0;
            double totalNewSalary = 0;

            for(int i=0;i<10;i++)
            {
                double bonusPercent = 0;
                double bonusAmount = 0;
                double newSalary = 0;
                if (yearsOfService[i]>5)
                {
                    bonusPercent = 0.05;
                }
                else
                {
                    bonusPercent = 0.02;
                }
                bonusAmount= salaries[i] * bonusPercent;
                newSalary = salaries[i] + bonusAmount;


            }

        }
    }
}
