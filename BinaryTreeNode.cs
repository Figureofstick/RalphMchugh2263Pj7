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
        public string GetInfixSubTreeString()
        { //dummy recursion initiation
            return GetInfixSubTreeString(0);
        }

        private string GetInfixSubTreeString(int treeLevel)
        {
            return "";
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
                if (Convert.ToInt32(s) <= Convert.ToInt32(nodeValue))
                {
                    if (leftTree == null) { leftTree = new BinaryTreeNode(); }
                    leftTree.InsertValIntoSubTree(s);
                }
                else if(Convert.ToInt32(s) >= Convert.ToInt32(nodeValue)){
                    if(rightTree == null) {  rightTree = new BinaryTreeNode(); }
                    rightTree.InsertValIntoSubTree(s);

                }
            }
        }
        /******************************************************************************
        * IsValInSubTree returns true iff Value in tree. 
        ********************************************************************************/
        public Boolean IsValInSubTree(string s)
        {
            return true;
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

        //public BinaryTreeNode find(int lookup) { }
        

        /* Ralph Liam McHugh
         */
        //public BinaryTreeNode findPredecessor(int lookup) { }
        /* Ralph Liam McHugh
         */
        //public string getStringOfAllInfixValues() { }
        /* Ralph Liam McHugh
         */
        //public void insert(BinaryTreeNode node){// calls the find function to ensure no duplicates}
        
        /* Ralph Liam McHugh
         */
        //public BinaryTreeNode minVal(){// this will recurse the left side down to the first value then return}
        /* Ralph Liam McHugh
         */
        //public BinaryTreeNode maxVal() { // this will recurse the right side down to the last value then return}
        /* Ralph Liam McHugh
         */
        //public void delete(BinaryTreeNode node){// Calls the find function}
        /* Ralph Liam McHugh
         */
        //public BinaryTreeNode setUnion() { }
        /* Ralph Liam McHugh
         */
        //public int minDepth() { }
        /* Ralph Liam McHugh
         */
        //public int maxDepth() { }



    }
}
