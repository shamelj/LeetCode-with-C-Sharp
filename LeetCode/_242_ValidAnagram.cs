<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

﻿namespace LeetCode_with_C_Sharp.LeetCode
{
    public class _242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            return s.Except(t).Count() == 0 && t.Except(s).Count() == 0;
        }
    }
}
