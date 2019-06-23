using System;
using System.Collections.Generic;

namespace CSC395_Module4
{
    /// Summary: Binary Search Trees (BST) are fast at insert and lookup.
    /// To locate a node in an N node tree, a BST algorithm
    /// a can takes in order log(N) time, on average.
    /// 
    /// BSTs are good for "dictionary" problems where the code
    /// inserts and looks up information indexed by some key.
    public class BST
    {

        /// Tree Data Summary: To create a tree,
        /// we need the top node called the root node.
        //TreeNode root;
        StudentNode rootStudent;

        // BST Constructor creates a tree with one node pointing to null.
        public BST()
        {
            rootStudent = null;
        }

        /// Methods Summary: Traversal, Search, Height, Number of leaf nodes 
        /// IsEmpty, Create, Insert, Find, Delete, Traverse, Max, Min.
        public bool IsEmpty()
        {
            return rootStudent == null;
        }

        // O(log(n))
        // Insert(a new value into the tree while maintaining the BST structure): void insert(Student newStudent)
        public void Insert(StudentNode newStudent)
        {
            //create a new node
            //StudentNode newStudentNode = new StudentNode(studentName, major: "undecided", state: "unknown");


            if (IsEmpty())
            {
                rootStudent = newStudent;
            }
            else //root is not null!
            {
                //create a pointer to move around
                StudentNode current = rootStudent;

                while (true)
                {
                    if (string.Compare(newStudent.studentName,current.studentName) <=0)
                    {
                        if (current.leftStudent != null)
                            current = current.leftStudent;//move left
                        else
                        {
                            current.leftStudent = newStudent;
                            break;
                        }
                    }
                    else
                    {
                        if (current.rightStudent != null)
                            current = current.rightStudent;//move right
                        else
                        {
                            current.rightStudent = newStudent;
                            break;
                        }
                    }

                }
            }
        }

        // O(log(n))
        // Insert(a new value into the tree while maintaining the BST structure): void insert(str studName, str major, str originState)
        internal void Insert(string studentName, string studentMajor, string originState)
        {
            // Declare and instantiate stud variable.
            StudentNode newStudentNode = new StudentNode(studentName, studentMajor, originState);

            if (rootStudent == null)
            {
                // When the tree is empty, the basenode will return the value of stud variable
                rootStudent = newStudentNode;
            }

            else
            {
                StudentNode current = rootStudent;

                while (true)
                {
                    // The conditional statement will check to see if the compared string values return
                    // less than 0 to sort them alphabetically.
                    if (string.Compare(studentName, current.studentName) < 0)
                    {
                        // If current.left node does not return null, assign current
                        // to current.left node.
                        if (current.leftStudent != null)
                        {
                            current = current.leftStudent;
                        }

                        else
                        {
                            // Else, current.left will be the stud node and the loop
                            // will break.
                            current.leftStudent = newStudentNode;
                            break;
                        }
                    }

                    // If the studName is greater (i.e., input is "Jack" and current
                    // node or basenode is "Dan"), execute the following code.
                    else
                    {
                        // If current.right node does not return null, assign
                        // current node to current.right node.
                        if (current.rightStudent != null)
                        {
                            current = current.rightStudent;
                        }

                        else
                        {
                            // Else, current.right will equal stud node and break
                            // the loop.
                            current.rightStudent = newStudentNode;
                            break;
                        }
                    }
                }
            }
        }

        public string Max()
        {
            if (IsEmpty())
                throw new Exception("you can't find max in an empty BST!");
            else
            {
                StudentNode current = rootStudent;
                while (current.rightStudent != null)//as long as there is a node to the right, I move there ...
                    current = current.rightStudent;

                return current.studentName;
            }
        }

        public string Min()
        {
            if (IsEmpty())
                throw new Exception("empty ,,, min ....");
            else
            {
                StudentNode current = rootStudent;
                while (current.leftStudent != null)
                    current = current.leftStudent;

                return current.studentName;
            }
        }

        public bool Contains(string key)
        {
            if (IsEmpty())
                return false;
            else
            {
                StudentNode current = rootStudent;

                while (current != null)
                {
                    if (key == current.studentName)
                        return true;
                    else if (string.Compare(key, current.studentName) < 0)
                        current = current.leftStudent; //move left
                    else
                        current = current.rightStudent;//move right
                }

                //current is null
                return false;
            }
        }

        public bool Contains2(string key)
        {
            if (IsEmpty())
                return false;
            else
            {
                StudentNode current = rootStudent;

                while (current != null)
                {
                    if (key == current.studentName)
                        break;
                    else if (string.Compare(key, current.studentName) < 0)
                        current = current.leftStudent; //move left
                    else
                        current = current.rightStudent;//move right
                }

                return current != null;
                //if (current == null)
                //    return false;
                //else
                //    return true;

            }
        }

        // TODO 10 Traversal: PrintPreOrder, PrintInOrder, PrintPostOrder
        /// PreOrder Summary (NLR): To sort the BST, begin with the root.
        /// PrintPreOrder method will call the PreOrderHelper method
        /// and pass the root position.
        public void PrintPreOrder()
        {
            PreOrderHelper(rootStudent);
        }

        /// O(n)
        /// PreOrderHelper Summary: Steps 1-4
        /// 1: Begin with root as the current position.
        /// 2: If the current node value is not null, print the value.
        /// 3: To print all the values on the left, split and repeat steps 1-4.
        /// 4: To print all the values on the right, split and repeat steps 1-4.
        public void PreOrderHelper(StudentNode current)
        {
            if (current != null)
            {
                Console.Write(current.studentName + " ");//N
                PreOrderHelper(current.leftStudent);    //L
                PreOrderHelper(current.rightStudent);   //R
            }
        }

        /// InOrder Summary (LNR): To sort the BST, begin with the root.
        /// PrintInOrder method will call the InOrderHelper method
        /// and pass the root position.
        public void PrintInOrder()
        {
            InOrderHelper(rootStudent);
        }

        /// O(n)
        /// InOrderHelper Summary: Steps 1-4
        /// 1: Begin with root as the current position.
        /// 2: If the current node value is not null, go to step 3.
        /// 3: Print the left value, then node value, then the right value.
        /// 4: To print all the values on the tree, split and repeat steps 1-4.
        public void InOrderHelper(StudentNode current)
        {
            if (current != null)
            {
                InOrderHelper(current.leftStudent);
                Console.Write(current.studentName + " ");
                InOrderHelper(current.rightStudent);
            }
        }

        /// PostOrder Summary (LRN): To sort the BST, begin with the root.
        /// PrintPostOrder method will call the PostOrderHelper method
        /// and pass the root position.
        public void PrintPostOrder()
        {
            PostOrderHelper(rootStudent);
        }

        /// O(n)
        /// PostOrderHelper Summary: Steps 1-4
        /// 1: Begin with root as the current position.
        /// 2: If the current node value is not null, go to step 3.
        /// 3: Print the left value, then the right value, then node value.
        /// 4: To print all the values on the tree, split and repeat steps 1-4.
        public void PostOrderHelper(StudentNode current)
        {
            if (current != null)
            {
                PostOrderHelper(current.leftStudent);
                PostOrderHelper(current.rightStudent);
                Console.Write(current.studentName + " ");
            }
        }

        // TODO 10 Search(for a value in the tree): bool search(str studName)
        /// O(n)
        /// Search Summary: To search the BST, begin with root.
        /// Search method will call the SearchHelper method and
        /// pass the root position.
        public void Search(string studentName)
        {
            SearchHelper(studentName, rootStudent);
        }

        /// SearchHelper Summary: Steps 1-4
        /// 1: If the current node value is not null, go to step 2.
        /// 2: Does the key match the current node value?
        /// 3: Is the key less than the current value? Split left and repeat steps 1-4.
        /// 4: Is the key greater than the current value? Split right and repeat steps 1-4.
        public StudentNode SearchHelper(string studentName, StudentNode current)
        {
            if (current != null)
            {
                if (studentName == current.studentName)
                {
                    Console.WriteLine($"Success! {current.studentName}");
                }
                else if (string.Compare(studentName, current.studentName) < 0)
                {
                    SearchHelper(studentName, current.leftStudent);
                }
                else if (string.Compare(studentName, current.studentName) > 0)
                {
                    SearchHelper(studentName, current.rightStudent);
                }
            }

            else
            {
                Console.WriteLine($"Unsuccessful, {studentName} appears to be missing from the tree.");
            }
            return current;
        }

        // TODO 20 Height of Binary Tree:  int height()
        /// Height Summary: O(log(n))
        /// To determine the height of a tree find the longest path,
        /// then add the number of edges from the root to the leaf node.
        public int Height()
        {
            return HeightHelper(rootStudent);
        }

        // O(log(n))
        public int HeightHelper(StudentNode current)
        {

            if (current == null)
            {
                return 0;
            }
            else
            {
                int leftSubtreeHeight = HeightHelper(current.leftStudent);
                int rightSubtreeHeight = HeightHelper(current.rightStudent);

                if (leftSubtreeHeight > rightSubtreeHeight)
                {
                    return leftSubtreeHeight + 1;
                }
                else
                {
                    return rightSubtreeHeight + 1;
                }
            }      
        }

        // TODO 20 Number of leaf nodes: int numLeafNodes()
        public int GetNumberOfLeafNodes()
        {
            return GetNumberOfLeafNodes(rootStudent);
        }

        /// <summary>
        /// O(n) Add the leaf nodes in each subtree to get the total.
        /// </summary>
        public int GetNumberOfLeafNodes(StudentNode current)
        {

            if (current == null)
            {
                return 0;
            }
            else if (current.leftStudent == null && current.rightStudent == null)
            {
                return 1;
            }
            else
            {
                return GetNumberOfLeafNodes(current.leftStudent) + GetNumberOfLeafNodes(current.rightStudent);
            }

        }
    }
}
