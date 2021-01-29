using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessageAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "oedc";
            int[] A = new int[] { 3, 0, 2, 1 };

            //StringBuilder retorno = new StringBuilder();
            MyStringBuilder retorno = new MyStringBuilder();

            for (int i = 0; i < A.Length; i++)
            {
                int index = A[i]; // obtendo o indice
                retorno.Append(S[index]);
            }

            Console.WriteLine(retorno.ToString());
            Console.ReadLine();
        }
    }

    public class MyStringBuilder
    {
        private int index = 0;

        private char[] sArray;

        public MyStringBuilder(int capacity)
        {
            sArray = new char[capacity];
        }

        public MyStringBuilder():this(1)
        {
        
        }

        public void Append(char c)
        {
            if(index == sArray.Length) //atingiu a capacidade máxima do array
            {
                char[] sauxArray = new char[2 * sArray.Length];
                for(int i = 0; i < index; i++)
                {
                    sauxArray[i] = sArray[i];
                }
                sArray = sauxArray;
            }

            sArray[index++] = c;
        }

        public override string ToString()
        {
            return new String(sArray,0,index);
        }

    }
}
