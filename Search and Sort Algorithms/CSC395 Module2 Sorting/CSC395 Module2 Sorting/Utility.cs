using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module2_Sorting
{
    class Utility
    {
        // Merge sort algorithm sorts an array of strings in reverse.
        // A local variable count, type long, stores the number of comparisons 
        // performed and displays the value before exiting the method.
        public static void MergeReverseSort(string[] myArr3)
        {
            long count = 0;
            if (myArr3 != null)
            {
                // tmp is used as a temp buffer and passed to the helper.
                string[] tmp = new string[myArr3.Length]; 
                MergeReverseSortHelper(myArr3, 0, myArr3.Length - 1, tmp, ref count);
            }
            Console.WriteLine($"\nMergeReverseSort performed {count} comparisons.");
        }

        public static void MergeReverseSortHelper(string[] myArr3, int first, int last, string[] tmp, ref long count)
        {
            // Validate there are at least two elements.
            if (first < last)
            {
                // Divide the array in two recursively.
                int mid = (first + last) / 2;
                MergeReverseSortHelper(myArr3, first, mid, tmp, ref count);
                MergeReverseSortHelper(myArr3, mid + 1, last, tmp, ref count);
                Merge(myArr3, first, mid + 1, last, tmp, ref count);
            }
        }

        public static void Merge(string[] myArr3, int first, int mid, int last, string[] tmp, ref long count)
        {
            // tmp is passed in to be used as a temporary buffer.
            int i = first;
            int j = mid;
            int k = first;

            while (i<mid && j <=last )
            {
                // Compare myArr[i] to myArr[j] with currentculture rules and choose the larger.
                if (string.Compare(myArr3[i], myArr3[j], StringComparison.CurrentCulture) > 0)
                {
                    tmp[k] = myArr3[i];
                    k++;
                    i++;
                }
                else
                {
                    tmp[k] = myArr3[j];
                    j++;
                    k++;
                }
                count++;
            }

            // Put the remaining elements and only runs if there are elements left in the first half.
            while (i<mid) 
            {
                tmp[k] = myArr3[i];
                k++;
                i++;
            }

            while(j <= last)
            {
                tmp[k] = myArr3[j];
                j++;
                k++;
            }

            // Copy the tmp value back into the array.
            for (int p = first; p <= last; p++)
                myArr3[p] = tmp[p];
        }

        // Quick sort algorithm sorts an array of strings in reverse.
        // A local variable count, type long, stores the number of comparisons 
        // performed and displays the value before exiting the method.
        public static void QuickReverseSort(string[] myArr4)
        {
            long count = 0;
            if (myArr4 != null)
            {
                QuickReverseSortHelper(myArr4, 0, myArr4.Length - 1, ref count);
            }
            Console.WriteLine($"\nQuickReverseSort performed {count} comparisons.");
        }

        public static void QuickReverseSortHelper(string[] myArr4, int left, int right, ref long count)
        {
            // Validate the sorting stays within the array.
            if (left < right)
            {
                // Keep track of the partition index and recursively sort array.
                int partIdx = Partition(myArr4, left, right, ref count);
                QuickReverseSortHelper(myArr4, left, partIdx - 1, ref count);
                QuickReverseSortHelper(myArr4, partIdx + 1, right, ref count);
            }
        }

        static public int Partition(string[] myArr4, int left, int right, ref long count)
        {
            int lessIndex = (left - 1);
            string tmp;
            string tmp1;

            // Compares elements starting from the left to the end of the array.
            for (int j = left; j < right; j++)
            {
                // Compare myArr[j] to myArr[right] with currentculture rules.
                if (string.Compare(myArr4[j], myArr4[right], StringComparison.CurrentCulture) > 0)
                {
                    // Swap lessIndex with tmp.
                    lessIndex++;
                    tmp = myArr4[lessIndex];
                    myArr4[lessIndex] = myArr4[j];
                    myArr4[j] = tmp;
                    count++;
                }

            }

            // Swap lessIndex with right.
            tmp1 = myArr4[lessIndex + 1];
            myArr4[lessIndex + 1] = myArr4[right];
            myArr4[right] = tmp1;
            return lessIndex + 1;
        }

        // Selection sort algorithm sorts an array of strings in reverse.
        // A local variable count, type long, stores the number of comparisons 
        // performed and displays the value before exiting the method.
        public static void SelectionReverseSort(string[] myArr2)
        {
            long count = 0;
            string tmp;
            if (myArr2 != null)
            {
                for (int i = 0; i < myArr2.Length - 1; i++)
                {
                    int minPos = i;

                    for (int j = i + 1; j < myArr2.Length; j++)
                    {
                        // Compare myArr[j] to myArr[minPos] with currentculture rules and choose the larger.
                        if (string.Compare(myArr2[j], myArr2[minPos], StringComparison.CurrentCulture) > 0)
                        {
                            minPos = j;
                            count++;
                        }
                    }

                    //swap the elements at minPos and i
                    tmp = myArr2[i];
                    myArr2[i] = myArr2[minPos];
                    myArr2[minPos] = tmp;
                }
                Console.WriteLine($"\nSelectionReverseSort performed {count} comparisons.");
            }
        }

        // Bubble sort algorithm sorts an array of strings in reverse.
        // A local variable count, type long, stores the number of comparisons 
        // performed and displays the value before exiting the method.
        // Worst case: O(n^2), best case is Omega(n)
        public static void BubbleReverseSort(string[] myArr1)
        {
            string tmp;
            bool flag;
            long count = 0;

            if (myArr1 != null)
            {
                // Compares elements starting from the end of the array.
                for (int j = myArr1.Length - 1; j > 0; j--)
                {
                    flag = false;
                    for (int i = 0; i < j; i++)
                    {
                        // Compare myArr[i] to myArr[i+1] with currentculture rules.
                        if (string.Compare(myArr1[i], myArr1[i + 1], StringComparison.CurrentCulture) < 0)
                        {
                            // Swap indices and add one to count.
                            tmp = myArr1[i];
                            myArr1[i] = myArr1[i + 1];
                            myArr1[i + 1] = tmp;
                            flag = true;
                            count++;
                        }
                    }
                    // Check if array is sorted after each iteration.
                    if (flag == false)
                        break;
                }
            }
            Console.WriteLine($"\nBubbleReverseSort performed {count} comparisons.");
        }

        public static string[] ReadFromFile(string path)
        {
            // Read text from text file, change to lower, and store in lowerWords.
            //try
            //{
                string[] words = System.IO.File.ReadAllLines(path);
                // Create parallel array of words by calling ToLower.
                string[] lowerWords = new string[words.Length];
                for (int ctr = words.GetLowerBound(0); ctr <= words.GetUpperBound(0); ctr++)
                    lowerWords[ctr] = words[ctr].ToLower();
            //}
            //catch(System.IO.DirectoryNotFoundException)
            //{
                //Console.WriteLine($"The following file path could not be found: {path}");  
            //}
            // Pass the file contents to sorting algorthims.
            return lowerWords;
        }

        public static void Print(string[] myArr1)
        {
                // To make the loop easier use var instead of int.
                foreach (var arrValue in myArr1)
                    Console.Write(arrValue + " ");
                Console.WriteLine();
        }
        public static void Print(string[] myArr1, string[] myArr2, string[] myArr3, string[] myArr4)
        {
            string[][] allArr = { myArr1, myArr2, myArr3, myArr4 };
            foreach (var myArr in allArr)
            {
                // To make the loop easier use var instead of int.
                foreach (var arrValue in myArr)
                    Console.Write(arrValue + " ");
                Console.WriteLine();
            }
        }
    }
}
