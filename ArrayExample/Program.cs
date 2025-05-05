using System;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6] { 10, 20, 30, 40, 50, 30 };
            string[] b = new string[2] { "Shoaib", "Ali" };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            foreach (string i in b)
            {
                Console.WriteLine(i);
            }
            // a is array reference cariable, 30 is the value to be searched out, and 3 is the index from where value to be searched out
            int getIndex = Array.IndexOf(a, 30, 3);// search start from index 3. index 3 is included
            Console.WriteLine("the value of " + 30 + " is found at " + getIndex);
        }
    }
}
