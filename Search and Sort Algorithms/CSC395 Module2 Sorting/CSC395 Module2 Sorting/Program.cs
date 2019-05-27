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
            string[] myArr1 = Utility.ReadFromFile(path);
            string[] myArr2 = Utility.ReadFromFile(path);
            string[] myArr3 = Utility.ReadFromFile(path);
            string[] myArr4 = Utility.ReadFromFile(path);

            //TODO For each of these measure the execution time
            //(how long it took to run the reverse sorting) and display this time.

            // Display user input values before sorting.
            Console.WriteLine("\n\nThe array values BEFORE sorting: ");
            Utility.Print(myArr1);

            // Sort user input.
            //Utility.BubbleReverseSort(myArr1);//sort the array
            //Utility.SelectionReverseSort(myArr2);
            //Utility.InsertionSort(myArr);
            //Utility.MergeReverseSort(myArr3);
            //Utility.QuickReverseSort(myArr4);

            int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            Utility.quickSort(arr);


            // Display the user input values after sorting.
            //Console.WriteLine("\n\nThe array values AFTER sorting: "); 
            //Utility.Print(myArr1, myArr2, myArr3, myArr4);
        }
    }
}
