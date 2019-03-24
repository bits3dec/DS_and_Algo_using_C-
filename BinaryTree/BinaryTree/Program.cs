using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeBuilder tree = new TreeBuilder();

            var root = tree.GetTree();

            //TreeOperations.TreeTraversal(root);
            //TreeOperations.FindElement(root);
            //TreeOperations.CalculateHeight(root);
            //TreeOperations.CalculateDiameter(root);
            //TreeOperations.HasPathSum(root);
            //TreeOperations.TreeView(root);
            TreeOperations.CheckBalancedTree(root);

            Console.ReadKey();
        }

        
    }
}
 