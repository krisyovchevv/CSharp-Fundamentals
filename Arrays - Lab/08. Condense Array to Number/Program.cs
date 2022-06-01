using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int i = 0;
            int couter = 0;
            while (nums.Length > 1 && i < nums.Length)
            {
                int indexToRemove = nums[i];
                if (nums.Length == i + 1)
                {
                    nums = nums.Where(x => x > indexToRemove).ToArray();
                    i = 0;
                }
                if (nums.Length == 1)
                {
                    break;
                }
                couter++;
                int condensed = nums[i] + nums[i + 1];
                nums[i] = condensed;
                i++;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
