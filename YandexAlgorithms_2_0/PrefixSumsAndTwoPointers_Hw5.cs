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



        public static void Main(string[] args)
        {
            //A_Solution();
            
            B_Solution(Console.ReadLine(), Console.ReadLine());
        }
    }
}
