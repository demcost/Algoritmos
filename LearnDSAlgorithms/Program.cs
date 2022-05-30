using System;

namespace LearnDSAlgorithms
{
    class Recursion
    {
        public void calculatehead(int n)
        {
            if(n > 0)
            {
                //head recursion
                calculatehead(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        public void calculatetail(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                //tail recursion
                calculatetail(n - 1);
            }
        }


        public void calculatetree(int n)
        {
            if (n > 0)
            {
                calculatetree(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                calculatetree(n - 1);
            }
        }


        public void calculateiterative(int n)
        {
            while(n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1; 
            }
        }

        public void calculaterecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculaterecursive(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            //r.calculateiterative(4);
            //r.calculaterecursive(4);
            r.calculatetree(3);
            Console.ReadKey();
        }

        //
    }
}
