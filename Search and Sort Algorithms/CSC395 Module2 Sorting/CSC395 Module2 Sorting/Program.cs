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
        //TODO write the running time of the method.
        static void Main(string[] args)
        {
            // Read user input.
            string path = @"/Users/antonio/Library/Mobile Documents/com~apple~CloudDocs/Documents/Education and Training/SMU/CSC395/M2 Homework/input.txt";

            //TODO 
            //Read the entries from input.txt (one line per entry) and store them into an array.
            //Four array copies, each copy call bubbleReverseSort, selectionReverseSort, 
            //mergeReverseSort, quickReverseSort. 
            string[] myArr = Utility.ReadFromFile(path);
            string[] myArr1 = Utility.ReadFromFile(path);
            string[] myArr2 = Utility.ReadFromFile(path);
            string[] myArr3 = Utility.ReadFromFile(path);
            string[] myArr4 = Utility.ReadFromFile(path);

            //TODO For each of these measure the execution time
            //(how long it took to run the reverse sorting) and display this time.

            // Sort user input.
            //BubbleReverseSort performed 108812539 comparisons.
            //BubbleReverseSort: Running time: 97599 milliseconds.
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            Utility.BubbleReverseSort(myArr1);
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedMilliseconds;
            Console.WriteLine($"BubbleReverseSort: Running time: {elapsedMs1} milliseconds.");

            //SelectionReverseSort performed 20843 comparisons.
            //SelectionReverseSort: Running time: 64338 milliseconds.
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Utility.SelectionReverseSort(myArr2);
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedMilliseconds;
            Console.WriteLine($"SelectionReverseSort: Running time: {elapsedMs2} milliseconds.");

            //MergeReverseSort performed 273179 comparisons.
            //MergeReverseSort: Running time: 238 milliseconds.
            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            Utility.MergeReverseSort(myArr3);
            watch3.Stop();
            var elapsedMs3 = watch3.ElapsedMilliseconds;
            Console.WriteLine($"MergeReverseSort: Running time: {elapsedMs3} milliseconds.");

            //QuickReverseSort performed 335080 comparisons.
            //QuickReverseSort: Running time: 267 milliseconds.
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
