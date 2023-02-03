using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2023.Console.LeetCode

{
    using System;
    public class TwoSum
    {
        public static void Main() 
        {
            int[] ints = Solution(new int[] {2, 7, 11, 15}, 9);
            Console.WriteLine(ints);
        }

        public static int[] Solution(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    int prevIndex = map[target - nums[i]];
                    return new int[] {prevIndex, i};
                } else
                {
                    map[nums[i]] = i;
                }
            }
            return null;
        }
    }
}
