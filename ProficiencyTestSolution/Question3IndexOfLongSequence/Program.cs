using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Question3IndexOfLongSequence
{
    #region Question 3

    public static partial class MyStringExtension
    {
        //added as an Extension function of String class
        public static String IndexOfLongestRun(this String str)
        {
            String result = "";
            int highestLength = 0;
            Dictionary<char, int> longSequence = new Dictionary<char, int>();

            //get the distinct characters alone to reduce the number of iterations.
            List<char> eachChar = (from s in str.ToCharArray() select s).Distinct().ToList<char>();

            MatchCollection collection = null;
            Console.WriteLine();
            foreach (char c in eachChar)
            {
                collection = Regex.Matches(str, c + "*", RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace);

                foreach (Match coll in collection)
                {
                    if (!String.IsNullOrEmpty(coll.Value))
                    {
                        if (coll.Length > highestLength)
                        {
                            highestLength = coll.Length;
                            longSequence.Clear();
                            longSequence.Add(coll.Value[0], coll.Index);
                        }
                        else if (coll.Length == highestLength)
                        {
                            if (longSequence.ContainsKey(coll.Value[0]) == false)
                                longSequence.Add(coll.Value[0], coll.Index);
                        }
                    }
                }
            }

            result += "The Result is : \n";

            foreach (KeyValuePair<char, int> pair in longSequence)
                result += "\tThe Letter : " + pair.Key + " , The Index : " + pair.Value + "\n";

            result += "\n\n";
            return result;
        }
    }

    public class Run
    {
        public static void IndexOfLongestRun(string str)
        {
            Console.WriteLine(str.IndexOfLongestRun());
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the Input String : ");
                IndexOfLongestRun(Console.ReadLine());
            }
        }
    }
    #endregion
}
