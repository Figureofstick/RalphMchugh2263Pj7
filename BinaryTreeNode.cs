using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RalphMchugh2263Pj7
{
    /******************************************************************************
 * BinaryTreeNode class dvb. Functions as both the node class and the class for
 *  the overall tree as the tree is a node is a tree. Inserts in alphabetical order.
*  ********************************************************************************/

    // Started writing after receiving for an assignment 11/5/2023 by Ralph Liam McHugh

    internal class BinaryTreeNode
    {
        private string nodeValue = "";
        protected BinaryTreeNode? rightTree = null;
        protected BinaryTreeNode? leftTree = null;

        public BinaryTreeNode(string s1)
        {
            InsertValIntoSubTree(s1);
        }

        // I made an empty constructor so that the insertVal can be less of a pain
        // as of writing this comment I am not sure how it will work out - RLM
        public BinaryTreeNode() { }


        /************************************************
        * Splat(int x) returns a string of splats of length x
        * **********************************************/
        private string Splat(int x)
        {
            string s = "";
            for (int i = 0; i < x; i += 1) s = s + "*";
            return s;
        }

        /******************************************************************
        * GetInfixSubTreeString(int treeLevel) dvb returns string containing 
        *  outline of a infix traversal of the tree using indentation to indicate level 
        * as shown in the example provided.
        ********************************************************************/

        // Ralph Liam McHugh 11/6/2023 
        public string GetInfixSubTreeString()
        { //dummy recursion initiation
            return GetInfixSubTreeString(0);
        }

        private string GetInfixSubTreeString(int treelevel)
        {
            
        }

        /* Ralph Liam McHugh 11/8/2023
         * This returns a string of all the values in infix order with a comma to delimit them
         */
        public string getStringOfAllInfixValues(BinaryTreeNode currentNode) {
            if (currentNode == null) { return ""; }
            else
            {
                string left = GetInfixSubTreeString(currentNode.leftTree);
                string middle = currentNode.nodeValue;
                string right = GetInfixSubTreeString(currentNode.rightTree);

                // Check if left or right subtree is non-empty to decide whether to add delimiter
                if (left != "" && right != "")
                    return left + ", " + middle + ", " + right;
                else if (left != "")
                    return left + ", " + middle + right;
                else if (right != "")
                    return left + middle + ", " + right;
                else
                    return middle;
            }

        }

        /******************************************************************************
        * InsertValIntoSubTree
        *     inserts value into subtree below this node in alphabetical order. IF node 
        *     value is empty then inserts into node value. else if less than nodeValue 
        *     then tells left node to insertintosubtree - if no leftnode then makes one. 
        *    else tells rightnode to insertintosubtree. Does nothing if already in tree.
        ********************************************************************************/
        public void InsertValIntoSubTree(string s)
        {
            if(nodeValue == "") { nodeValue = s; }
            if (!IsValInSubTree(s)) {
                if (Convert.ToInt32(s) < Convert.ToInt32(nodeValue))
                {
                    if (leftTree == null) { leftTree = new BinaryTreeNode(); }
                    leftTree.InsertValIntoSubTree(s);
                }
                else if(Convert.ToInt32(s) > Convert.ToInt32(nodeValue)){
                    if(rightTree == null) {  rightTree = new BinaryTreeNode(); }
                    rightTree.InsertValIntoSubTree(s);

                }
            }
        }

        /* Ralph Liam McHugh 11/6/2023
         * follows the same logic as the insertVal function above but does it with a node instead
         */
        public void insert(BinaryTreeNode node)
        {
            // call find first to see if the node is in the tree already
            if (true)
            {
                if (Convert.ToInt32(node.nodeValue) < Convert.ToInt32(nodeValue))
                {
                    if (leftTree == null) { leftTree = node; }
                    leftTree.insert(node);
                }
                else if (Convert.ToInt32(node.nodeValue) > Convert.ToInt32(nodeValue))
                {
                    if (rightTree == null) { rightTree = node; }
                    rightTree.insert(node);
                }
            }
        }

        /******************************************************************************
        * IsValInSubTree returns true iff Value in tree. 
        ********************************************************************************/
        public Boolean IsValInSubTree(string s)
        {
            if (nodeValue == s) { return true; }
            // check left tree for val
            else if (Convert.ToInt32(s) < Convert.ToInt32(nodeValue) && leftTree != null)
            {
                return leftTree.IsValInSubTree(s);
            }
            // check right tree for val
            else if (Convert.ToInt32(s) > Convert.ToInt32(nodeValue) && rightTree != null)
            {
                return rightTree.IsValInSubTree(s);
            }
            // left tree and right tree didn't have it, return false
            else { return false; }
        }

        /* Ralph Liam McHugh 11/8/2023
         * This is a recursive find function
         * you enter it with the root node and the lookup 
         */
        public BinaryTreeNode find(BinaryTreeNode node, int lookup) 
        {
            // if the node entered is null, return null
            if(node == null) { return null; }
            // if the node is the same as what you wanted, return that node
            else if(Convert.ToInt32(node.nodeValue) == lookup)) { return node; }
            // if that node is less than lookup, go through the right path
            else if(Convert.ToInt32(node.nodeValue) < lookup) { return find(node.rightTree, lookup)}
            // if that node is greater than lookup, go through the left path
            else { return find(node.leftTree)}
        }

        /* Ralph Liam McHugh 11/8/2023
         * This function finds the parent node of the node given
         * which wasn't in the project writeup but makes the delete function 
         * way easier for some of deletion cases.
         */
        public BinaryTreeNode findParent(BinaryTreeNode node, int lookup)
        {
            // if the node entered is null, return null
            if (node == null) { return null; }
            // if the node is the parent node of the lookup, return that node
            else if (Convert.ToInt32(node.leftTree.nodeValue) == lookup || Convert.ToInt32(node.rightTree.nodeValue) == lookup) { return node; }
            // if that node is less than lookup, go through the right path
            else if (Convert.ToInt32(node.nodeValue) < lookup) { return findParent(node.rightTree, lookup)}
            // if that node is greater than lookup, go through the left path
            else { return findParent(node.leftTree)}
        }

        /* Ralph Liam McHugh 11/8/2023
         * This code finds the infix order predecessor node of the node given and returns it
         * it does this by going to the largest value node in the tree to the left of the node given
         * not to be confused with findParent which is a different function
         */
        public BinaryTreeNode findPredecessor(BinaryTreeNode node) {
            
            if(node.leftTree == null) { return null; } // no predecessor for the node given
            else
            {   // go to the largest possible value node in the tree left of the node given
                node = node.leftTree;
                while(node != null)
                {
                    node = node.rightTree;
                }
                return node;
            }
        }
        
        /* Ralph Liam McHugh - 11/6/2023
         * this will recurse the left side down to the min value then return
         * Binary Search trees are inherently sorted so this should always be the minimum value
         */
        public BinaryTreeNode minVal(BinaryTreeNode node){
                // are you at the left most leaf yet? if yes return node
                if (node.leftTree == null) { return node; }
                // if you aren't keep going
                else { return minVal(node.leftTree); }
            
            }
        
         /* Ralph Liam McHugh - 11/6/2023
          * this will recurse the right side to the maximum value then return
          * Binary Search Trees are inherently sorted so this should always be the minimum value
         */
        public BinaryTreeNode maxVal(BinaryTreeNode node) {
                // are you at the right most leaf yet? if yes return node
                if (node.rightTree == null) { return node; }
                // if you aren't keep going
                else { return maxVal(node.rightTree); }

        }


        /* Ralph Liam McHugh 11/8/2023
         * this function finds the node given and then 
         * re-attaches any children it has after removing it
        */
        public void delete(BinaryTreeNode node){
            
            // is the node given a leaf node? if so just set it's place in the parent equal to null
            if(node.leftTree == null && node.rightTree == null) 
            {
                // if the parent's left tree is the node, set it to null
                if (findParent(this, Convert.ToInt32(node.nodeValue)).leftTree == node) { findParent(this, Convert.ToInt32(node.nodeValue)) = null; }
                // if the parent's right tree is the node, set it to null
                else if (findParent(this, Convert.ToInt32(node.nodeValue)).rightree == node) { findParent(this, Convert.ToInt32(node.nodeValue)) = null; }
                
            }
            // if the node given only has one child, append it to the parent of the node given
            else if(node.leftTree != null ^ node.rightTree != null ) {
                // store the child node
                BinaryTreeNode stored;
                if(node.leftTree != null){ stored = node.leftTree; }
                else { stored = node.rightTree; }

                // if the parent's left tree is the node, set it to the stored child
                if (findParent(this, Convert.ToInt32(node.nodeValue)).leftTree == node) { findParent(this, Convert.ToInt32(node.nodeValue)) = stored; }
                // if the parent's right tree is the node, set it to the stored child
                else if (findParent(this, Convert.ToInt32(node.nodeValue)).rightree == node) { findParent(this, Convert.ToInt32(node.nodeValue)) = stored; }

            }
            /* if the node given has two children, then figure out which situation to place them in
                    situation 1. replace the node you are deleting with one of the children 
                                 so the parent of the node points to one child and the other child is a child of that

                    situation 2. 
             */
            else if(node.leftTree != null && node.rightTree != null)
            {

            }
        }

        /******************************************************************************
       * DeleteValFromSubTree locates and deletes Value from tree. returns true iff
       * Value in tree. 
       * Ralph Liam McHugh 11/8/2023
       ********************************************************************************/
        public Boolean DeleteValFromSubTree(string s)
        {
            // the value you told me to delete wasn't in the tree to begin with
            if (!IsValInSubTree(s)) { return false; }
            // the value must be in the tree or you wouldn't be this far in the code
            else
            {   // pass the value to delete function and return true
                delete(find(this, Convert.ToInt32(s)));
                return true;
            }
           

        }

        /* Ralph Liam McHugh 11/8/2023
         * this function combines the two nodes, it runs through the secondNode, plucking values off and inserting them into 
         * firstNode. Since insertion is inherently sorted, it works great
         * it does this by passing the node ref, not the value ref so I figured it worked for the assignment
         * 
         */
        public BinaryTreeNode setUnion(BinaryTreeNode firstNode, BinaryTreeNode secondNode) {
            while (secondNode != null)
            {

            }






            return firstNode;
        }
        
        /* Ralph Liam McHugh 11/8/2023
         * Finds the minimum depth to get to a leaf in the tree
         * returns the depth as an int 
         */
        public int minDepth(BinaryTreeNode node, int d) {
            // d as in depth
            
            // did you feed me nothing? if so it's a depth of zero
            if(node == null) { return 0; }
            // are you at a leaf? return the depth of that leaf
            if(node.leftTree == null && node.rightTree == null){ return d; }
            // there is still a branch on the right, check the depth
            if(node.leftTree == null) { return minDepth(node.rightTree, d += 1); }
            // there is still a branch on the left, check the depth
            if(node.rightTree == null) { return minDepth(node.leftTree, d += 1);  }

            // give me the minimum between the left and the right 
            return Math.Min(minDepth(node.leftTree, d +=1 ), minDepth(node.rightTree, d += 1));
           
        }
        
        /* Ralph Liam McHugh 11/8/2023
         * Finds the maximum depth to get to a leaf in the tree
         * returns the depth as an int
         */
        public int maxDepth() {
            // d as in depth

            // did you feed me nothing? if so it's a depth of zero
            if (node == null) { return 0; }
            // are you at a leaf? return the depth of that leaf
            if (node.leftTree == null && node.rightTree == null) { return d; }
            // there is still a branch on the right, check the depth
            if (node.leftTree == null) { return minDepth(node.rightTree, d += 1); }
            // there is still a branch on the left, check the depth
            if (node.rightTree == null) { return minDepth(node.leftTree, d += 1); }

            // give me the minimum between the left and the right 
            return Math.Max(minDepth(node.leftTree, d += 1), minDepth(node.rightTree, d += 1));

        }

    }
}
