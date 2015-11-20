using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{//快排
    class Quick
    {
        public static void sort(string[] a)
        {
            sort(a, 0, a.Length - 1);
        }

        public static void sort(string[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int j = partition(a, lo, hi);//处理数组后，再调用递归
            sort(a, lo, j - 1);
            sort(a, j + 1, hi);//当两个子数组有序时，整个数组也就有序了
        }

        private static int partition(string[] a, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            string temp = a[i];
            while(true)
            { //左右扫描指针，当扫描结束时交换元素
                while (Sort.less(a[++i],temp)) if(i == hi)break;
                while (Sort.less(temp,a[--j])) if(j == lo)break;
                if (i >= j) break;//当指针i，j相遇时主循环退出
                Sort.exch(a, i, j);
            }
            Sort.exch(a, lo, j);
            return j;
        }
    }
}
