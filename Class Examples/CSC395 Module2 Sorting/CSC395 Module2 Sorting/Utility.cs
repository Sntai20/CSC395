using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module2_Sorting
{
    class Utility
    {
        public static void QuickSort(int[] arr)
        {
            QuickSortHelper(arr, 0, arr.Length - 1);
        }


        public static void QuickSortHelper(int[] arr, int first, int last)
        {
            if(first<last) //i.e. we have at least two elements in the subarray we are sorting in here
            {
                //pick a pivot and partition the array
                int p = Partition(arr, first, last);
                QuickSortHelper(arr, first, p - 1);
                QuickSortHelper(arr, p + 1, last);
            }
        }

        //it returns the new index of the pivot after the partitioning is done
        public static int Partition(int[] arr, int first, int last)
        {
            
            int pivot = arr[last];
            int lessIndex = first - 1;

            for(int j = first; j< last; j++)
            {
                if(arr[j]<=pivot)
                {
                    lessIndex++;
                    int tmp = arr[j];
                    arr[j] = arr[lessIndex];
                    arr[lessIndex] = tmp;
                }
            }

            //move the pivot in place
            //int tmp = arr[last];
            //arr[last] = arr[lessIndex + 1];
            //arr[lessIndex + 1] = tmp;
            arr[last] = arr[lessIndex + 1];
            arr[lessIndex + 1] = pivot;

            return lessIndex + 1;//new position of the pivot
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
    }
}
