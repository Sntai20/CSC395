using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO Create a Tree class that implements the binary search tree(BST) 
            // Traversal, Search, Height, Number of leaf nodes methods and stores objects of class Student.

            //BST.Node myNode = new BST.Node();

            BST myTree = new BST();
            //myTree.isEmpty();
            myTree.Insert(7);
            myTree.Insert(6);
            myTree.Insert(9);
            myTree.Insert(7);
            myTree.Insert(7);
            myTree.Insert(7);
            myTree.Insert(11);

            Console.WriteLine("MIN = " + myTree.Min());
            Console.WriteLine("MAX = "+ myTree.Max());
            Console.WriteLine(myTree.Contains(3));
            Console.WriteLine(myTree.Contains(12));
            Console.WriteLine(myTree.Contains(7));

            Console.WriteLine();
            myTree.PrintPreOrder();


            Console.WriteLine();
            myTree.PrintInOrder();
        }
    }
}
