using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class ShellSort
    {
        public static void sort(string[] a)
        {//将a[]按升序排序
            int N = a.Length;
            int h = 1;
            while (h < N / 3) h = 3* h + 1;
            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {//将a[i]插入到a[i-h]、a[i-2*h]、a[i-3*h]...之中
                    for (int j = i; j >= h && Sort.less(a[j], a[j - h]); j--)
                    {
                        Sort.exch(a, j, j - h);
                    }
                }
                h = h / 3;
            }
        }
    }
}
