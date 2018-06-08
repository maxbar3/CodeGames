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


            int[] myArray = new int[] { 1, 3, 2, 4, 5, 9, 7};
            
            int holder = 0;
            for(int i=0; i<myArray.Length; i++)
            {
                for(int y = i + 1; y <myArray.Length; y++)
                {
                    if(myArray[y] > myArray[i]) //revers this for the other way
                    {
                        holder = myArray[y];
                        myArray[y] = myArray[i];
                        myArray[i] = holder;
                    }
                 
                }

            }

            foreach (var str in myArray)
            {
                Console.Write(str + " ");

                //MessageBox.Show(str.ToString());
            }


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


        private static void SortSolved(int[] myArray)
        {
            int holder = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        // lets to the replace 
                        holder = myArray[j];
                        myArray[j] = myArray[i];
                        myArray[i] = holder;

                    }
                    Console.WriteLine(myArray[i]);
                }
            }


            foreach (var str in myArray)
            {
                Console.Write(str + " ");

                //MessageBox.Show(str.ToString());
            }

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

    }
}
