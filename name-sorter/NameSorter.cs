using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace name_sorter
{
    public class NameSorter
    {

        static void Main(string[] args)
        {
            // Read the names from the text file and store in local variable.
            string[] names = File.ReadAllLines(args[0]);

            // Call the QuickSort() function on the names array from beginning to end.
            QuickSort(names, 0, names.Length - 1);

            PrintToConsole(names);

            // Save the new sorted array of names to an external text file.
            System.IO.File.WriteAllLines("./sorted-names-list.txt", names);

            Console.ReadLine();
        }


        /// <summary>
        /// Quicksort Algorithm which sorts an array of strings into alphabetical order.
        /// </summary>
        /// <param name="a">the pivot point or middle value of the segment</param>
        /// <param name="start">the first element of the segment</param>
        /// <param name="end">the last element in the segment</param>
        public static void QuickSort(string[] a, int start, int end)
        {
            int i = start;
            int j = end;
            string pivotPoint = a[(start + end) / 2];

            // While the starting value is less than the end value
            while (i <= j)
            {
                while (a[i].CompareTo(pivotPoint) < 0)
                {
                    i++;
                }

                while (a[j].CompareTo(pivotPoint) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap the two values
                    string temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                    i++;
                    j--;
                }
            }

            // Recursive calls for divided segments
            if (start < j)
            {
                QuickSort(a, start, j);
            }

            if (i < end)
            {
                QuickSort(a, i, end);
            }
        }


        /// <summary>
        /// Prints a string array to the console.
        /// </summary>
        /// <param name="nameArray">A string array containing the names to be printed</param>
        public static void PrintToConsole(string[] nameArray)
        {
            foreach (string name in nameArray)
            {
                Console.WriteLine(name);
            }
        }

    }
}
