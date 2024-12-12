using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_ChallengeLab
{
    public class MissingNumber
    {
        public static int MissingNumbers(int[] nums)
        {
            int ans = 0;
            for (int i = 0; i <= nums.Length; i++)
            {    //n=nums.length
                ans = ans ^ i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                ans = ans ^ nums[i];
            }
            return ans;
        }
    }
}

