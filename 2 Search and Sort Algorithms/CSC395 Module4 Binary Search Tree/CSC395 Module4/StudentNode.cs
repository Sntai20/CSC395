using System;
namespace CSC395_Module4
{
    /// Node Summary: To make a BST and store values, we need a node class.
    /// 
    /// A binary tree is made up of nodes that can only have two children.
    /// Implement a Student class that stores name, major, and state of origin.
    /// The students should be sorted alphabetically by names in the tree:
    public class StudentNode
    {
        // Student Data
        public string studentName;
        public string studentMajor;
        public string originState;

        public StudentNode leftStudent, rightStudent;

        // StudentNode Constructor
        public StudentNode(string name, string major, string state)
        {
            studentName = name;
            studentMajor = major;
            originState = state;
        } 
    }
}
