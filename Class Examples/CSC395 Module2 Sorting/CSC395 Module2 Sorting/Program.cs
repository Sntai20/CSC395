using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module2_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 21, 107, 6, 50, 100, 3};

            //display the array values before sorting
            Console.WriteLine("The array values BEFORE sorting: ");
            foreach(int num in myArr)
                Console.Write(num+" ");
            Console.WriteLine();

            //Utility.BubbleSortImproved(myArr);//sort the array
            //Utility.SelectionSort(myArr);
            //Utility.InsertionSort(myArr);
            Utility.MergeSort(myArr);

            //display the array values after sorting
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The array values AFTER sorting: ");
            foreach (int num in myArr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}
