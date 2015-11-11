using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SelectionSort
{
    class SelectionSort
    {
        public static void sort(string[] a)
        {//将a按升序排序
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {//将a[i]和a[i+1..N]中的最小元素交换
                int min = i;//最小元素的索引
                for (int j = i + 1; j < N; j++)
                {
                    if (less(a[j],a[min])) min = j;
                }
                exch(a,min,i);
            }
        }
        //比较两个数的大小
        private static bool less(string v, string w)
        {
            if (int.Parse(v) < int.Parse(w))
                return true;
            else
                return false;
        }
        // 交换 a[i] and a[j]
        private static void exch(Object[] a, int i, int j)
        {
            Object swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }
        //数组a[]是否已按升序排好序?
        private static string isSorted(string[] a)
        {
            return isSorted(a, 0, a.Length - 1);
        }

        //数组是否从a[lo]到a[hi]按升序排好序？
        private static string isSorted(string[] a, int lo, int hi)
        {
            for (int i = lo + 1; i <= hi; i++)
                if (less(a[i], a[i - 1])) return "fail";
            return "success";
        }
        //标准输出数组
        private static void show(string[] a)
        {
            for(int i = 0;i < a.Length;i++)
                System.Console.Write(a[i] + " ");
        }
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            System.Console.WriteLine("hello world,let's start");
            String[] a = System.Console.ReadLine().Split( );
            sw.Start();
            SelectionSort.sort(a);
            sw.Stop();
            show(a);
            System.Console.WriteLine("\n" + isSorted(a));
            System.Console.WriteLine("sort time = " + sw.Elapsed.ToString() + " ms");
            System.Console.ReadLine();
        }

    }
}
