using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreeBuilder
    {
        public TreeNode GetTree()
        {
            TreeNode root = new TreeNode(1);

            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);

            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(7);

            root.Left.Left.Left = new TreeNode(8);
            root.Left.Left.Right = new TreeNode(9);

            //root.Left.Right.Right = new TreeNode(10);
            //root.Left.Right.Right.Right = new TreeNode(11);
            //root.Left.Right.Right.Right.Right = new TreeNode(12);

            return root;
        }
    }
}
