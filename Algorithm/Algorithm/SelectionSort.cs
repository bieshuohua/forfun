using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class SelectionSort
    {
        public static void sort(string[] a)
        {//将a[]按升序排序
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {//将a[i]和a[i+1..N]中的最小元素交换
                int min = i;//a[i+1..N]中最小元素的索引
                for (int j = i + 1; j < N; j++)
                {
                    if (Sort.less(a[j], a[min])) min = j;
                }
                if (i != min)
                {
                    Sort.exch(a, min, i);
                }
            }
        }
    }
}
