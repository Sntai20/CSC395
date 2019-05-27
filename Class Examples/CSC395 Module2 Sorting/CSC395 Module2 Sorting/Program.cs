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
            int[] myArr = { 21, 107, 6, 50,  6, 100, 3};

            //display the array values before sorting
            Console.WriteLine("The array values BEFORE sorting: ");
            foreach(int num in myArr)
                Console.Write(num+" ");
            Console.WriteLine();

            //Utility.BubbleSortImproved(myArr);//sort the array
            //Utility.SelectionSort(myArr);
            //Utility.InsertionSort(myArr);
            //Utility.MergeSort(myArr);
            //Utility.QuickSort(myArr);
            Array.Sort(myArr);

            //display the array values after sorting
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The array values AFTER sorting: ");
            foreach (int num in myArr)
                Console.Write(num + " ");
            Console.WriteLine();


            Student[] myArr2 = {    new Student("Alice", "CS"),
                                    new Student("Chad", "Pre-law"),
                                    new Student("Bob", "Dance"),
                                    new Student("Sam", "EE")};
            Array.Sort(myArr2, (st1, st2) => String.Compare(st1.Major,st2.Major));

            foreach(var st in myArr2)
                Console.WriteLine(st);
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Major { get; set; }

        public Student(string name, string Major)
        {
            Name = name;
            this.Major = Major;
        }

        public override string ToString()
        {
            return Name + " : " + Major;
        }
    }
}
