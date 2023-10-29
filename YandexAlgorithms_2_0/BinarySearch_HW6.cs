using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace YandexAlgorithms_2_0
{
    delegate bool A_DelegateCheck(long[] nums, long l, long r, int ind);
    delegate bool B_DelegateCheck(int ind, long[] nums, long k);
    delegate bool LeetCode2300(int[] potions, long success, int m, int elementOfspells);
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

            int LeftBinarySearch(long l_check, long r_check, A_DelegateCheck check, long[] nums)
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


        public static void B_Solution(string a, string b, string c, string d)
        {
            int.TryParse(a, out int n);
            long[] nums = b.Split(' ').Select(long.Parse).ToArray();
            int.TryParse(c, out int m);
            long[] searchNums = d.Split(' ').Select(long.Parse).ToArray();

            for (int i = 0; i < m; i++)
            {
                int leftInd = BinarySearch(searchNums[i], LeftSearch, nums);
                int rightInd = BinarySearch(searchNums[i], RightSearch, nums);

                if (leftInd == -1)
                {
                    Console.WriteLine("0 0");
                }
                else
                {
                    leftInd++;
                    rightInd++;
                    if (nums[nums.Length - 1] == searchNums[i])
                    {
                        rightInd++;
                    }
                    if (leftInd != rightInd)
                    {
                        rightInd--;
                    }
                    Console.WriteLine(leftInd + " " + rightInd);
                }
            }

            int BinarySearch(long k, B_DelegateCheck check, long[] nums)
            {
                int l = 0;
                int r = nums.Length - 1;
                while (l < r)
                {
                    int m = (l + r) / 2;
                    if (check(m, nums, k))
                    {
                        r = m;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                if (nums[l] == k)
                {
                    return l;
                }
                else if (l > 0 && nums[l - 1] == k)
                {
                    return l;
                }
                else
                {
                    return -1;
                }
            }

            bool LeftSearch(int ind, long[]nums, long k)
            {
                if (nums[ind] >= k)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            bool RightSearch(int ind, long[] nums, long k)
            {
                if (nums[ind] > k)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public static int[] LeetCode2300(int[] spells, int[] potions, long success)
        {
            int[] results = new int[spells.Length];
            Array.Sort(potions);
            for (int  i = 0; i < spells.Length; i++)
            {
                int indPotions = BinarySearch(potions, spells[i], Check, success);
                int res = potions.Length - indPotions;
                results[i] = res;
            }
            return results;

            int BinarySearch(int[] potions, int elementOfspells, LeetCode2300 Check, long success)
            {
                int l = 0;
                int r = potions.Length - 1;
                while (l < r)
                {
                    int m = l/2 + r/2;
                    if (Check(potions, success, m, elementOfspells))
                    {
                        r = m;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                if (((long)potions[l] * (long)elementOfspells) < success)
                {
                    return l + 1;
                }
                else
                {
                    return l;
                }
            }
            bool Check(int[] potions, long success, int m, int elementOfspells)
            {
                if (((long)potions[m] * (long)elementOfspells) >= success)
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
            //A_Solution(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

            //B_Solution(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());


            int[] spells = { 5, 1, 3 };
            int[] potions = { 1, 2, 3, 4, 5 };
            long success = 7;
            int [] res = LeetCode2300(spells, potions, success);
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
        }
    }
}
