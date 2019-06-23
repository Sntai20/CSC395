using System;
namespace CSC395_Module4
{
    public class Utility
    {
        // Populate binary search tree with integers.
        internal static void CreateBSTWithIntegers()
        {
            //BST myTree = new BST();
            ////myTree.isEmpty();
            //myTree.Insert(7);
            //myTree.Insert(6);
            //myTree.Insert(9);
            //myTree.Insert(7);
            //myTree.Insert(7);
            //myTree.Insert(7);
            //myTree.Insert(11);

            //Console.WriteLine("MIN = " + myTree.Min());
            //Console.WriteLine("MAX = " + myTree.Max());
            //Console.WriteLine(myTree.Contains(3));
            //Console.WriteLine(myTree.Contains(12));
            //Console.WriteLine(myTree.Contains(7));

            //Console.WriteLine();
            //Console.Write("PreOrder: ");
            //myTree.PrintPreOrder();

            //Console.WriteLine();
            //Console.Write("InOrder: ");
            //myTree.PrintInOrder();

            //Console.WriteLine();
            //Console.Write("PostOrder: ");
            //myTree.PrintPostOrder();

            ////Console.WriteLine();
            ////Console.WriteLine();
            ////myTree.Search(9);

            //Console.WriteLine("\n");
            ////myTree.Search(3);

            //Console.WriteLine($"Tree Height: {myTree.Height()}");
            //Console.WriteLine($"Number of Leaf Nodes in tree: {myTree.GetNumberOfLeafNodes()}");
        }

        // Populate binary search tree with student objects.
        internal static void CreateBSTWithStudents()
        {
            BST myStudentTree = new BST();

            myStudentTree.Insert("Bob", "CS", "WA");         
            myStudentTree.Insert("Alice", "History", "CA");  
            myStudentTree.Insert("Chris", "Math", "NY");     
            myStudentTree.Insert("Brian", "Undecided", "DC");      
            myStudentTree.Insert("Nick", "English", "MD"); 
            myStudentTree.Insert("Ann", "ME", "WA");

            StudentNode myStudentNode = new StudentNode("Antonio", "CS", "CA");
            myStudentTree.Insert(myStudentNode);

            //Console.WriteLine("MIN = " + myStudentTree.Min());
            //Console.WriteLine("MAX = " + myStudentTree.Max());
            //Console.WriteLine(myStudentTree.Contains("Alice"));
            //Console.WriteLine(myStudentTree.Contains("Ann"));
            //Console.WriteLine(myStudentTree.Contains("Antonio"));

            Console.WriteLine();
            Console.Write("PreOrder: ");
            myStudentTree.PrintPreOrder();

            Console.WriteLine();
            Console.Write("InOrder: ");
            myStudentTree.PrintInOrder();

            Console.WriteLine();
            Console.Write("PostOrder: ");
            myStudentTree.PrintPostOrder();

            Console.WriteLine("\n");
            myStudentTree.Search("Chris");

            Console.WriteLine($"Tree Height: {myStudentTree.Height()}");
            Console.WriteLine($"Number of Leaf Nodes in tree: {myStudentTree.GetNumberOfLeafNodes()}");
            Console.WriteLine();
        }
    }
}
