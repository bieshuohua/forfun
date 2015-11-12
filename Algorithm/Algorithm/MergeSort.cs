using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class MergeSort
    {//分治法
        private static string[] aux;//辅助数组
        public static void sort(string[] a)
        { 
            aux = new string[a.Length];//一次性分配空间
            sort(a,0,a.Length-1);
        }
        private static void sort(string[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int mid = (lo + hi) / 2;
            sort(a,lo,mid);//左半边排序
            sort(a,mid + 1,hi);//右半边排序
            merge(a,lo,mid,hi);//归并结果
        }
        private static void merge(string[] a, int lo, int mid, int hi)
        {//两个有序数列归并为一个有序数列
            int i = lo, j = mid + 1;
            for (int m = lo; m <= hi; m++)
            {
                aux[m] = a[m];
            }
            int k = lo;
            while (i <= mid && j <= hi)
            {
                if (int.Parse(aux[i]) <= int.Parse(aux[j]))
                    a[k++] = aux[i++];
                else
                    a[k++] = aux[j++];
            }
            while(i <= mid)
                a[k++] = aux[i++];
            while(j <= hi)
                a[k++] = aux[j++];
            
        }
    }
}
