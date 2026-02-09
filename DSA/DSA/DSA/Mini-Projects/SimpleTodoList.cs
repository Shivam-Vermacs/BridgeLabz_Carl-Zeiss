//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using System.Threading.Tasks;

//namespace DSA.Mini_Projects
//{
//    internal class SimpleTodoList
//    {
//        public class Node
//        {
//            public string Task;
//            public Node? next;

//            public Node(string task)
//            {
//                Task = task;
//                next = null;

//            }

//        }
//        Node head = null;
//        public void AddTask(string task)
//        {
//            Node newNode = new Node(task);
//            if (head == null)
//            {
//                head = newNode;
//                return;
//            }
//            Node? temp = head;
//            while (temp.next != null)
//            {
//                temp = temp.next;
//            }
//            temp.next = newNode;

//        }
//        public void DisplayTasks()
//        {
//            Node temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine(temp.Task);
//                temp = temp.next;
//            }

//        }
//        public void DeleteTask(int position)
//        {
//            if (position == 1)
//            {
//                head = head.next;
//                return;
//            }
//            Node? temp = head;
//            int count = 0;
//            while (temp != null && count < position)
//            {
//                temp = temp.next;
//                count++;
//            }
//            if (temp != null && temp.next != null)
//            {
//                temp.next = temp.next.next;
//            }

//        }



//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
           
//            SimpleTodoList myList = new SimpleTodoList();

            
//            myList.AddTask("Buy Milk");
//            myList.AddTask("Walk the Dog");
//            myList.AddTask("Learn Linked Lists");
//            myList.AddTask("Go to Gym");

           
//            Console.WriteLine("Current List:");
//            myList.DisplayTasks();

          
//            Console.WriteLine("Deleting task at position 3...");
//            myList.DeleteTask(3);

            
//            Console.WriteLine("List after deletion:");
//            myList.DisplayTasks();

            
//            Console.ReadLine();
//        }
//    }

//}