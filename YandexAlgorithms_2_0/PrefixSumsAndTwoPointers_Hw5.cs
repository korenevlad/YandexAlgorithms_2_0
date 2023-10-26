using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace YandexAlgorithms_2_0
{
    public class PrefixSumsAndTwoPointers_Hw5
    {
        public static void A_Solution()
        {
            string[] ParseStr()
            {
                string str = Console.ReadLine();
                string[] strMas = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                return strMas;
            }

            string[] firstMas = ParseStr();
            int.TryParse(firstMas[0], out int sizeMas);
            int.TryParse(firstMas[1], out int countRequests);

            string[] masStr = ParseStr();
            int[] masInt = new int[sizeMas];
            for(int i = 0; i < sizeMas; i++)
            {
                int.TryParse(masStr[i], out masInt[i]);
            }

            BigInteger[] masPrefix = new BigInteger[sizeMas + 1];
            masPrefix[0] = 0;

            for (int j = 1; j < sizeMas + 1; j++)
            {
                masPrefix[j] = masPrefix[j - 1] + masInt[j - 1];
            }
            List<BigInteger> resultsList = new List<BigInteger>();
            for (int i = 0; i < countRequests; i++)
            {
                string[] masRequest = ParseStr();
                int.TryParse(masRequest[0], out int l);
                int.TryParse(masRequest[1], out int r);
                BigInteger result = masPrefix[r - 1] - masPrefix[l - 1] + masInt[r - 1];
                resultsList.Add(result);
            }
            foreach (var i in resultsList)
            {
                Console.WriteLine(i);
            }

        }


        public static void B_Solution(string sizeMas, string mas)
        {
            int.TryParse(sizeMas, out int size);
            string[] masStr = mas.Split(' ');
            BigInteger[] masInt = new BigInteger[size];
            for (int i = 0; i < size; i++)
            {
                masInt[i] = int.Parse(masStr[i]);
            }
            BigInteger[] prefixSum = new BigInteger[size + 1];
            prefixSum[0] = 0;
            for (int i = 1; i < size + 1; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + masInt[i - 1];
            }
            BigInteger mindo = prefixSum.Max();
            List<BigInteger> res = new List<BigInteger>();
            for (int i = 0; i<prefixSum.Length; i++)
            {
                res.Add(prefixSum[i] - mindo);
                if(mindo > prefixSum[i])
                {
                    mindo = prefixSum[i];
                }
            }
            res.Remove(0);
            Console.WriteLine(res.Max());
        }


        public static void LeetCode1732(int[] num)
        {
            BigInteger[] prefix = new BigInteger[num.Length + 1];
            prefix[0] = 0;
            for(int i = 1; i < num.Length + 1; i++)
            {
                prefix[i] = prefix[i - 1] + num[i - 1]; 
            }
            Console.WriteLine(prefix.Max());
        }

        public static int LeetCode724(int[] nums)
        {
            int result = -1;
            BigInteger[] prefixSum = new BigInteger[nums.Length + 1];
            prefixSum[0] = 0;
            for (int i = 1; i < nums.Length + 1; i ++)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i - 1];
            }
            for (int i = prefixSum.Length -1; i > 0; i--)
            {
                if (prefixSum[prefixSum.Length-1]-prefixSum[i] == prefixSum[i - 1])
                {
                    result = i - 1;
                }
            }
            return result;
        }
        public static int LetCode560(int[] nums, int k)
        {
            int result = 0;
            int[] prefixSum = new int[nums.Length + 1];
            prefixSum[0] = 0;
            for(int i = 1; i < nums.Length + 1; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i - 1];
            }
            int backPointer = 0;
            int forwardPointer = 1;
            while (backPointer < prefixSum.Length-1)
            {
                if (forwardPointer < prefixSum.Length)
                {
                    if (prefixSum[forwardPointer] - prefixSum[backPointer] == k)
                    {
                        result++;
                        forwardPointer++;
                    }
                    else
                    {
                        forwardPointer++;
                    }
                }
                else
                {
                    backPointer++;
                    forwardPointer = backPointer + 1;
                }

            }
            return result;
        }

        //public static void C_Solution(string firstStr, string secondStr, string thirdStr )
        //{
        //    int result = 0;

        //    string[] nm = firstStr.Split(' ');
        //    int.TryParse(nm[0], out int N);
        //    int.TryParse(nm[1], out int M);
        //    string[] groupsStr = secondStr.Split(' ');
        //    string[] audsStr = thirdStr.Split(' ');
        //    int[] groups = new int[groupsStr.Length];
        //    int[] auds = new int[audsStr.Length];

        //    Dictionary<int, int> set = new Dictionary<int, int>();
        //    Dictionary<int, int> resultSet = new Dictionary<int, int>();

        //    for (int i = 0; i < N; i++)
        //    {
        //        int.TryParse(groupsStr[i], out groups[i]);
        //    }
        //    for (int i = 0; i < M; i++)
        //    {
        //        int.TryParse(audsStr[i], out auds[i]);
        //        set[auds[i]] = i + 1;
        //    }
        //    int[] groupsSorted = new int[N];
        //    Array.Copy(groups, groupsSorted, groups.Length);
        //    Array.Sort(groupsSorted);
        //    Array.Sort(auds);

        //    int audsPointer = 0;
        //    int groupsPointer = 0;

        //    while (groupsPointer < N && audsPointer < M)
        //    {
        //        if (auds[audsPointer] - groupsSorted[groupsPointer] < 1)
        //        {
        //            if(audsPointer < M - 1)
        //            {
        //                audsPointer++;
        //            }
        //        }
        //        else
        //        {
        //            if (groupsPointer >= N - 1)
        //            {
        //                result++;
        //                resultSet[groupsSorted[groupsPointer]] = set[auds[audsPointer]];
        //                break;
        //            }
        //            else
        //            {
        //                if (auds[audsPointer] - groupsSorted[groupsPointer + 1] >= 1)
        //                {
        //                    groupsPointer++;
        //                }
        //                else
        //                {
        //                    result++;
        //                    resultSet[groupsSorted[groupsPointer]] = set[auds[audsPointer]];
        //                    groupsPointer++;
        //                    audsPointer++;
        //                }
        //            }
        //        }
        //    }
        //    foreach(var i in groups)
        //    {
        //        if (resultSet.ContainsKey(i))
        //        {
        //            Console.Write(resultSet[i] + " ");
        //        }
        //        else
        //        {
        //            Console.Write(0 + " ");
        //        }
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine(result);

        //}


        public static bool LeetCode1657(string word1, string word2)
        {
            char[] masStr1 = word1.ToCharArray();
            char[] masStr2 = word2.ToCharArray();
            bool flagMain = true;
            bool flagContain = false;
            Dictionary<char, int> symbolCountStr1 = new Dictionary<char, int>();
            Dictionary<char, int> symbolCountStr2 = new Dictionary<char, int>();

            HashSet<char> charContainer = new HashSet<char>();

            if (masStr1.Length != masStr2.Length)
            {
                flagMain = false;
            }
            else
            {
                for (int i = 0; i < masStr1.Length; i++)
                {
                    charContainer.Add(masStr1[i]);

                    if (!symbolCountStr1.ContainsKey(masStr1[i]))
                    { symbolCountStr1[masStr1[i]] = 1; }
                    else symbolCountStr1[masStr1[i]]++;

                    if (!symbolCountStr2.ContainsKey(masStr2[i]))
                    { symbolCountStr2[masStr2[i]] = 1; }
                    else symbolCountStr2[masStr2[i]]++;
                }
                foreach (var i in masStr2)
                {
                    if (!charContainer.Contains(i))
                    {
                        flagContain = true;
                        break;
                    }
                }
                List<int> symbolCountStr1ToList = symbolCountStr1.Values.ToList();
                List<int> symbolCountStr2ToList = symbolCountStr2.Values.ToList();

                foreach (var item in symbolCountStr1ToList)
                {
                    if (symbolCountStr2ToList.Contains(item))
                    {
                        symbolCountStr2ToList.Remove(item);
                    }
                    else
                    {
                        flagMain = false;
                        break;
                    }
                }
            }
            if (flagContain == true)
            {
                flagMain = false;
            }
            return flagMain;
        }


        public static void Main(string[] args)
        {
            //A_Solution();

            //B_Solution(Console.ReadLine(), Console.ReadLine());


            //int[] num1 = { -5, 1, 5, 0, -7 };
            //LeetCode1732(num1);

            //int[] num2 = { 1, 2, 3 };
            //Console.WriteLine(LeetCode724(num2));

            //int[] num3 = { 1, 2, 3 };
            //Console.WriteLine(LetCode560(num3, 3));

            //string nm = Console.ReadLine() ;
            //string group = Console.ReadLine();
            //string auds = Console.ReadLine();
            //C_Solution(nm, group, auds);

            Console.WriteLine(LeetCode1657("aaabbbbccddeeeeefffff", "aaaaabbcccdddeeeeffff"));
        }
    }
}
