using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module4
{
    class Program
    {
        static void Main(string[] args)
        {
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

    

    class BST
    {
        public class Node
        {
            public int value;
            public Node left, right;

            public Node(int newVal)
            {
                value = newVal;
                //left = null;
                //right = null;
            }
        }

        //data
        Node root;

        //methods
        public bool isEmpty()
        {
            return root == null;
        }

        public void insert(int newVal)
        {
            //create a new node
            Node newNode = new Node(newVal);


            if(isEmpty())
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
                        if(current.right!=null)
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

                while (current!=null)
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
            if(current!=null)
            {
                Console.Write(current.value+" ");//N
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

        //ctor
        public BST()
        {
            root = null;
        }
    }
}
