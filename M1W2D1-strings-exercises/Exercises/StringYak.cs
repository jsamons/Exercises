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
         Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but 
         the "a" can be any char. The "yak" strings will not overlap.
         stringYak("yakpak") → "pak"
         stringYak("pakyak") → "pak"
         stringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            string result = str;
            for(int x=0; x<str.Length; x++)
            {
                if(x+2>=str.Length)
                {
                    break;
                }
                else if(str[x].Equals('y') && str[x+2].Equals('k')) 
                {

                    result = result.Replace(str.Substring(x,3), "");
                }
            }
            return result;
        }
    }
}
