using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citp180_week001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Problem 1:\n");
            Console.WriteLine("Hello World! My name is Randy Lee!\n");

            // Problem 2
            Console.WriteLine("Problem 2:\n");
            Console.WriteLine("ccccccccc\t  # # ");
            Console.WriteLine("cc\t\t#######");
            Console.WriteLine("cc\t\t  # #");
            Console.WriteLine("cc\t\t#######");
            Console.WriteLine("ccccccccc\t  # # \n");

            // Problem 8
            Console.WriteLine("Problem 8:\n");
            Console.WriteLine("   _O_   ");
            Console.WriteLine("    |    \t HANGMAN");
            Console.WriteLine("   <<    \n");

            // Problem 9
            Console.WriteLine("Problem 9:\n");

            // Square
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("*****");
                i++;
            }

            Console.WriteLine("\n");

            // Triangle
            Console.WriteLine("*\n**\n***\n****\n*****\n");

            // Diamond
            Console.WriteLine("  *  ");
            Console.WriteLine(" *** ");
            Console.WriteLine("*****");
            Console.WriteLine(" *** ");
            Console.WriteLine("  *  ");
            Console.WriteLine("\n");

            // Problem 10
            Console.WriteLine("Problem: 10\n");
            Console.WriteLine("RRRRR\tL");
            Console.WriteLine("R   R\tL");
            Console.WriteLine("RRRRR\tL");
            Console.WriteLine("R  R \tL");
            Console.WriteLine("R   R\tLLLLL\n");
        }
    }
}
