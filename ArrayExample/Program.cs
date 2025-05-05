using System;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            string[] b = new string[2] { "Shoaib", "Ali" };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            foreach (string i in b)
            {
                Console.WriteLine(i);
            }
        }
    }
}
