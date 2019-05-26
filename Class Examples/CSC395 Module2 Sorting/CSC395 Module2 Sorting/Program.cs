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
            //int[] myArr = { 21, 107, 6, 50, 100, 3};
            //string[] myArr = { "bubble", "merge", "a", "quicksort" };

            //TODO 
            //In Main read the entries from file given below, input.txt
            //(one line per entry) and store them into an array. Make four copies 
            //of it.Then, on each copy call bubbleReverseSort, selectionReverseSort, 
            //mergeReverseSort, quickReverseSort. 
            string[] myArr = Utility.ReadFromFile(path);

            //TODO For each of these measure the execution time
            //(how long it took to run the reverse sorting) and display this time.

            // Display user input values before sorting.
            Console.WriteLine("\n\nThe array values BEFORE sorting: ");
            // To make the loop easier use var instead of int.
            foreach(var arrValue in myArr)
                Console.Write(arrValue+" ");
            Console.WriteLine();

            // Sort user input.
            //Utility.BubbleSortImproved(myArr);//sort the array
            Utility.BubbleReverseSort(myArr);//sort the array
            //Utility.SelectionSort(myArr);
            //Utility.SelectionReverseSort(myArr);
            //Utility.InsertionSort(myArr);
            //Utility.MergeSort(myArr);
            //Utility.MergeReverseSort();
            //Utility.QuickReverseSort(myArr);

            // Display the user input values after sorting.
            Console.WriteLine("\n\nThe array values AFTER sorting: ");
            // To make the loop easier use var instead of int.
            foreach (var arrValue in myArr)
                Console.Write(arrValue + " ");
            Console.WriteLine();
        }
    }
}
