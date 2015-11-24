using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Algorithm
{
    class TwoSum
    {
        public static void Main()
        {
            int[] sum = {3,2,4};
            int target = 6;
            twosum(sum, target);
            Console.ReadKey();
        }
        public static int[] twosum(int[] nums, int target)
        {
            int[] result = new int[2];
            Hashtable sumht = new Hashtable();
            for (int i = 0;i < nums.Length ;i++ )
            {
                int second = target - nums[i];//这次nums[i]对应正确的元素是...
                if (sumht.ContainsKey(nums[i]))//怀抱希望，看看你是不是个对的元素（在不在哈希表里）
                {// 好，是喔，找到了一个可能存在的实际存在，任务完成
                    result[0] = Convert.ToInt32(sumht[nums[i]]) + 1;//这个值较小，因遍历时i自增的
                    result[1] = i + 1;
                    break;
                }
                else if(!sumht.ContainsKey(second))//不可以添加重复元素啊，啊，啊~
                {// not found the second one，他妈的，把不一定存在的东西存在哈希表里，继续循环找找看
                    sumht.Add(second, i);
                }
            }
            return result;
        }
    }
}
