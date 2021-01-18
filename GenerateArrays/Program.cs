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

            // Criação da lista
            Node head = new Node(1);
            LinkedListExerc linkedList = new LinkedListExerc(head);
            Console.Write(linkedList.GetLinkedList());
            Console.WriteLine();
            //resultado: 1 ->

            //Adicionando o segundo nó ao final da lista
            Node secondNode = new Node(2);
            linkedList.AddNode(secondNode);
            Console.Write(linkedList.GetLinkedList());
            Console.WriteLine();
            //resultado: 1 -> 2 ->

            //Adicionando o quarto nó ao final da lista
            Node fourthNode = new Node(4);
            linkedList.AddNode(fourthNode);
            Console.Write(linkedList.GetLinkedList());
            Console.WriteLine();
            //resultado: 1 -> 2 -> 4 ->

            Node thirdNode = new Node(3);
            linkedList.AddNodeOnIndex(thirdNode, 2);
            Console.Write(linkedList.GetLinkedList());
            Console.WriteLine();
            //resultado: 1 -> 2 -> 3 -> 4 ->

            Node changeHeadNode = new Node(0);
            linkedList.AddNodeOnIndex(changeHeadNode, 0);
            Console.Write(linkedList.GetLinkedList());
            Console.WriteLine();
            //resultado: 0 -> 1 -> 2 -> 3 -> 4 ->


            Node changeTailNode = new Node(5);
            linkedList.AddNodeOnIndex(changeTailNode, 5);
            Console.Write(linkedList.GetLinkedList());
            Console.WriteLine();
            //resultado: 0 -> 1 -> 2 -> 3 -> 4 -> 5 ->

            Console.ReadLine();

        }
    }
}
