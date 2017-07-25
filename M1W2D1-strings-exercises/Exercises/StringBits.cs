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
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         stringBits("Hello") → "Hlo"
         stringBits("Hi") → "H"
         stringBits("Heeololeo") → "Hello"
         */
        public string StringBits(string str)
        {
            string result = "";
            for(int x=0; x<str.Length; x++)
            {
                if(x==0)
                {
                    result = str.Substring(0,1);
                }
                else if(x%2==0)
                {
                    result = result + str.Substring(x, 1);
                }
            }
            return result;
        }
    }
}
