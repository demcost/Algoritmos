using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxProjects
{
    public class Node
    {
        private Node() { }

        public Node(int head) {
            val = head;
        }

        public int val { get; set; }
        public Node next { get; set; }
    }


    public class LinkedListExerc
    {
        public Node Head { get; set; }
        public LinkedListExerc(Node head)
        {
            Head = head;
        }

        public void AddNode(Node node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                if(Head.next == null)
                {
                    Head.next = node;
                }
                else
                {
                    Node currentlyNode = Head.next;

                    while(currentlyNode.next != null)
                    {
                        currentlyNode = currentlyNode.next;
                    }

                    currentlyNode.next = node;
                }
            }
        }

        public string GetLinkedList()
        {
            string sReturn = string.Empty;

            Node currentlyNode = Head;

            while (currentlyNode.next != null)
            {

                sReturn += currentlyNode.val + " -> ";

                currentlyNode = currentlyNode.next;
            }

            return sReturn;
        } 
    }
}
