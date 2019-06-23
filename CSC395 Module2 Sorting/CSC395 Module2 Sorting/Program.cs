using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module2_Sorting
{
    class Program
    {
        // O(n^2) running time of the method.
        static void Main(string[] args)
        {
            // Read user input.
            string path = @"input.txt";

            // Read the entries from input.txt (one line per entry) and store them into an array.
            // Each copy call bubbleReverseSort, selectionReverseSort, mergeReverseSort, quickReverseSort. 
            string[] myArr = Utility.ReadFromFile(path);
            string[] myArr1 = Utility.ReadFromFile(path);
            string[] myArr2 = Utility.ReadFromFile(path);
            string[] myArr3 = Utility.ReadFromFile(path);
            string[] myArr4 = Utility.ReadFromFile(path);

            // Each algorthim's execution time is measured and displayed.
            // var watch* = System.Diagnostics.Stopwatch.StartNew();
            // watch*.Stop();
            // var elapsedMs1 = watch*.ElapsedMilliseconds;

            // Sort user input.
            // BubbleReverseSort performed 108812539 comparisons.
            // BubbleReverseSort: Running time: 97599 milliseconds.
            // O(n^2)
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            Utility.BubbleReverseSort(myArr1);
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedMilliseconds;
            Console.WriteLine($"BubbleReverseSort: Running time: {elapsedMs1} milliseconds.");

            // SelectionReverseSort performed 177671 comparisons.
            // SelectionReverseSort: Running time: 61752 milliseconds.
            // O(n^2)
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Utility.SelectionReverseSort(myArr2);
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedMilliseconds;
            Console.WriteLine($"SelectionReverseSort: Running time: {elapsedMs2} milliseconds.");

            // MergeReverseSort performed 273179 comparisons.
            // MergeReverseSort: Running time: 151 milliseconds.
            // O(n log n)
            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            Utility.MergeReverseSort(myArr3);
            watch3.Stop();
            var elapsedMs3 = watch3.ElapsedMilliseconds;
            Console.WriteLine($"MergeReverseSort: Running time: {elapsedMs3} milliseconds.");

            // QuickReverseSort performed 161375 comparisons.
            // QuickReverseSort: Running time: 181 milliseconds.
            // O(n log n)
            var watch4 = System.Diagnostics.Stopwatch.StartNew();
            Utility.QuickReverseSort(myArr4);
            watch4.Stop();
            var elapsedMs4 = watch4.ElapsedMilliseconds;
            Console.WriteLine($"QuickReverseSort: Running time: {elapsedMs4} milliseconds.");

            // Display user input values before sorting.
            Console.WriteLine("\nThe array values BEFORE sorting: ");
            Utility.Print(myArr);

            // Display the user input values after sorting.
            Console.WriteLine("\nThe array values AFTER sorting: "); 
            Utility.Print(myArr1, myArr2, myArr3, myArr4);
        }
    }
}
