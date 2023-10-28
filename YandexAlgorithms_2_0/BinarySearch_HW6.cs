using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace YandexAlgorithms_2_0
{
    delegate bool DelegateCheck(long[] nums, long l, long r, int ind);
    public class BinarySearch_HW6
    {
        public static void A_Solution(string first, string second, string third)
        {
            int.TryParse(first, out int n);
            string[] numsStr = second.Split(' ');
            long[] nums = new long[n];
            for (int i = 0; i < n; i++)
            {
                long.TryParse(numsStr[i], out nums[i]);
            }
            Array.Sort(nums);
            int.TryParse(third, out int k);
            int count = 1;
            List<int> results = new List<int>();
            while (count <= k)
            {
                string requests = Console.ReadLine();
                string[] requestMas = requests.Split(' ');
                long.TryParse(requestMas[0], out long l);
                long.TryParse(requestMas[1], out long r);

                int indLeft = LeftBinarySearch(l, r, CheckLeft, nums);
                int indRight = LeftBinarySearch(l, r, CheckRight, nums);

                if (r >= nums[nums.Length - 1] && l<= nums[nums.Length - 1])
                {
                    results.Add(nums.Length - indLeft);
                }
                else if (l <= nums[0])
                {
                    results.Add(indRight);
                }
                else
                {
                    results.Add(indRight - indLeft);
                }
                count++;
            }
            foreach (var i in results)
            {
                Console.WriteLine(i);
            }

            int LeftBinarySearch(long l_check, long r_check, DelegateCheck check, long[] nums)
            {
                int l = 0;
                int r = nums.Length - 1;
                while (l < r)
                {
                    int m = (r + l) / 2;
                    if (check(nums, l_check, r_check, m))
                    {
                        r = m;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                return l;
            }

            bool CheckLeft(long[] nums, long l, long r, int ind)
            {
                if (nums[ind] >= l)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool CheckRight(long[] nums, long l, long r, int ind)
            {
                if (nums[ind] > r)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public static void Main(string[] args)
        {

            A_Solution(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        }
    }
}
