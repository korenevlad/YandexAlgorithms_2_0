using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexAlgorithms_2_0
{
    public class Homework3
    {

        //public static void A_Solution(string firstStr, string secondStr)
        //{
        //    string[] firstMasStr = firstStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //    string[] secodMasStr = secondStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        //    HashSet<string> hashStr = new HashSet<string>();
        //    for (int i = 0; i < firstMasStr.Length; i++)
        //    {
        //        hashStr.Add(firstMasStr[i]);
        //    }
        //    int count = 0;
        //    for (int i = 0; i < secodMasStr.Length; i++)
        //    {
        //        if (hashStr.Contains(secodMasStr[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);
        //}

        //public static void B_Solution(string str)
        //{
        //    string[] strMas = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //    HashSet<string> strHash = new HashSet<string>();
        //    for (int i =0; i < strMas.Length; i++)
        //    {
        //        if (strHash.Contains(strMas[i]))
        //        {
        //            Console.WriteLine("YES");
        //        }
        //        else
        //        {
        //            Console.WriteLine("NO");
        //            strHash.Add(strMas[i]);
        //        }
        //    }
        //}

        public static void C_Solution(string str)
        {
            string[] strMas = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> strList = new List<string>();
            HashSet<string> strHash = new HashSet<string>();
            for (int i =0; i< strMas.Length; i++)
            {
                if (!strHash.Contains(strMas[i]))
                {
                    strHash.Add(strMas[i]);
                    strList.Add(strMas[i]);
                }
                else
                {
                    strList.Remove(strMas[i]);
                }
            }
            foreach (string i in strList)
            {
                Console.WriteLine(i);
            }
        }


        public static void Main(string[] args)
        {
            //Задача А
            //
            //A_Solution(Console.ReadLine(), Console.ReadLine());

            //Задача B
            //
            //B_Solution(Console.ReadLine());

            C_Solution(Console.ReadLine());
        }
    }
}
