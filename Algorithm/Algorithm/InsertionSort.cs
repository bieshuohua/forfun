using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    {
        public static void sort(string[] a)
        {//将a[]按升序排序
            int N = a.Length;
            for (int i = 1; i < N; i++)
            {//将a[i]插入到a[i-1]、a[i-2]、a[i-3]...之中
                for (int j = i; j > 0 && Sort.less(a[j], a[j - 1]); j--)
                {
                    Sort.exch(a,j,j-1);
                }
            }
        }
        public static void sort2(string[] a)
        {
            int N = a.Length;
            for (int i = 1;i < N ;i++ )
            {
                string temp = a[i];
                int j = i;
                for (;j > 0 && Sort.less(temp,a[j - 1]) ;j-- )
                { 
                    a[j] = a[j - 1];
                }
                a[j] = temp;
            }
        }
    }
}
