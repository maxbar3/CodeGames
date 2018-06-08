using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            //find string with in string. 
            Console.WriteLine(ReverseString("Fawad"));

            Console.WriteLine(IsPalindrome("Fawad"));

            int n = 0;
            while (n < 1)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.Read();
        }


        private static string ReverseString(string x)
        {
            string reversedX = string.Empty;

            if (String.IsNullOrEmpty(x) || x.Length == 1)
                return x;

            var xCharArray = x.ToCharArray();

            
            for(int i=xCharArray.Length-1; i>-1; i--)
            {
                reversedX = reversedX + xCharArray[i];
            }
            
            return reversedX;
        }


        private static bool IsPalindrome(string x)
        {
            var rX = ReverseString(x);

            var xA = x.ToCharArray();
            var rXA = rX.ToCharArray();


            for(int i=0; i<xA.Length; i++)
            {
                if (xA[i] != rXA[(rXA.Length-1)-i])
                        return false;
                
                
            }
            return true;
        }






    }
}
