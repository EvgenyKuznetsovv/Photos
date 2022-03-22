using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public class Canculator // можно ли здесь просто написать статик?
    {
        public static int Max(int a, int b) // зачем статик ?
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }
        
    }
}
