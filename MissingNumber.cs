using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_ChallengeLab
{
    public class MissingNumber
    {
        public static void MoveZeroes(int[] nums)
        {
            int count = 0; // Pointer initialized to place the next non-zero element (count)

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) // If current element is NOT a '0' 
                {
                    nums[count] = nums[i]; // Current element is moved to nums[j] pointer location
                    count++; // Increment index of J
                }
            }

            // Fill the rest of the array with 0's
            for (int i = count; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
