using System;
namespace CSC395_Module4
{
    /// Node Summary: To make a BST and store values, we need a node class.
    /// 
    /// A binary tree is made up of nodes that can only have two children.
    public class TreeNode
    {
        // Data values are stored in type int.
        public int value;
        public TreeNode leftNode, rightNode;

        // TreeNode Constructor
        public TreeNode(int newVal)
        {
            value = newVal;
            //left = null;
            //right = null;
        }
    }
}
