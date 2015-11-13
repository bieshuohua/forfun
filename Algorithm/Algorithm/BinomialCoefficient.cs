using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    //利用动态规划的思想去求解二项式系数的问题
    class BinomialCoefficient
    {
        //自下而上的打表方式，并返回表中的最后一项
        //用动态规划计算C(n,k),return C(n,k)的值
        //n,k为二项式的参数
        public static int calBinomial(int n, int k)
        {
            int[,] C = new int[n+1,k+1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= minValue(i, k); j++)
                {
                    if (j == 0 || j == i)
                    {
                        C[i,j] = 1;
                    }
                    else
                    {
                        C[i,j] = C[i - 1,j - 1] + C[i - 1,j];
                    }
                }
            }
            return C[n,k]; 
        }
        // 返回较小的值  
        public static int minValue(int i, int k)
        {
            return (i <= k ? i : k);
        }
        //static void Main(string[] args)
        //{
        //    int n = 10;
        //    int k = 5;
        //    Console.Write(calBinomial(n,k));
        //    System.Console.ReadLine();
        //}
    }
}
