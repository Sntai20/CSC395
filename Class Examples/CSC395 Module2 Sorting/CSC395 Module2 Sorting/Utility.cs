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
        //TODO write the running time of the method.
        //Modify the merge sort algorithm seen in class so it works with an array 
        //of strings AND the array will have the values sorted in reverse. Also 
        //add a local variable count(use long count) of the number of comparisons 
        //that were performed.Display it before exiting this method.
        public static void MergeReverseSort()
        {
            throw new NotImplementedException();
        }

        public static void MergeSort(int[] arr)
        {
            int[] tmp = new int[arr.Length]; //used as a temp buffer
            MergeSortHelper(arr, 0, arr.Length - 1, tmp);
        }

        public static void MergeSortHelper(int[] arr, int first, int last, int[] tmp)
        {
            if(first<last)//if we have at least two elements
            {
                int mid = (first + last) / 2;
                MergeSortHelper(arr, first, mid ,tmp);
                MergeSortHelper(arr, mid+1, last,tmp);
                Merge(arr, first, mid+1, last, tmp);
            }
        }

        public static void Merge(int[] arr, int first, int mid, int last, int[] tmp)
        {
            //tmp is the temporary buffer
            int i = first;
            int j = mid;
            int k = first;

            while(i<mid && j <=last )
            {
                if (arr[i] < arr[j])//pick the smallest of the two ...
                {
                    tmp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    tmp[k] = arr[j];
                    j++;
                    k++;
                }
            }

            //put the remaining elements
            while(i<mid) //only runs if there are elements left in the first half
            {
                tmp[k] = arr[i];
                k++;
                i++;
            }

            while(j <= last)
            {
                tmp[k] = arr[j];
                j++;
                k++;
            }

            //copy back tmp into arr
            for (int p = first; p <= last; p++)
                arr[p] = tmp[p];
        }

        //TODO write the running time of the method.
        //Modify the quick sort algorithm seen in class so it works with an 
        //array of strings AND the array will have the values sorted in reverse. 
        //Also add a local variable count(use long count) of the number of 
        //comparisons that were performed.Display it before exiting this method.
        public static void QuickReverseSort(object myArr)
        {
            throw new NotImplementedException();
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
            for (int i = 0; i < myArr.Length - 1; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < myArr.Length; j++)
                    if (myArr.Length > minPos)
                        if (myArr[j].CompareTo(myArr[minPos]) > 0)
                            minPos = j;

                //swap the elements at minPos and i
                string tmp = myArr[i];
                myArr[i] = myArr[minPos];
                myArr[minPos] = tmp;
            }
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
        //Modify the bubble sort algorithm seen in class so it works with an 
        //array of strings AND the array will have the values sorted in reverse.
        //Also add a local variable count(use long count) of the number of 
        //comparisons that were performed.Display it before exiting this method.
        public static void BubbleReverseSort(string[] myArr)
        {
            string tmp;
            bool flag = false;


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
                    }
                if (flag == false)//i.e. the array is sorted
                    break;
            }
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
                lowerWords[ctr] = words[ctr].ToLowerInvariant();

            foreach (string lowerWord in lowerWords)
            {
                Console.Write(lowerWord + " ");
            }
            // Pass the file contents to the CountVowels function.
            return lowerWords;
        }
    }
}
