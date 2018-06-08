using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortGames
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome();
            SortInts();
            SortStrings();
            FrequncyCounter("aasfafvvdddddfsssggg", 10);


            Console.ReadKey();
        }

        
        private static void SortInts()
        {
            int temp = 0;
            int[] arr = new int[] { 20, 65, 98, 71, 64, 11, 2, 80, 5, 6, 100, 50, 13, 9, 80, 454 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }
        }

        private static void SortStrings()
        {
            string[] names = { "Flag", "Nest", "Cup", "Burg", "Yatch", "Next" };

            for (int i = 0; i < names.Length; i++)
            {
                var x = names[i];
                var j = i;
                while (j > 0 && names[j - 1].CompareTo(x) > 0)
                {
                    names[j] = names[j - 1];
                    j = j - 1;
                }
                names[j] = x;
            }
            Console.ReadKey();
        }


        private static void IsPalindrome()
        {
            string p = "aba";
            string pRrevers = "";
            var myStrings = p.ToCharArray();

            for(int i = myStrings.Length-1; i >= 0;  i--)
            {
                pRrevers = pRrevers + myStrings[i];
            }

            if(p == pRrevers)
                Console.Write("true");
            else
                Console.Write("false");
        }


        /// <summary>
        /// Write a function that takes two parameters:
        ///a String representing a text document
        ///an integer providing the number of items to return
        ///Implement the function such that it returns a list of Strings ordered by word frequency, the most frequently occurring word first.
        ///Runtime not to exceed O(n)
        /// </summary>
        private static void FrequncyCounter(string content, int numberOfwords)
        {
            // basic validations
            Dictionary<char, Frequency> wordMap = new Dictionary<char, Frequency>();

            var contentArray = content.ToCharArray();
            AddWordsToMap(contentArray, wordMap);
            return; //just sort the array with the sorters below SortInts style
        }

        private static void AddWordsToMap(Char[] contentArray, Dictionary<char, Frequency> wordMap)
        {
            foreach (Char c in contentArray)
            {
                if (wordMap.ContainsKey(c))
                {
                    wordMap[c].incrementFrequency();
                }
                else
                {
                    Frequency token = new Frequency();
                    wordMap.Add(c, token);
                }
            }
        }

    }
}
