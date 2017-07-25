using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or 
         whatever is there if the string is less than length 3. Return n copies of the front;
         frontTimes("Chocolate", 2) → "ChoCho"
         frontTimes("Chocolate", 3) → "ChoChoCho"
         frontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {
<<<<<<< HEAD
            string finalString = "";
            string frontLetters = "";
            if (str.Length >= 3)
            {
                frontLetters = str.Substring(0, 3);
            }
            else if (str.Length==2)
            {
                frontLetters = str.Substring(0, 2);
            }
            else if(str.Length==1)
            {
                frontLetters = str.Substring(0, 1);
            }
            for(int x=0;x<n;x++)
            {
                finalString += frontLetters;
            }
            return finalString;
=======
            int count = 0;
            string newStr = "";

            if (str.Length < 3)
            {
                while (count < n) //changed from <= to <
                {
                    newStr += str;
                    count++;
                }
            }
            
            else  //changed from "if (str.Length >= 3)" to "else"
            {
                string front = str.Substring(0, 3); //moved inside of "else"

                while (count < n) //changed from <= to <
                {
                    newStr += front;
                    count++;
                }
            }
            return newStr;
>>>>>>> 582a1be10eb5a7f88ba96279d707846532b464e1
        }

    }
}
