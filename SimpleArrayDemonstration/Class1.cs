using System;

namespace SimpleArrayDemonstration
{
    public class Class1
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

int[] arr = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; // pre-sorted
getIndex = Array.BinarySearch(arr, 30); // same as IndexOf. Binary search must be pre-sorted before search
Console.WriteLine("the value of " + 30 + " is found at " + getIndex);
getIndex = Array.BinarySearch(arr, 80);
Console.WriteLine("the value of " + 80 + " is found at " + getIndex);
Array.Clear(arr, 2, 3);
foreach (int i in arr)
{
    Console.WriteLine(i);
}
    }
}
