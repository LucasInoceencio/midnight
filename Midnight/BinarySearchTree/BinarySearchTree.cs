﻿namespace Midnight
{
    public static class BinarySearchTree
    {

        #region Description problem

        // Link: https://www.testdome.com/questions/c-sharp/binary-search-tree/35504?visibility=1&skillId=18

        // Level: Easy

        // Binary search tree(BST) is a binary tree where the value of each node is larger or equal to the values in all the nodes
        // in that node's left subtree and is smaller than the values in all the nodes in that node's right subtree.

        // Write a function that, efficiently with respect to time used, checks if a given binary search tree contains a given value.

        // For example, for the following tree:

        // n1(Value: 1, Left: null, Right: null)
        // n2(Value: 2, Left: n1, Right: n3)
        // n3(Value: 3, Left: null, Right: null)
        // Call to Contains(n2, 3) should return true since a tree with root at n2 contains number 3.

        #endregion

        public static bool Contains(Node root, int value)
        {
            if(root != null)
            {
                if(root.Value == value)
                {
                    return true;
                }
                else if (root.Value > value)
                {
                    return Contains(root.Left, value);
                }
                else if (root.Value < value)
                {
                    return Contains(root.Right, value);
                }
            }
            return false;
        }
    }
}
