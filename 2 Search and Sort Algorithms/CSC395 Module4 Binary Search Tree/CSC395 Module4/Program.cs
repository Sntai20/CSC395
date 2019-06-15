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
            myTree.insert(7);
            myTree.insert(6);
            myTree.insert(9);
            myTree.insert(7);
            myTree.insert(7);
            myTree.insert(7);
            myTree.insert(11);

            Console.WriteLine("MIN = " + myTree.min());
            Console.WriteLine("MAX = "+ myTree.max());
            Console.WriteLine(myTree.contains(3));
            Console.WriteLine(myTree.contains(12));
            Console.WriteLine(myTree.contains(7));

            Console.WriteLine();
            myTree.printPreOrder();


            Console.WriteLine();
            myTree.printInOrder();
        }
    }
}
