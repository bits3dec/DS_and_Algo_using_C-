using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WordUtility
    {
        public static HashSet<string> GetDictionary()
        {
            string[] temp_dictionary =
            {
                "I",
                "like",
                "had",
                "play",
                "to",
                "abc"
            };

            HashSet<string> dictionary = new HashSet<string>();

            for (int i = 0; i < temp_dictionary.Length; ++i)
                dictionary.Add(temp_dictionary[i]);

            return dictionary;
        }

        public static string GetInputString()
        {
            string inputString = "Ihadliketoplay";

            return inputString;
        }
    }
}
