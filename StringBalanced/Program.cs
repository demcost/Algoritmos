using System;
using System.Collections;

namespace StringBalanced
{
    class Program
    {
        public static char[,] Tokens = { { '{', '}' },
                                         { '[',']'  },
                                         { '(', ')' } };

        public static Boolean isBalanced (String expression)
        {
            Stack stack = new Stack();
            
            foreach(char character in expression.ToCharArray())
            {
                if(isOpenTerm(character))
                {
                    stack.Push(character);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char top = (char)stack.Pop();

                    if(!Matches(top, character))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private static bool isOpenTerm(char character)
        {
            for(int i = 0; i <= Tokens.GetLength(0) - 1; i++)
            {
                if(Tokens[i,0] == character)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Matches(char openTerm, char closeTerm)
        {
            for (int i = 0; i <= Tokens.GetLength(0) - 1; i++)
            {
                if (Tokens[i, 0] == openTerm)
                {
                    if (Tokens[i, 1] == closeTerm)
                        return true;
                }
            }

            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(isBalanced("{{{{[[}}]]")); //false

            Console.WriteLine(isBalanced("{{}}()[]")); //true

            Console.WriteLine(isBalanced("()[]")); //true

            Console.WriteLine(isBalanced("{[]")); //false

            Console.Read();
        }
    }
}
