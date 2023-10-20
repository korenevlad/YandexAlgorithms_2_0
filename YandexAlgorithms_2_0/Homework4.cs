using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexAlgorithms_2_0
{
    public class Homework4
    {
        //Cловари и сортировка подсчётом
        //LEETCODE 75 - Задача 2215 - Easy
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();
            result.Add(result1);
            result.Add(result2);

            HashSet<int> mySet1 = new HashSet<int>();
            HashSet<int> mySet2 = new HashSet<int>();
            foreach (var i in nums1)
            {
                if (!mySet1.Contains(i))
                {
                    mySet1.Add(i);
                    result[0].Add(i);
                }
            }
            foreach (var i in nums2)
            {
                if (mySet1.Contains(i))
                {
                    result[0].Remove(i);
                }
            }
            foreach (var i in nums2)
            {
                if (!mySet2.Contains(i))
                {
                    mySet2.Add(i);
                    result[1].Add(i);
                }
            }
            foreach (var i in nums1)
            {
                if (mySet1.Contains(i))
                {
                    result[1].Remove(i);
                }
            }
            return result.Cast<IList<int>>().ToList();

        }

        //LEETCODE 75 - Задача 1207 - Easy
        public static bool UniqueOccurrences(int[] arr)
        {
            bool flag = true;
            Dictionary<int, int> valueCount = new Dictionary<int, int>();
            HashSet<int> setCount = new HashSet<int>();
            foreach (var item in arr)
            {
                if (!valueCount.ContainsKey(item))
                {
                    valueCount[item] = 1;
                }
                else
                {
                    valueCount[item]++;
                }
            }
            List<int> valueCountToList = valueCount.Values.ToList();
            foreach(var item in valueCountToList)
            {
                if (setCount.Contains(item))
                {
                    flag = false;
                    break;
                }
                else
                {
                    setCount.Add(item);
                }
            }
            return flag;
        }

        //LEETCODE 75 - Задача 1657 - Medium
        public static bool CloseStrings(string word1, string word2)
        {
            char[] masStr1 = word1.ToCharArray();
            char [] masStr2 = word2.ToCharArray();
            bool flag = true;
            Dictionary<char, int> symbolCountStr1 = new Dictionary<char, int>();
            Dictionary<char, int> symbolCountStr2 = new Dictionary<char, int>();
            if (masStr1.Length != masStr2.Length)
            {
                flag = false;
            }
            else
            {
                for (int i = 0; i < masStr1.Length; i++)
                {
                    if (!symbolCountStr1.ContainsKey(masStr1[i])) { symbolCountStr1[masStr1[i]] = 1; }
                    else symbolCountStr1[masStr1[i]]++; 

                    if (!symbolCountStr2.ContainsKey(masStr2[i])) { symbolCountStr2[masStr2[i]] = 1; }
                    else symbolCountStr2[masStr2[i]]++;
                }
                List <int> symbolCountStr1ToList = symbolCountStr1.Values.ToList();
                List <int> symbolCountStr2ToList = symbolCountStr2.Values.ToList();

                foreach (var item in symbolCountStr1ToList)
                {
                    if (!symbolCountStr2ToList.Contains(item))
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }

        public static void Main(string[] args)
        {
            //LEETCODE 75 - Задача 2215 - Easy

            //int[] nums1 = { 1, 2, 3, 3 };
            //int[] nums2 = { 1, 1, 2, 2 };
            //FindDifference(nums1, nums2);


            //LEETCODE 75 - Задача 1207 - Easy
            //int[] nums3 = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            //Console.WriteLine(UniqueOccurrences(nums3));


            //LEETCODE 75 - Задача 1657 - Medium
            Console.WriteLine(CloseStrings("a", "aa"));
        }
    }
}
