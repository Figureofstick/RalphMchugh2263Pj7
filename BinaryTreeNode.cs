using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RalphMchugh2263Pj7
{
    /******************************************************************************
 * BinaryTreeNode class dvb. Functions as both the node class and the class for
 *  the overall tree as the tree is a node is a tree. Inserts in alphabetical order.
*  ********************************************************************************/

    // Written after receiving for an assignment 11/5/2023 by Ralph Liam McHugh

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
        // I didn't like how it was set up originally with the (int treeLevel) so I changed it to 
        // do it with BinaryTreeNodes 
        // also when I say I didn't like it, I couldn't actually figure out how to do it
        
        public string GetInfixSubTreeString()
        { //dummy recursion initiation
            return GetInfixSubTreeString(this);
        }

        private string GetInfixSubTreeString(BinaryTreeNode currentNode)
        {
            if(currentNode == null) { return ""; }
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
       


        /* Ralph Liam McHugh
         */

        public BinaryTreeNode find(int lookup) { return this; }
        

        /* Ralph Liam McHugh
         */
        public BinaryTreeNode findPredecessor(int lookup) { return this; }
        /* Ralph Liam McHugh
         */
        
        public string getStringOfAllInfixValues() { return ""; }
        
        
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


        /* Ralph Liam McHugh
        */
        public void delete(BinaryTreeNode node){
            // Calls the find function
        }
        /******************************************************************************
       * DeleteValFromSubTree locates and deletes Value from tree. returns true iff
       * Value in tree. 
       ********************************************************************************/
        public Boolean DeleteValFromSubTree(string s)
        {
            return true;
        }


        /* Ralph Liam McHugh
         */
        public BinaryTreeNode setUnion() { return this; }
        
        /* Ralph Liam McHugh
         */
        public int minDepth() {
            //if()

            return 0;
        }
        
        /* Ralph Liam McHugh
         */
        public int maxDepth() {
            return 1;

        }



    }
}
