using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorithm
{
    class Sort
    {        
        //比较两个数的大小
        public static bool less(string v, string w)
        {
            if (int.Parse(v) < int.Parse(w))
                return true;
            else
                return false;
        }
        // 交换 a[i] and a[j]
        public static void exch(Object[] a, int i, int j)
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
            ShellSort.sort(a);
            sw.Stop();
            show(a);
            System.Console.WriteLine("\n" + isSorted(a));
            System.Console.WriteLine("sort time = " + sw.Elapsed.ToString() + " ms");
            System.Console.ReadLine();
        }

    }
}
