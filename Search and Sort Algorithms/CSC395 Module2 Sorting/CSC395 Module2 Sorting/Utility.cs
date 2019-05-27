﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module2_Sorting
{
    class Utility
    {
        //TODO write the running time of the method.
        //Modify the merge sort algorithm seen in class so it works with an array 
        //of strings AND the array will have the values sorted in reverse. Also 
        //add a local variable count(use long count) of the number of comparisons 
        //that were performed.Display it before exiting this method.
        public static void MergeReverseSort(string[] myArr3)
        {
            double count = 0; 
            string[] tmp = new string[myArr3.Length]; //used as a temp buffer
            MergeReverseSortHelper(myArr3, 0, myArr3.Length - 1, tmp);
            Console.WriteLine($"\nMergeReverseSort performed {count} comparisons.");
        }

        public static void MergeReverseSortHelper(string[] myArr3, int first, int last, string[] tmp)
        {
            //double count = 0;
            if (first < last)//if we have at least two elements
            {
                int mid = (first + last) / 2;
                MergeReverseSortHelper(myArr3, first, mid, tmp);
                MergeReverseSortHelper(myArr3, mid + 1, last, tmp);
                Merge(myArr3, first, mid + 1, last, tmp);
            }
            //Console.WriteLine($"\nMergeReverseSort performed {count} comparisons.");
        }

        public static void Merge(string[] myArr3, int first, int mid, int last, string[] tmp)
        {
            //tmp is the temporary buffer
            int i = first;
            int j = mid;
            int k = first;

            while (i<mid && j <=last )
            {
                if (string.Compare(myArr3[i], myArr3[j], StringComparison.CurrentCulture) > 0)
                    //if (arr[i] < arr[j])//pick the smallest of the two ...
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
            }

            //put the remaining elements
            while(i<mid) //only runs if there are elements left in the first half
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

            //copy back tmp into arr
            for (int p = first; p <= last; p++)
                myArr3[p] = tmp[p];
        }

        //TODO write the running time of the method.
        //Modify the quick sort algorithm seen in class so it works with an 
        //array of strings AND the array will have the values sorted in reverse. 
        //Also add a local variable count(use long count) of the number of 
        //comparisons that were performed.Display it before exiting this method.

        //public static void QuickReverseSort(string[] myArr4)
        //{
        //    double count = 0;
        //    QuickReverseSortHelper(myArr4, 0, myArr4.Length - 1);
        //    Console.WriteLine($"\nQuickReverseSort performed {count} comparisons.");
        //}


        //public static void QuickReverseSortHelper(string[] myArr4, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int sz = right - left + 1;
        //        string pivotpt = (left + right) / 2;
        //        int i = left;
        //        int j = right - 1;
        //        int pivot = myArr4[pivotpt];
        //        swap(myArr4[pivotpt], myArr4[right]);
        //        pivotpt = right;
        //        while (i < j)
        //        {
        //            while (i < right - 1 && myArr4[i] < pivot)
        //                i++;
        //            while (j > 0 && myArr4[j] > pivot)
        //                j--;
        //            if (i < j)
        //                swap(myArr4[i++], myArr4[j--]);
        //        }
        //        if (i == j && myArr4[i] < myArr4[pivotpt])
        //            i++;
        //        swap(myArr4[i], myArr4[pivotpt]);
        //        quick(myArr4, left, i - 1);
        //        quick(myArr4, i + 1, right);
        //    }
        //}

        //public static void quick(int arr[], int size)
        //{
        //    quick(arr, 0, size - 1);
        //}

        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public static void quickSort(int[] arr)
        {
            quickSortHelper(arr, 0, arr.Length - 1);
            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void quickSortHelper(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSortHelper(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSortHelper(arr, pivot + 1, right);
                }
            }
        }

        public static void InsertionSort(int[] arr)//worst case:  O(n^2), best case is Omega(n)
            {
                for(int i=1;i<arr.Length;i++)
                {
                    int tmp = arr[i];//save the current element
                    //look to the left and shift all elements larger than tmp to the right, one position
                    int j = i - 1;
                    while (j >= 0 && arr[j]>tmp)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }

                    //put tmp back into the arr
                    arr[j+1] = tmp;
                }
            }

        //TODO write the running time of the method.
        //Modify the selection sort algorithm seen in class so it works with an 
        //array of strings AND the array will have the values sorted in reverse.
        //Also add a local variable count(use long count) of the number of 
        //comparisons that were performed.Display it before exiting this method.
        public static void SelectionReverseSort(string[] myArr)
        {
            double count = 0;

            for (int i = 0; i < myArr.Length - 1; i++)
            {
                int minPos = i;

                for (int j = i + 1; j < myArr.Length; j++)
                    if (string.Compare(myArr[j], myArr[minPos], StringComparison.CurrentCulture) > 0)
                        minPos = j;
                    //swap the elements at minPos and i
                    string tmp = myArr[i];
                    myArr[i] = myArr[minPos];
                    myArr[minPos] = tmp;
                    count++;

                //if (myArr.Length > minPos)
                //if (string.Compare(myArr[i], myArr[i + 1], StringComparison.CurrentCulture) <= 0)
            }
            Console.WriteLine($"\nSelectionReverseSort performed {count} comparisons.");
        }

        public static void SelectionSort(int[] arr) //best and worst is O(n^2)
        {
            for(int i=0; i<arr.Length-1;i++)
            {
                int minPos = i;
                for(int j=i+1;j<arr.Length;j++)
                    if (arr[j] < arr[minPos])
                        minPos = j;
                
                //swap the elements at minPos and i
                int tmp = arr[i];
                arr[i] = arr[minPos];
                arr[minPos] = tmp;
            }
        }

        //TODO write the running time of the method.
        //Added a bubble sort algorithm to sort an array of strings in reverse. 
        //Added a local variable to count of the number of comparisons that were performed.
        //Display counter before exiting this method.
        public static void BubbleReverseSort(string[] myArr)
        {
            string tmp;
            bool flag = false;
            long count = 0;

            for (int j = myArr.Length - 1; j > 0; j--)
            {
                flag = false;
                for (int i = 0; i < j; i++)
                    //if (myArr[i].CompareTo(myArr[i+1])
                    if (string.Compare(myArr[i], myArr[i + 1], StringComparison.CurrentCulture) < 0)
                    {
                        tmp = myArr[i];
                        myArr[i] = myArr[i + 1];
                        myArr[i + 1] = tmp;
                        flag = true;
                        count++;
                    }
                if (flag == false)//i.e. the array is sorted
                    break;
            }
            Console.WriteLine($"\nBubbleReverseSort performed {count} comparisons.");
        }

        public static void BubbleSort(int[] arr) // worst case: O(n^2), best case: Omega(n^2) => Theta(n^2)
        {
            int tmp;
            for (int j = arr.Length - 1; j>0;j--)
            {
                for (int i = 0; i < j; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
            }
        }

        public static void BubbleSortImproved(int[] arr) //worst case:  O(n^2), best case is Omega(n)
        {
            int tmp;
            bool flag = false;


            for (int j = arr.Length - 1; j > 0; j--)
            {
                flag = false;
                for (int i = 0; i < j; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        flag = true;
                    }
                if (flag == false)//i.e. the array is sorted
                    break;
            }
        }

        //TODO write the running time of the method.
        public static string[] ReadFromFile(string path)
        {
            // Read text from text file and store in string.
            string[] words = System.IO.File.ReadAllLines(path);

            // Create parallel array of words by calling ToLowerInvariant.
            string[] lowerWords = new string[words.Length];
            for (int ctr = words.GetLowerBound(0); ctr <= words.GetUpperBound(0); ctr++)
                lowerWords[ctr] = words[ctr].ToLower();

            //foreach (string lowerWord in lowerWords)
            //{
            //    Console.Write(lowerWord + " ");
            //}
            // Pass the file contents to the CountVowels function.
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
