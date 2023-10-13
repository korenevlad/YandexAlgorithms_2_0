using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YandexAlgorithms_2_0
{
    public class Homework2
    {

        //Первая таска
        ///
        //public static void MySolutionFirst()
        //{
        //    string str = "";
        //    string tempStr = "";

        //    while (tempStr != "0")
        //    {
        //        tempStr = "";
        //        tempStr = Console.ReadLine();
        //        str += tempStr + " ";
        //    }

        //    string[] strMas = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //    int num = strMas.Length;

        //    int[] intMas = new int[num];
        //    for (int i = 0; i < num; i++)
        //    {
        //        int.TryParse(strMas[i], out intMas[i]);
        //    }

        //    int maxPos = 0;
        //    int max = intMas[maxPos];
        //    for (int i = 1; i < intMas.Length; i++)
        //    {
        //        if (intMas[i] >= max)
        //        {
        //            max = intMas[i];
        //            maxPos = i;
        //        }
        //    }
        //    int count_result = 0;
        //    for (int i = 0; i < intMas.Length; i++)
        //    {
        //        if (intMas[i] == max)
        //        {
        //            count_result++;
        //        }
        //    }
        //    Console.WriteLine(count_result);
        //}



        //Вторая таска
        //
        //public static void MySolutionSecond(string str)
        //{
        //    string[] strMas = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //    int[] intMas = new int[strMas.Length];
        //    for (int i = 0; i < intMas.Length; i++)
        //    {
        //        int.TryParse(strMas[i], out intMas[i]);
        //    }
        //    List<int> distances = new List<int>();
        //    for (int i = 0; i < intMas.Length; i++)
        //    {
        //        if (intMas[i] == 1) 
        //        {
        //            bool flag_plus = false;
        //            bool flag_minus = false;

        //            int pos_plus = i;
        //            while (intMas[pos_plus] != 2)
        //            {
        //                if (pos_plus == 9)
        //                {
        //                    flag_plus = true;
        //                    break;
        //                }
        //                else { pos_plus++; }
        //            }

        //            int pos_minus = i;
        //            while (intMas[pos_minus] != 2)
        //            {
        //                if (pos_minus == 0)
        //                {
        //                    flag_minus = true;
        //                    break;
        //                }
        //                else { pos_minus--; }
        //            }

        //            if(flag_plus == false && flag_minus == true)
        //            {
        //                distances.Add(pos_plus - i);
        //            }
        //            else if (flag_plus == true && flag_minus == false)
        //            {
        //                distances.Add(i - pos_minus);
        //            }
        //            else
        //            {
        //                distances.Add(Math.Min(i - pos_minus, pos_plus - i));
        //            }
        //        }
        //    }
        //    Console.WriteLine(distances.Max());
        //}

        public static void MySolutionFird(string str)
        {
            char[] charMas = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < (charMas.Length / 2); i++)
            {
                if (charMas[i] != charMas[charMas.Length - 1 - i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }

        public static void Main(string[] args)
        {
            //Первая таска
            //
            //MySolutionFirst();

            //Вторая таска
            //
            //MySolutionSecond(Console.ReadLine());

            //Третья таска
            //
            MySolutionFird(Console.ReadLine());
        }
    }
}
