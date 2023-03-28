using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code_Solution.Array.Easy
{
    internal class _217_ContainsDuplicate
    {
        /// <summary>
        /// https://leetcode.com/problems/contains-duplicate/
        /// </summary>
        public bool ContainsDuplicate(int[] nums)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (dic.ContainsKey(nums[i]))
                {
                    return true;
                }

                dic[nums[i]] = 1;

            }

            return false;


        }

    }
}
