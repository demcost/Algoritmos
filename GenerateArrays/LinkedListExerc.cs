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

        /// <summary>
        /// Adiciona um nó ao final da lista
        /// </summary>
        /// <param name="node"></param>
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

        /// <summary>
        /// Adiciona na posição solicitada
        /// </summary>
        /// <param name="node"></param>
        public void AddNodeOnIndex(Node node, int index)
        {
            //Se o indice é maior que o número de itens da lista, não permitir a inclusão
            //Lembrando que index is zero based
            
            int listLength = GetLength();

            if (index > listLength - 1)
            {
                AddNode(node);
                return;
            }
            

            //caso contrário varrer a lista até o indice informado
            int count = 0;
            Node currentlyNode = Head;

            while (currentlyNode != null)
            {
                int prevIndex = index - 1;

                if (prevIndex < 0)
                {
                    node.next = currentlyNode;
                    Head = node;
                    return;
                }

                if (count == prevIndex)
                {
                    node.next = currentlyNode.next;
                    currentlyNode.next = node;
                    return;
                }

                currentlyNode = currentlyNode.next;
                count++;
            }
        }

        /// <summary>
        /// Retorna a lista completa
        /// </summary>
        /// <returns></returns>
        public string GetLinkedList()
        {
            string sReturn = string.Empty;

            Node currentlyNode = Head;

            while (currentlyNode != null)
            {
                sReturn += currentlyNode.val + " -> ";

                currentlyNode = currentlyNode.next;
            }

            return sReturn;
        }
        
        /// <summary>
        /// Obtém o tamanho da lista
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            Node currentlyNode = Head;

            int listLength = 0;

            while (currentlyNode != null)
            {
                listLength++;
                currentlyNode = currentlyNode.next;
            }

            return listLength;
        }
    }
}
