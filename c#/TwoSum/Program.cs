using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {2, 3, 4};
            var result = Program.TwoSum(arr, 6);
            Console.WriteLine(string.Join(" ", result));
        }

        static public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int numberToFind = target - nums[i];

                int test;
                if (hash.TryGetValue(numberToFind, out test))
                {
                    result[0] = hash[numberToFind];
                    result[1] = i;
                    return result;
                }

                hash[nums[i]] = i;
            }

            return result;
        }
    }

}
