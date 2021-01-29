using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(8)
            {
                left = new Node(2)
                {
                    left = new Node(8),
                    right = new Node(9)
                },
                right = new Node(6)
            };

            //int retorno = CountNode(root, int.MinValue);
            int retorno = CountNodeGreater(root, int.MinValue);

            Console.WriteLine(retorno);

            Console.ReadLine();
        }

        static int CountNode(Node root, int anterior)
        {
            int countResult = 0;

            if (root == null)
            {
                return countResult;
            }

            if(root.value > anterior)
            {
                countResult++;
            }

            countResult += CountNode(root.left, root.value);
            countResult += CountNode(root.right, root.value);

            return countResult;
            
        }

        static int CountNodeGreater(Node root, int maioranterior)
        {
            int countResult = 0;

            if (root == null)
            {
                return countResult;
            }

            if (root.value > maioranterior)
            {
                countResult++;
                maioranterior = root.value;
            }

            countResult += CountNodeGreater(root.left, maioranterior);
            countResult += CountNodeGreater(root.right, maioranterior);

            return countResult;

        }
    }


    public class Node 
    {
        public Node(int _value)
        {
            value = _value;
        }


        public Node left { get; set; }
        public int value { get; set; }
        public Node right { get; set; }
    }
}
