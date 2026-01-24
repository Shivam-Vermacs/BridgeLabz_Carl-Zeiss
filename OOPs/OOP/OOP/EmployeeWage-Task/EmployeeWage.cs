using System;

namespace OOP.EmployeeWage_Task
{
    internal class EmployeeWage
    {
        private int wagePerHour;
        private int maxWorkingDays;
        private int maxWorkingHours;

        public EmployeeWage(int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        public void ComputeWage()
        {
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;
            int totalWage = 0;

            Random random = new Random();

            while (totalWorkingDays < maxWorkingDays && totalWorkingHours < maxWorkingHours)
            {
                totalWorkingDays++;

                int empCheck = random.Next(0, 3);
                int empHours = 0;

                if (empCheck == 1)
                    empHours = 4;
                else if (empCheck == 2)
                    empHours = 8;

                if (totalWorkingHours + empHours > maxWorkingHours)
                    empHours = maxWorkingHours - totalWorkingHours;

                totalWorkingHours += empHours;
                int dailyWage = empHours * wagePerHour;
                totalWage += dailyWage;

                Console.WriteLine("Day " + totalWorkingDays + " | Hours: " + empHours + " | Wage: " + dailyWage);
            }

            Console.WriteLine();
            Console.WriteLine("Total Working Days: " + totalWorkingDays);
            Console.WriteLine("Total Working Hours: " + totalWorkingHours);
            Console.WriteLine("Total Employee Wage: " + totalWage);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter wage per hour: ");
            int wagePerHour = int.Parse(Console.ReadLine());

            Console.Write("Enter max working days: ");
            int maxWorkingDays = int.Parse(Console.ReadLine());

            Console.Write("Enter max working hours: ");
            int maxWorkingHours = int.Parse(Console.ReadLine());

            EmployeeWage employeeWage =
                new EmployeeWage(wagePerHour, maxWorkingDays, maxWorkingHours);

            employeeWage.ComputeWage();
        }
    }
}
