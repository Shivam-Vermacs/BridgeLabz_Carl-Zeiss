
// text editor maintains action history as a singly linked list:

//i/o:
//Action1 → Action2 → Action3 → Action4 → Action5
//Due to a bug, the last K actions must be removed.

//Task:

//Delete the last K nodes from the linked list
//Single traversal only

//Constraints:

//- No length calculation
//- No extra data structures
//- Only one pass

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Reviewa
{
    class Node
    {
        public string data;
        public Node? next;

        public Node(string data)
        {
            this.data = data;
            next = null;
        }
    }

    internal class Question2
    {
        public static Node DeleteLastK(Node head, int k)
        {
            
            if (head == null || k <= 0)
            {
                return head;
            }

            Node dummy = new Node("");
            dummy.next = head;

            Node slow = dummy;
            Node fast = dummy;

            for (int i = 0; i < k; i++)
            {
                if (fast.next == null)
                {
                    return head;
                }
                fast = fast.next;
            }

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = null;

            return dummy.next;
        }

        public static void printList(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data);
                if (current.next != null)
                    Console.Write("-");

                current = current.next; 
            }
            Console.WriteLine("-Null");
            Console.WriteLine(); 
        }

        public static Node createList(string[] actions)
        {
            if (actions.Length == 0)
                return null;

            Node head = new Node(actions[0]);
            Node current = head;

            for (int i = 1; i < actions.Length; i++)
            {
                current.next = new Node(actions[i]);
                current = current.next;
            }

            return head;
        }

        public static void Main(string[] args)
        {
            string[] actions = { "Action1", "Action2", "Action3", "Action4", "Action5" };
            Node head = createList(actions);

            Console.WriteLine("Original List:");
            printList(head);

            int k = 2;
            Console.WriteLine($"Deleting last {k} nodes");

            head = DeleteLastK(head, k);

            Console.WriteLine("After Deletion:");
            printList(head);


            Console.WriteLine("\n" + new string('=', 50));
        }
    }
}