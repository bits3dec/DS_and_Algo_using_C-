using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeNode
    {
        public TreeNode(int data)
        {
            Data = data;
        }

        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

    }
}
