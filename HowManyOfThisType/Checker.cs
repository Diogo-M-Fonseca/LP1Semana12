using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfThisType<T>(IEnumerable<object> items)
        {
            int num = 0;

            foreach (object item in items)
            {

                if (item is T)
                {
                    num++;
                }
            }
            return num;
        }
    }
}