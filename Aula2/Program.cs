﻿using System;

namespace Aula2
{
    public class Node
    {
        public int element;
        public Node next;
        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    class LinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void addLast(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
                head = newest;
            else
                tail.next = newest;
            tail = newest;
            size = size + 1;
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size = size + 1;
        }

        public void addAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size = size + 1;
        }

        public void insertsorted(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
                head = newest;
            else
            {
                Node p = head;
                Node q = head;
                while (p != null && p.element < e)
                {
                    q = p;
                    p = p.next;
                }
                if (p == head)
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size = size + 1;
        }

        public int removeFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            else
            {
                int e = head.element;
                head = head.next;
                size = size - 1;
                if (isEmpty())
                    tail = null;
                return e;
            }
        }

        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            Node p = head;
            int i = 1;
            while (i < size - 1)
            {
                p = p.next;
                i = i + 1;
            }
            tail = p;
            p = p.next;
            int e = p.element;
            tail.next = null;
            size = size - 1;
            return e;
        }

        public int removeAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            int e = p.next.element;
            p.next = p.next.next;
            size = size - 1;
            return e;
        }

        public int search(int key)
        {
            Node p = head;
            int index = 0;
            while (p != null)
            {
                if (p.element == key)
                    return index;
                p = p.next;
                index = index + 1;
            }
            return -1;
        }

        public void display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            char a = 'a';
            char b = 'u';

            int intA = (int)a;
            int intB = (int)b;

            bool bothAreLetter = false;
            bool bothAreSameCase = true;

            if (intA >= 65  && intA <= 90 || intA >= 97 && intA <= 122)
            {
                if (intB >= 65 && intB <= 90 || intB >= 97 && intB <= 122)
                {
                    bothAreLetter = true;
                }
            }

            if (65 >= intA && intA <= 90)
            {
                if (intB < 65 || intB > 90)
                {
                    bothAreSameCase = false;
                }
            }
            else if (97 >= intA && intA <= 122)
            {
                if (intB < 97 || intB > 122)
                {
                    bothAreSameCase = false;
                }
            }

            if (bothAreLetter == false)
                Console.WriteLine("-1");

            if (bothAreSameCase == true)
                Console.WriteLine("1");

            Console.WriteLine("0");


            LinkedList l = new LinkedList();
            l.insertsorted(3);
            l.insertsorted(4);
            l.insertsorted(7);
            l.insertsorted(1);
            l.insertsorted(2);
            l.insertsorted(9);
            l.display();
            Console.WriteLine("Size: " + l.length());

            Console.ReadKey();
        }
    }
}