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




        public static void Main(string[] args)
        {
            //A_Solution();

            //B_Solution(Console.ReadLine(), Console.ReadLine());


            //int[] num1 = { -5, 1, 5, 0, -7 };
            //LeetCode1732(num1);

            //int[] num2 = { 1, 2, 3 };
            //Console.WriteLine(LeetCode724(num2));

            int[] num3 = { 1, 2, 3 };
            Console.WriteLine(LetCode560(num3, 3));
        }
    }
}
