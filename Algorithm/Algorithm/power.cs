using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    public class power
    {//分治法
        public static int power_dnc(int x, int n)
        {//计算x的n次幂
            if (n == 1)
            {
                return x;
            }
            if (n % 2 == 0)
            {
                return power_dnc(x, n / 2) * power_dnc(x, n / 2);
            }
            else
            {
                return power_dnc(x, (n + 1) / 2) * power_dnc(x, (n - 1) / 2);
            }
        }
    }
}
