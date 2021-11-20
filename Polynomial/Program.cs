using System;

namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = {8, -4, 5, 2};
            int[] p2 = new int[p1.Length];
            
            Console.Write(" Enter a nember: ");
            string inVal = Console.ReadLine();

            int number;
            while (!int.TryParse(inVal, out number))
            {
                Console.WriteLine(" Invalid number \"{0\" entered. Please re-enter a number.", inVal);
                break;
            }
            
            Console.WriteLine("Original array:");
            
            for (int i = 0; i < p1.Length; i++)
            {
                Console.Write(" {0}",p1[i]);
                p2[i] = p1[i] * number;
            }
            
            Console.Write("\n\n");
            Console.WriteLine("Modified array:");

            foreach (var literalValue in p2)
            {
                Console.Write(" {0}", literalValue);
            }
            
            Console.WriteLine();
        }
    }
}
