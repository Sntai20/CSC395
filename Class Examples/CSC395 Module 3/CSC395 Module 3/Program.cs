using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Empowering Others!";

            //foreach (char c in str)
            //{
            //    Console.WriteLine(c);
            //}

            //for(int i =0; i<str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if(i%2==0)
            //    Console.WriteLine(str[i]);
            //}

            //for (int i = 0; i < str.Length; i+=2)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //////////////////////////////////////////////////////////////////
            ////Example: Let’s write a C# program that will 
            ////  count and display the number of times the letter C 
            ////  appears in a user-given input.

            ////get user's input
            //Console.Write("Please enter your text in here: ");
            //string userInput = Console.ReadLine();

            ////iterate through the input, character by character
            //int countC = 0;

            //for(int i=0; i<userInput.Length;i++)
            //{
            //    //if (userInput[i] == 'C' || userInput[i] == 'c')
            //    if (Char.ToLower(userInput[i])  == 'c')
            //        countC++;
            //}

            //Console.WriteLine("your input has:  {0} Cs", countC);
            ////////////////////////////////////////////////////////////
            //int x = 7, y = 10;
            //x > y;

            //string str1 = "MSSA", str2 = "JBLM";
            //str1 > str2;
            //str1.CompareTo(str2) > 0;
            //String.CompareTo(str1,str2) > 0;

            //////////////////////////////////////////////////////////////
            //int x = 25;
            //f(x);
            //Console.WriteLine(x);

            //f2(ref x);
            //Console.WriteLine(x);

            //int[] arr = { 25, 50, 35 };
            //Console.WriteLine(arr[0]);
            //f3(arr);
            //Console.WriteLine(arr[0]);

            //string[] allLines = System.IO.File.ReadAllLines("W:/1/2/test.txt");
            //foreach (string line in allLines)
            //{
            //    Console.WriteLine(line);
            //}


            //////////////////////////////////////////////////////////////////////
            int[] vals = { 12, 4, 83, 7, 62, 9, 7, 911, 1000 };
            Console.WriteLine(SequentialSearch(vals, 7));   //running time is O(n)
            Console.WriteLine(SequentialSearch(vals, 84));

        }

        static void f(int x) //running time: O(1)
        {
            x = 10;
        }

        static void f2(ref int x)
        {
            x = 10;
        }

        static void f3(int[] arr)
        {
            arr[0] = 10;
        }


        //returns the position of key in array arr, -1 if not found
        //public static int SequentialSearch(int[] arr, int key)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //        if (arr[i] == key)
        //            return i;
        //    //if you get in here, you didn't find the key in arr
        //    return -1;
        //}
        public static int SequentialSearch(int[] arr, int key)//running time: O(n)
        {
            int ret = -1; 
            for (int i = 0; i < arr.Length && ret==-1; i++)
                if (arr[i] == key)
                    ret= i;
           
            return ret;
        }

        public static int GetMax(int[] arr) //running time O(n)
        {
            if (arr.Length == 0)
                throw new IndexOutOfRangeException("You can't find max in an empty array!");

            int ret = arr[0];

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > ret)
                    ret = arr[i];

            return ret;
        }

        public static int GetMaxSortedInput(int[] arr) //running time O(1)
        {
            if (arr.Length == 0)
                throw new IndexOutOfRangeException("You can't find max in an empty array!");

            return arr[arr.Length-1];
        }

        //public static int BinarySearch(int[] arr, int key)//running time: O(log n)  - !!!! Assumes the array is sorted!!!
        //{
        //    int low = 0;
        //    int high = arr.Length - 1;
        //    int mid;

        //    while (low<=high)
        //    {

        //        mid = (low + high) / 2;
        //        if (arr[mid] == key)
        //            return mid;
        //        else if (key > arr[mid])
        //            low = mid + 1;
        //        else
        //            high = mid - 1;
        //    }
        //    return -1;

        //}
        public static int BinarySearch(int[] arr, int key)//running time: O(log n)  - !!!! Assumes the array is sorted!!!
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid;
            int ret = -1;

            while (low <= high && ret == -1)
            {

                mid = (low + high) / 2;
                if (arr[mid] == key)
                    ret = mid;
                else if (key > arr[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return ret;

        }
    }
}
