using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Properties
{
    internal class autoimplemented
    {
        class StudentGradeCalculator
        {
            public string Name { get; set; }
            public int RollNo { get; set; }

            //private fields as we dont want anyone to access the Marks
            private int Marks;

            public int marks
            {
                get{
                    return Marks;
                }
                set
                {
                    if(value >=0 && value <=100)
                    {
                        Marks = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input : Marks must be between 0-100");
                    }
                }
            }
            public string Grade
            {
                get
                {
                    if (Marks >= 90)
                        return "A";
                    else if (Marks >= 75)
                        return "B";
                    else if (Marks >= 60)
                        return "C";
                    else if (Marks >= 40)
                        return "D";
                    else 
                        return "E";
                }
            }
        }
    }
}
