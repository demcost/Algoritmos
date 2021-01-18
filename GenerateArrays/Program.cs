using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();

            //int[] randomArray  = { };

            //for(int i = 1; i <= 100; i++ )
            //{
            //   int number = random.Next(65536) - 32768;

            //   randomArray.Append(number);
            //}


            //Console.WriteLine(randomArray);

            Node head = new Node(100);

            LinkedListExerc linkedList = new LinkedListExerc(head);

            Node secondNode = new Node(15);

            linkedList.AddNode(secondNode);

            Node thirdNode = new Node(20);

            linkedList.AddNode(thirdNode);

            Node fourthNode = new Node(20);

            linkedList.AddNode(fourthNode);

            Console.Write(linkedList.GetLinkedList());

            Console.ReadLine();

        }
    }
}
