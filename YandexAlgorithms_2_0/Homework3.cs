using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexAlgorithms_2_0
{
    public class Homework3
    {

        public static void A_Solution(string firstStr, string secondStr)
        {
            string[] firstMasStr = firstStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] secodMasStr = secondStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> hashStr = new HashSet<string>();
            for (int i = 0; i < firstMasStr.Length; i++)
            {
                hashStr.Add(firstMasStr[i]);
            }
            int count = 0;
            for (int i = 0; i < secodMasStr.Length; i++)
            {
                if (hashStr.Contains(secodMasStr[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void Main(string[] args)
        {
            A_Solution(Console.ReadLine(), Console.ReadLine());
        }
    }
}
