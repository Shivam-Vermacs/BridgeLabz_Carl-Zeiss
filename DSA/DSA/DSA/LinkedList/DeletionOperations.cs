//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA.LinkedList
//{
//    internal class DeletionOperations
//    {
//        public class ListNode
//        {
//            public int data;
//            public ListNode next;

//            public ListNode(int data)
//            {
//                this.data = data;
//                next = null;
//            }
//        }
//        public class Solution
//        {
//            public ListNode DeleteHead(ListNode head)
//            {
//                if (head == null)
//                {
//                    return null;
//                }
//                head = head.next;
//                return head;
//            }
//            public ListNode DeleteTail(ListNode head)
//            {  
//                if(head == null)
//                {
//                    return null;
//                }
//                if (head.next == null) return null;
//                ListNode temp = head;
//                while(temp.next.next != null)
//                {
//                    temp = temp.next;
//                }
//                temp.next = null;
                
//                return head;
//            }
//            public ListNode DeleteNodewithKthValue(ListNode head,int k)
//            {
//                if(head==null)
//                {
//                    return null;
//                }
//                if (head.data == k) return head.next;
//                ListNode temp = head;

//                while (temp != null )
//                {
//                    if(temp.next.data == k)
//                    {
//                        temp.next = temp.next.next;
//                        return head;
//                    }
//                    temp = temp.next;
//                }
//                return head;
//            }
//            public ListNode DeleteKthNode(ListNode head,int k)
//            {
//                if( head == null)
//                {
//                    return null;
//                }
//                if (k == 1)
//                {
//                    return head.next;
//                }
//                ListNode temp = head;
//                int count = 0;
//                    while (temp.next!=null && count < k)
//                    {
//                        temp = temp.next;
//                        count++;
//                    }
//                    if(temp!=null && temp.next != null)
//                    {
//                        temp.next = temp.next.next;
//                        return head;
//                    }
//                    return head;
//                }
//            }
//        }

//    }
//}
