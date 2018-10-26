using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebIntelliTest.BusinessCode
{
    public class General
    {
        public int AddTwoPositiveNumber(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return -1;
            }
            return a + b;
        }
    }
}