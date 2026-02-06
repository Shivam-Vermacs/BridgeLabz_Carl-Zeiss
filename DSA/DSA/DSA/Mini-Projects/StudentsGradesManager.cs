using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Mini_Projects
{
    internal class StudentsGradesManager
    {
        public class GradeManager
        {
            public class Node
            {
                public string name;
                public double grade;
                public Node? next;
                
                public Node(string name, double grade)
                {
                    this.name = name;
                    this.grade = grade;
                    next = null;
                }
            }
            Node head = null;
            public void AddStudent(string name, double grade)
            {
                //if(name==null && grade == null)
                //{
                //    Console.WriteLine("");
                //}
                Node newNode = new Node(name, grade);
                if(head == null)
                {
                    head = newNode;
                    return;
                }
                Node? temp = head;

                while (temp.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            public void DisplayInfo()
            {
                if (head == null)
                {
                    return;
                }
                Node? temp = head;
                double sum = 0, i = 0;
                while (temp != null)
                {
                    Console.WriteLine($"Student Name: {temp.name}, Grade:{temp.grade}");
                    sum += temp.grade;
                    temp = temp.next;
                    i++;
                }
                double avg = sum / i;
                Console.WriteLine($"Average Grade of the whole class {avg:F2} ");
            }
            
            
        }
    }
}
