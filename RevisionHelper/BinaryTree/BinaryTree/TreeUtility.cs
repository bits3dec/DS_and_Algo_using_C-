using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// Utility class for Binary Tree which provides operations like Searching, Height, Diameter
    /// </summary>
    public static class TreeUtility
    {
        #region Searching
        public static bool FindElement(TreeNode root, int key)
        {
            if (root == null) return false;

            if (root.Data == key)
            {
                return true;
            }

            if (FindElement(root.Left, key) || FindElement(root.Right, key))
                return true;

            return false;
        }
        #endregion

        #region CalculateHeight
        public static int TreeHeight(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = TreeHeight(root.Left);
            int rightHeight = TreeHeight(root.Right);

            return 1 + Math.Max(leftHeight, rightHeight);
        }

        public static int HeightUsingLevelOrder(TreeNode root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null); // Marker to indicate end of a level
            int height = 1;
            while(queue.Count > 0)
            {
                var temp = queue.Dequeue();

                if(temp != null)
                {
                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);
                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }
                else
                {
                    if(queue.Count > 0)
                    {
                        queue.Enqueue(null);
                        height++;
                    }
                }
            }

            return height;
        }
        #endregion

        #region CalculateDiameter
        //Using Height as a helper function
        public static int Diameter(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = TreeHeight(root.Left);
            int rightHeight = TreeHeight(root.Right);
            int leftDiameter = Diameter(root.Left);
            int rightDiameter = Diameter(root.Right);

            return Math.Max((1 + leftHeight + rightHeight), Math.Max(leftDiameter, rightDiameter));
        }

        //Calculate the height required in the same recursion. No helper function required
        public static int DiameterOptimized(TreeNode root)
        {
            Height height = new Height();
            int diameter = DiameterUtil(root, height);

            return diameter;
        }
        private static int DiameterUtil(TreeNode root, Height height)
        {
            if (root == null)
                return 0;

            Height leftHeight = new Height();
            Height rightHeight = new Height();

            int leftDiameter = DiameterUtil(root.Left, leftHeight);
            int rightDiameter = DiameterUtil(root.Right, rightHeight);

            height.h = 1 + Math.Max(leftHeight.h, rightHeight.h);

            return Math.Max((1 + leftHeight.h + rightHeight.h), Math.Max(leftDiameter, rightDiameter));
        }
        //wrapping the height in an object so that we can get the updated value while backtracking
        public class Height
        {
            internal int h;
        }
        #endregion

        #region HasPathSum
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            if (root.Data == sum)
                return true;

            int remainingSum = sum - root.Data;
            if (HasPathSum(root.Left, remainingSum) || HasPathSum(root.Right, remainingSum))
                return true;

            return false;
        }
        #endregion

        #region TreeView
        public static void LeftView(TreeNode root)
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null); //Marker

            Console.Write(root.Data + " ");

            while(queue.Count > 0)
            {
                TreeNode temp = queue.Dequeue();

                if(temp != null)
                {
                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);
                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }
                else
                {
                    if (queue.Count == 0)
                        break;

                    TreeNode leftNode = queue.Peek();
                    Console.Write(leftNode.Data + " ");
                    queue.Enqueue(null);
                }
            }
        }

        public static void RightView(TreeNode root)
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);

            TreeNode prevNode = root;

            while(queue.Count > 0)
            {
                TreeNode temp = queue.Dequeue();

                if(temp != null)
                {
                    prevNode = temp;
                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);
                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }
                else
                {
                    if(queue.Count == 0)
                    {
                        Console.Write(prevNode.Data + " ");
                        break;
                    }
                    else
                    {
                        Console.Write(prevNode.Data + " ");
                        queue.Enqueue(null);
                    }
                }
            }

        }
        
        public static void TopView(TreeNode root)
        {
            if (root == null)
                return;

            Queue<KeyValuePair<int, TreeNode>> queue = new Queue<KeyValuePair<int, TreeNode>>();
            SortedList<int, TreeNode> sortedList = new SortedList<int, TreeNode>();

            int hd = 0;
            KeyValuePair<int, TreeNode> kvp;
            kvp = new KeyValuePair<int, TreeNode>(hd, root);
            queue.Enqueue(kvp);

            while(queue.Count > 0)
            {
                var temp = queue.Dequeue();

                if (sortedList.ContainsKey(temp.Key) == false)
                    sortedList[temp.Key] = temp.Value;

                if (temp.Value.Left != null)
                {
                    kvp = new KeyValuePair<int, TreeNode>(temp.Key - 1, temp.Value.Left);
                    queue.Enqueue(kvp);
                }
                if (temp.Value.Right != null)
                {
                    kvp = new KeyValuePair<int, TreeNode>(temp.Key + 1, temp.Value.Right);
                    queue.Enqueue(kvp);
                }
            }

            PrintSortedList(sortedList);
        }

        public static void BottomView(TreeNode root)
        {
            if (root == null)
                return;

            int hd = 0;
            SortedList<int, TreeNode> sortedList = new SortedList<int, TreeNode>();

            BottomViewUtil(root, hd, sortedList);
            PrintSortedList(sortedList);
        }
        private static void BottomViewUtil(TreeNode root, int hd, SortedList<int, TreeNode> sortedList)
        {
            if (root == null)
                return;

            BottomViewUtil(root.Left, hd - 1, sortedList);
            BottomViewUtil(root.Right, hd + 1, sortedList);
            if (sortedList.ContainsKey(hd) == false)
                sortedList[hd] = root;
        }

        private static void PrintSortedList(SortedList<int, TreeNode> sortedList)
        {
            foreach (var kvp in sortedList)
                Console.Write(kvp.Value.Data + " ");
        }

        #endregion
    }
}
