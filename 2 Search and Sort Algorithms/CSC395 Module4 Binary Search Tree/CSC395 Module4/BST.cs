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
        /// Node Summary: To make a BST and store values, we need a node class.
        /// 
        /// A binary tree is made up of nodes that can only have two children.
        public class Node
        {
            // Data values are stored in type int.
            public int value;
            public Node left, right;

            // Constructor
            public Node(int newVal)
            {
                value = newVal;
                //left = null;
                //right = null;
            }
        }

        /// Tree Data Summary: To create a tree,
        /// we need the top node called the root node.
        Node root;

        // BST Constructor creates a tree with one node pointing to null.
        public BST()
        {
            root = null;
        }

        /// Methods Summary: Traversal, Search, Height, Number of leaf nodes 
        /// IsEmpty, Create, Insert, Find, Delete, Traverse, Max, Min.
        public bool IsEmpty()
        {
            return root == null;
        }

        public void Insert(int newVal)
        {
            //create a new node
            Node newNode = new Node(newVal);


            if (IsEmpty())
            {
                root = newNode;
            }
            else //root is not null!
            {
                //create a pointer to move around
                Node current = root;

                while (true)
                {
                    if (newVal <= current.value)
                    {
                        if (current.left != null)
                            current = current.left;//move left
                        else
                        {
                            current.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        if (current.right != null)
                            current = current.right;//move right
                        else
                        {
                            current.right = newNode;
                            break;
                        }
                    }

                }
            }
        }

        public int Max()
        {
            if (IsEmpty())
                throw new Exception("you can't find max in an empty BST!");
            else
            {
                Node current = root;
                while (current.right != null)//as long as there is a node to the right, I move there ...
                    current = current.right;

                return current.value;
            }
        }

        public int Min()
        {
            if (IsEmpty())
                throw new Exception("empty ,,, min ....");
            else
            {
                Node current = root;
                while (current.left != null)
                    current = current.left;

                return current.value;
            }
        }

        public bool Contains(int key)
        {
            if (IsEmpty())
                return false;
            else
            {
                Node current = root;

                while (current != null)
                {
                    if (key == current.value)
                        return true;
                    else if (key < current.value)
                        current = current.left; //move left
                    else
                        current = current.right;//move right
                }

                //current is null
                return false;
            }
        }

        public bool Contains2(int key)
        {
            if (IsEmpty())
                return false;
            else
            {
                Node current = root;

                while (current != null)
                {
                    if (key == current.value)
                        break;
                    else if (key < current.value)
                        current = current.left; //move left
                    else
                        current = current.right;//move right
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
            PreOrderHelper(root);
        }

        /// PreOrderHelper Summary: Steps 1-4
        /// 1: Begin with root as the current position.
        /// 2: If the current node value is not null, print the value.
        /// 3: To print all the values on the left, split and repeat steps 1-4.
        /// 4: To print all the values on the right, split and repeat steps 1-4.
        public void PreOrderHelper(Node current)
        {
            if (current != null)
            {
                Console.Write(current.value + " ");//N
                PreOrderHelper(current.left);    //L
                PreOrderHelper(current.right);   //R
            }
        }

        /// InOrder Summary (LNR): To sort the BST, begin with the root.
        /// PrintInOrder method will call the InOrderHelper method
        /// and pass the root position.
        public void PrintInOrder()
        {
            InOrderHelper(root);
        }

        /// InOrderHelper Summary: Steps 1-4
        /// 1: Begin with root as the current position.
        /// 2: If the current node value is not null, go to step 3.
        /// 3: Print the left value, then node value, then the right value.
        /// 4: To print all the values on the tree, split and repeat steps 1-4.
        public void InOrderHelper(Node current) //LNR
        {
            if (current != null)
            {
                InOrderHelper(current.left);
                Console.Write(current.value + " ");
                InOrderHelper(current.right);
            }
        }

        /// PostOrder Summary (LRN): To sort the BST, begin with the root.
        /// PrintPostOrder method will call the PostOrderHelper method
        /// and pass the root position.
        public void PrintPostOrder()
        {
            PostOrderHelper(root);
        }

        /// PostOrderHelper Summary: Steps 1-4
        /// 1: Begin with root as the current position.
        /// 2: If the current node value is not null, go to step 3.
        /// 3: Print the left value, then the right value, then node value.
        /// 4: To print all the values on the tree, split and repeat steps 1-4.
        public void PostOrderHelper(Node current)
        {
            if (current != null)
            {
                PostOrderHelper(current.left);
                PostOrderHelper(current.right);
                Console.Write(current.value + " ");
            }
        }

        // TODO 10 Search(for a value in the tree): bool search(str studName)
        /// Search Summary: To search the BST, begin with the root.
        /// Search method will call the SearchHelper method and
        /// pass the root position.
        public void Search(int key)
        {
            SearchHelper(key, root);
            //Node current = root;
            //Console.WriteLine($"{key} found at node {current.value}");
        }

        /// SearchHelper Summary: Steps 1-4
        /// 1: Begin with root as the current position.
        /// 2: If the current node value is not null, go to step 3.
        /// 3: Is the key in the current node?
        /// 4: To print all the values on the tree, split and repeat steps 1-4.
        public Node SearchHelper(int key, Node current)
        {
            if (current != null)
            {
                if (key == current.value)
                {
                    Console.WriteLine($"Success! {current.value}");
                }
                else if (key < current.value)
                {
                    SearchHelper(key, current.left);
                    //current = current.left;
                }
                else if (key > current.value)
                {
                    SearchHelper(key, current.right);
                    //current = current.right;
                }
            }

            else
            {
                Console.WriteLine($"Unsuccessful, {key} appears to be missing from the tree.");
            }
            return current;
        }

        // TODO 20 Height of Binary Tree:  int height()
        //public int Height()
        //{
        //    throw new Exception("Not implemented.");
        //}

        //// TODO 20 Number of leaf nodes: int numLeafNodes()
        ////public int numLeafNodes()
        //{
        //    throw new Exception("Not implemented.");
        //}
    }
}
