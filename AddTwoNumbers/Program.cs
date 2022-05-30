using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numarr = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };

            ListNode l0 = ArrayToNodeList(numarr);



            //ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3))); = 342 
            //ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4))); = 465 => 807

            //ListNode l1 = new ListNode(9);
            //ListNode l2 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))))));


            //ListNode l1 = ArrayToNodeList(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
            //ListNode l2 = ArrayToNodeList(new int[] { 5,6,4 });

            ListNode l1 = ArrayToNodeList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            ListNode l2 = ArrayToNodeList(new int[] { 9, 9, 9, 9 });


            ListNode listres = AddTwoNumbers2(l1, l2);

            //long listresult = GetNumber(AddTwoNumbers(l1, l2));

            //Console.WriteLine(listresult);

            Console.ReadLine();

        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            long num1 = GetNumber(l1);
            long num2 = GetNumber(l2);

            long sumValue = num1 + num2;

            if (sumValue == 0)
            {
                return new ListNode(0);
            }
            else
            {
                return GetListNode(sumValue);
            }
        }

        public static long GetNumber(ListNode node)
        {
            if (node.next == null)
            {
                return node.val;
            }
            else
            {
                var express = node.val + 10 * GetNumber(node.next);
                Console.WriteLine(express);
                return express;
            }
        }

        public static ListNode GetListNode(long sumValue)
        {
            if (sumValue == 0)
            {
                return null;
            }
            else
            {
                return new ListNode((int)(sumValue % 10), GetListNode(sumValue / 10));
            }
        }

        public static ListNode ArrayToNodeList(int[] num)
        {
            int i = 0;

            ListNode retlistNode = null;

            if (num.Length == 1)
            {
                retlistNode = new ListNode(num[i]);
            }
            else
            {
                int[] destArray = new int[num.Length - 1];

                Array.Copy(num, 1, destArray, 0, num.Length - 1);

                retlistNode = new ListNode(num[i], ArrayToNodeList(destArray));
            }

            return retlistNode;
        }

        ///100% cases

        public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            return GetSum(l1, l2);
        }

        public static ListNode GetSum(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 != null)
            {
                if (l2.val > 9)
                {
                    if (l2.next == null)
                    {
                        l2.next = new ListNode(0);
                    }

                    l2.next.val += 1;

                    return new ListNode(l2.val % 10, GetSum(null, l2.next));
                }
                else
                {
                    return new ListNode(l2.val, GetSum(null, l2.next));
                }
            }
            else if (l1 != null && l2 == null)
            {
                if (l1.val > 9)
                {
                    if (l1.next == null)
                    {
                        l1.next = new ListNode(0);
                    }

                    l1.next.val += 1;

                    return new ListNode(l1.val % 10, GetSum(l1.next, null));
                }
                else
                {
                    return new ListNode(l1.val, GetSum(l1.next, null));
                }
            }
            else if (l1 == null && l2 == null)
            {
                return null;
            }
            else
            {
                if ((l1.val + l2.val) > 9)
                {
                    if (l1.next != null)
                    {
                        l1.next.val += 1;
                    }
                    else
                    {
                        if (l2.next == null)
                        {
                            l2.next = new ListNode(0);
                        }

                        l2.next.val += 1;
                    }



                    return new ListNode((l1.val + l2.val) % 10, GetSum(l1.next, l2.next));
                }
                else
                {
                    return new ListNode(l1.val + l2.val, GetSum(l1.next, l2.next));
                }
            }
        }

    }

    /**
    * Definition for singly-linked list.
    **/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
