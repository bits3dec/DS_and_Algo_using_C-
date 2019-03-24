using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreeTraversal
    {
        public void PreOrder(TreeNode root)
        {
            if (root == null)   return;

            Console.Write(root.Data + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        public void InOrder(TreeNode root)
        {
            if (root == null)   return;

            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }

        public void PostOrder(TreeNode root)
        {
            if (root == null) return;

            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.Write(root.Data + " ");
        }

        public void PreOrderNonRecursive(TreeNode root)
        {
            if (root == null) return;

            Stack<TreeNode> stack = new Stack<TreeNode>();

            while(true)
            {
                while(root != null)
                {
                    Console.Write(root.Data + " ");
                    stack.Push(root);
                    root = root.Left;
                }

                if (stack.Count() == 0)
                    return;

                root = stack.Pop();
                //Left subtree and root completed. Now go to right subtree
                root = root.Right;
            }
        }

        public void InOrderNonRecursive(TreeNode root)
        {
            if (root == null) return;

            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (true)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.Left;
                }

                if (stack.Count() == 0)
                    return;

                root = stack.Pop();
                // Left SubTree -> Current Root
                Console.Write(root.Data + " ");
                // Go to Right SubTree
                root = root.Right;
            }
        }

        public void LevelOrder(TreeNode root)
        {
            if (root == null) return;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while(queue.Count() > 0)
            {
                var tempNode = queue.Dequeue();

                Console.Write(tempNode.Data + " ");

                if (tempNode.Left != null)
                    queue.Enqueue(tempNode.Left);
                if (tempNode.Right != null)
                    queue.Enqueue(tempNode.Right);
            }
        }

        public void ZigZagTraversal(TreeNode root)
        {
            if (root == null)
                return;

            Stack<TreeNode> currentLevel = new Stack<TreeNode>();
            Stack<TreeNode> nextLevel = new Stack<TreeNode>();
            int leftToRight = 1;

            currentLevel.Push(root);

            while(currentLevel.Count > 0)
            {
                var temp = currentLevel.Pop();

                Console.Write(temp.Data + " ");
                if (leftToRight == 1)
                {
                    if (temp.Left != null)
                        nextLevel.Push(temp.Left);
                    if (temp.Right != null)
                        nextLevel.Push(temp.Right);
                }
                else
                {
                    if (temp.Right != null)
                        nextLevel.Push(temp.Right);
                    if (temp.Left != null)
                        nextLevel.Push(temp.Left);
                }

                if(currentLevel.Count == 0) //End of a level
                {
                    //pass by reference to get the update stacks after swapping
                    Swap(ref currentLevel, ref nextLevel);
                    leftToRight = 1 - leftToRight;
                }
            }
        }
        private void Swap(ref Stack<TreeNode> stack1, ref Stack<TreeNode> stack2)
        {
            var temp = stack1;
            stack1 = stack2;
            stack2 = temp;
        }

        public void VerticalOrder(TreeNode root)
        {
            if (root == null)
                return;

            SortedList<int, List<TreeNode>> sortedList = new SortedList<int, List<TreeNode>>();

            VerticalOrderUtil(root, 0, sortedList);
            PrintSortedList(sortedList);
        }
        private void VerticalOrderUtil(TreeNode root, int hd, SortedList<int, List<TreeNode>> sortedList)
        {
            if (root == null)
                return;

            if (sortedList.ContainsKey(hd))
                sortedList[hd].Add(root);
            else
                sortedList[hd] = new List<TreeNode>() { root };

            VerticalOrderUtil(root.Left, hd - 1, sortedList);
            VerticalOrderUtil(root.Right, hd + 1, sortedList);
        }
        private void PrintSortedList(SortedList<int, List<TreeNode>> sortedList)
        {
            foreach (KeyValuePair<int, List<TreeNode>> next in sortedList)
            {
                foreach (var item in next.Value)
                    Console.Write(item.Data + " ");

                Console.Write("\n");
            }
        }
    }
}
