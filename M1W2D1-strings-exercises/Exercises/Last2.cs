﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return the count of the number of times that a substring length 2 appears in the string and 
         also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
         last2("hixxhi") → 1
         last2("xaxxaxaxx") → 1
         last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {
            int result = 0;
            if(str.Length<2)
            {
                result = 0;
            }
            for (int x = 0; x < str.Length-2; x++)
            {
                if(str.Substring(x,2).Equals(str.Substring(str.Length - 2, 2)))
                {
                        result += 1;
                }
            }
            return result;
        }
    }
}