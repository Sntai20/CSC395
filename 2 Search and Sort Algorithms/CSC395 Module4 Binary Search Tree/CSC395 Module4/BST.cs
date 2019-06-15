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

        /// Methods Summary: IsEmpty, Create, Insert, Find, Delete, Traverse, Max, Min.
        /// Traversal, Search, Height, Number of leaf nodes
        public bool isEmpty()
        {
            return root == null;
        }

        public void insert(int newVal)
        {
            //create a new node
            Node newNode = new Node(newVal);


            if (isEmpty())
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

        public int max()
        {
            if (isEmpty())
                throw new Exception("you can't find max in an empty BST!");
            else
            {
                Node current = root;
                while (current.right != null)//as long as there is a node to the right, I move there ...
                    current = current.right;

                return current.value;
            }
        }

        public int min()
        {
            if (isEmpty())
                throw new Exception("empty ,,, min ....");
            else
            {
                Node current = root;
                while (current.left != null)
                    current = current.left;

                return current.value;
            }
        }

        public bool contains(int key)
        {
            if (isEmpty())
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

        public bool contains2(int key)
        {
            if (isEmpty())
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

        public void printPreOrder()
        {
            preOrderHelper(root);
        }

        public void preOrderHelper(Node current)
        {
            if (current != null)
            {
                Console.Write(current.value + " ");//N
                preOrderHelper(current.left);    //L
                preOrderHelper(current.right);   //R
            }
        }

        public void printInOrder()
        {
            printInOrderHelper(root);
        }

        public void printInOrderHelper(Node current) //LNR
        {
            if (current != null)
            {
                printInOrderHelper(current.left);
                Console.Write(current.value + " ");
                printInOrderHelper(current.right);
            }
        }

        // TODO 10 Traversal: PrintInOrder, PrintPreOrder, PrintPostOrder
        // TODO 10 Search(for a value in the tree): bool search(str studName)
        // TODO 20 Height of Binary Tree:  int height()
        // TODO 20 Number of leaf nodes: int numLeafNodes()
    }
}
