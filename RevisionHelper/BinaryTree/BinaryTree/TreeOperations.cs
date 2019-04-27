using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeOperations
    {
        public static void TreeTraversal(TreeNode root)
        {
            TreeTraversal treeTraversal = new TreeTraversal();

            //Console.WriteLine("The PreOrder traversal is: ");
            //treeTraversal.PreOrder(root);

            //Console.WriteLine("\n \nThe InOrder traversal is: ");
            //treeTraversal.InOrder(root);

            //Console.WriteLine("\n\nThe PostOrder traversal is: ");
            //treeTraversal.PostOrder(root);

            //Console.WriteLine("\n \nThe PreOrder-NonRecursive traversal is: ");
            //treeTraversal.PreOrderNonRecursive(root);

            //Console.WriteLine("\n \nThe InOrder-NonRecursive traversal is: ");
            //treeTraversal.InOrderNonRecursive(root);

            //Console.WriteLine("\n \nThe LevelOrder traversal is: ");
            //treeTraversal.LevelOrder(root);

            //Console.WriteLine("\n \nThe ZigZag traversal is: ");
            //treeTraversal.ZigZagTraversal(root);

            //Console.WriteLine("\n \nThe VerticalOrder traversal is: ");
            //treeTraversal.VerticalOrder(root);
        }

        public static void FindElement(TreeNode root)
        {
            int key = 20;
            Console.WriteLine("\n \nSearching for the key:" + key);
            if(TreeUtility.FindElement(root, key))
                Console.WriteLine("A TreeNode with the given key:" + key + " exists!");
            else
                Console.WriteLine("A TreeNode with the given key:" + key + " donot exist!");
        }

        public static void CalculateHeight(TreeNode root)
        {
            //int height = TreeUtility.TreeHeight(root);
            int height = TreeUtility.HeightUsingLevelOrder(root);
            Console.WriteLine("The height of the tree is: " + height);
        }

        public static void CalculateDiameter(TreeNode root)
        {
            int diameter = TreeUtility.Diameter(root);
            //int diameter = TreeUtility.DiameterOptimized(root);
            Console.WriteLine("The diameter of the given tree is: " + diameter);
        }

        public static void HasPathSum(TreeNode root)
        {
            int sum = 10;
            var res = TreeUtility.HasPathSum(root, sum);
            if(res == true)
                Console.WriteLine("Path exists with the given sum " + sum);
            else
                Console.WriteLine("Path donot exist with the given sum");
        }

        public static void TreeView(TreeNode root)
        {
            //Console.WriteLine("The left view of the tree is: ");
            //TreeUtility.LeftView(root);
            //Console.WriteLine("\n\nThe right view of the tree is: ");
            //TreeUtility.RightView(root);
            Console.WriteLine("\n\nThe top view of the tree is: ");
            TreeUtility.TopView(root);
            Console.WriteLine("\n\nThe bottom view of the tree is: ");
            TreeUtility.BottomView(root);
        }

        public static void CheckBalancedTree(TreeNode root)
        {
            if(IsBalanced(root) == true)
                Console.WriteLine("The given tree is balanced!");
            else
                Console.WriteLine("The given tree is not balanced!");
        }
        private static bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            int leftSubTreeHeight = TreeUtility.TreeHeight(root.Left);
            int rightSubTreeHeight = TreeUtility.TreeHeight(root.Right);

            int diff = Math.Abs(leftSubTreeHeight - rightSubTreeHeight);

            if (diff <= 1 && IsBalanced(root.Left) && IsBalanced(root.Right))
                return true;

            return false;
        }
    }
}
