using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            CoinChange coinChangeSolver = new CoinChange();

            Calculate_MinCoins(coinChangeSolver);
            Caluclate_NumOfCoinChanges(coinChangeSolver);

            Console.ReadKey();
        }

        private static void Calculate_MinCoins(CoinChange coinChangeSolver)
        {
            int[] coins = { 9, 6, 5, 1 };
            int n = coins.Length;
            int v = 11;

            int res_recursive = coinChangeSolver.MinCoins_Recursive(coins, n, v);
            Console.WriteLine($"Using simple recursion -> Minimum coin change required for sum: {v} is : {res_recursive}");

            int res_DP = coinChangeSolver.MinCoins_DP(coins, n, v);
            Console.WriteLine($"Using DP -> Minimum coin change required for sum: {v} is : {res_DP}");
        }

        private static void Caluclate_NumOfCoinChanges(CoinChange coinChangeSolver)
        {
            int[] coins2 = { 1, 2, 3 };
            int n2 = coins2.Length;
            int v2 = 4;

            //int num_of_changes = coinChangeSolver.NumberOfCoinChanges(coins2, n2, v2);
            int num_of_changes = coinChangeSolver.NumberOfCoinChanges_spaceEfficient(coins2, n2, v2);

            Console.WriteLine($"Using DP -> Num of coin changes possible for sum: {v2} is : {num_of_changes}");
        }
    }
}
